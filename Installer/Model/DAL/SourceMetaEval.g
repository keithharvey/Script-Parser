tree grammar SourceMetaEval;

options {
	language=CSharp2;
	tokenVocab=SourceMetaExpr; // read token types from SourceExpr.tokens file
	ASTLabelType=CommonTree; // what is Java type of nodes?
}

@header {
	using System.Collections.Generic;
	using Installer.Helpers;
	using Installer.Model;
	using System.Diagnostics;
}
@members {
	string _description;
	string _altName;
	string _iconPath;
	MetaType _metaType;
	
	string _fileName;
	MetaDataList _metaDataList = new MetaDataList();
	// used to parse descriptions into a single line.
        public static string ArrayToString(IList array, string delimeter)
        {
            string outputString = "";

            foreach (object obj in array)
            {
                outputString += obj.ToString() + delimeter;
            }
            return outputString;
        }
}

// PARSER RULES ////////////////////////////////////////////////////
prog [string currentFile] returns [MetaDataList metaDataListResult]
@init
{
	_fileName = currentFile;
	$metaDataListResult = new MetaDataList();
}
	: 	(metaDecl | whiteSpace)+
		{
			$metaDataListResult = _metaDataList;
		}
	;
whiteSpace
	:	WHITESPACE
	;
metaDecl
	:	oScriptInfo=overallScriptInfo
		{
			_metaDataList.Add($oScriptInfo.metaDataResult);
		}
	|	^(NAME ID metaD=metaData)
		{
			if($metaD.tempMetaData.Type == 0)
			{
				Debug.WriteLine("FUCKUP ==== you didn't put a type in for an implicit meta definition!");
			}
			else
			{
				MetaData meta = new MetaData($ID.text, 
							     $metaD.tempMetaData.Type, 
							     $metaD.tempMetaData.Description, 
							     $metaD.tempMetaData.AltName, 
	     						     $metaD.tempMetaData.IconPath,
							     _fileName);
				_metaDataList.Add(meta);
			}
		}
	|	^(ALIAS ID metaD=metaData)
		{
			if($metaD.tempMetaData.Type != MetaType.Alias && $metaD.tempMetaData.Type != 0)
			{
				MetaData metaToggleAlias = new MetaData($ID.text,
					$metaD.tempMetaData.Type,
					$metaD.tempMetaData.Description,
					$metaD.tempMetaData.AltName,
					$metaD.tempMetaData.IconPath,
					_fileName);
				_metaDataList.Add(metaToggleAlias);
			}
			else
			{
				MetaData metaAlias = new MetaData($ID.text,
					MetaType.Alias,
					$metaD.tempMetaData.Description,
					$metaD.tempMetaData.AltName,
					$metaD.tempMetaData.IconPath,
					_fileName);
				_metaDataList.Add(metaAlias);
			}
		}
	|	^(COMMAND ID metaD=metaData)
		{
			MetaData metaCommand = new MetaData($ID.text,
				MetaType.Command,
				$metaD.tempMetaData.Description,
				$metaD.tempMetaData.AltName,
				$metaD.tempMetaData.IconPath,
				_fileName);
			_metaDataList.Add(metaCommand);
		}
	;
// Overall ScriptInfo definitions
overallScriptInfo returns [MetaData metaDataResult]
	:	^(SCRIPTINFO oName=overallNameStat desc=descStat)
		{
			$metaDataResult = new MetaData($oName.name, 
							MetaType.Script, 
							$desc.desc, 
							$oName.name, 
							String.Empty, 
							_fileName);
		}
	|	^(SCRIPTINFO oName2=overallNameStat)
		{
			$metaDataResult = new MetaData($oName2.name, 
							MetaType.Script,
							String.Empty, 
							$oName2.name, 
							String.Empty,
							_fileName);
		}
	;
overallNameStat returns [string name]
	:	^(SCRIPTNAME nameAtom+=ID+)
		{
			name = ArrayToString($nameAtom, " ");
		}
	;
// meta data definitions
metaData returns [MetaData tempMetaData]
@init
{
	_description = String.Empty;
	_altName = String.Empty;
	_iconPath = String.Empty;
	_metaType = 0; //equivelent to nothin
}
	:	metaStat+
		{
			tempMetaData = new MetaData("temp", _metaType, _description, _altName, _iconPath, _fileName);
		}
	;
metaStat
	:	type=typeStat
		{
			_metaType = $type.type;
		}
	|	desc=descStat
		{
			_description = $desc.desc;
		}
	|	icon=iconStat
		{
			_iconPath = $icon.icon;
		}
	|	altName=altNameStat
		{
			_altName = $altName.altName;
		}
	;
typeStat returns [MetaType type]
	:	KEY
		{
			type = MetaType.Key;
		}
	|	SUBKEY
		{
			type = MetaType.Subkey;
		}
	;
descStat returns [string desc]
	:	^(DESCRIPTION metaDescription+=ID+)
		{
			desc = ArrayToString($metaDescription, " ");
		}
	;
altNameStat returns [string altName]
	:	^(ALTNAME alternateName+=ID+)
		{
			altName = ArrayToString($alternateName, " ");
		}
	;
iconStat returns [string icon]
	:	^(ICON ID)
		{
			icon = $ID.text;
		}
	;
