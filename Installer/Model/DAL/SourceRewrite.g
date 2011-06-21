tree grammar SourceRewrite;

options {
	language=CSharp2;
	tokenVocab=SourceExpr; // read token types from SourceExpr.tokens file
	ASTLabelType=CommonTree;
	output=template;
	rewrite=true;
}

@header {
	using System.Collections.Generic;
	using Installer.Model;
	using System.Diagnostics;
}

@members {
	Script _script = new Script("Temporary");
	Command _commandReplacement;
	
	bool _defaultReached = false;
}
prog [Script script]
@init 
{
	_script = script;
	/*foreach(ToggleAlias toggleAlias in _script.ToggleAliases)
	{
		toggleAlias.ResetNumberOfDefaultChecks();
	}*/
}
	: 	stat+
;
stat
@init
{
	_defaultReached = false;
	_commandReplacement = null;
}	
	:	^(ALIAS ID innerStat*)
	|	^(EXEC ID)
	|	^(BIND ID innerStat*)	
	|	^(INCREMENT ID ID ID ID)
	|	^(COMMAND ID ID)
	|	^(COMMAND ID)
		{
			/*Command tempCommand = new Command($ID.text);
			foreach( ToggleAlias toggleAlias in _script.ToggleAliases)
			{
				if(toggleAlias.CheckThisForStateCommand(tempCommand))
				{
					Debug.WriteLine(tempCommand + " found on check #" + toggleAlias.NumberOfDefaultChecks);
					if(toggleAlias.CheckIfDefaultReached)
					{
						Debug.WriteLine(toggleAlias + " default reached");
						_defaultReached = true;
						_commandReplacement = toggleAlias.CurrentCommand;
					}
				}
			}*/
		}
		-> {_defaultReached}? template(id={_commandReplacement.Name})
		"<id>"
		-> template(same={$ID.text})
		"<same>"
;
innerStat
	:	^(ALIAS ID innerCommand?)
	|	^(EXEC ID)
	|	^(BIND ID innerStat?)
	|	^(INCREMENT ID ID ID ID)
	|	innerCommand
;
innerCommand
	:	^(COMMAND ID)
	|	^(COMMAND ID ID)
;
