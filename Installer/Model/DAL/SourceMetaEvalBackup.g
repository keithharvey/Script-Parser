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
}
@members {
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
	:	overallScriptInfo
		{
			_metaDataList.Add($overallScriptInfo.metaDataResult);
		}
	|	^(NAME ID metaData)
		{
			_metaDataList.Add(new MetaData($ID.text, $metaData.tempMetaData.Type, $metaData.tempMetaData.Description, $metaData.tempMetaData.AltName, $metaData.tempMetaData.IconPath, $metaData.tempMetaData.FileName));
		}
	;
// Overall ScriptInfo definitions
overallScriptInfo returns [MetaData metaDataResult]
	:	^(SCRIPTINFO overallNameStat descStat)
		{
			$metaDataResult = new MetaData($overallNameStat.name, MetaType.Script, $descStat.desc, _fileName);
		}
	|	^(SCRIPTINFO overallNameStat)
		{
			$metaDataResult = new MetaData($overallNameStat.name, MetaType.Script, _fileName);
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
	:	metaStat+
	;
metaStat returns [var metaStat]

	:	typeStat
	|	descStat
	|	iconStat
	|	altNameStat
	;
typeStat returns [MetaType type]
	:	^(TYPE TOGGLE)
		{
			type = MetaType.Toggle;
		}
	|	^(TYPE KEY)
		{
			type = MetaType.Key;
		}
	|	^(TYPE SUBKEY)
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
