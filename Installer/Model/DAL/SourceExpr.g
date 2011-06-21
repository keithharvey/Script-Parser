grammar SourceExpr;
 
options 
{
	language=CSharp2;
	output=AST;
	ASTLabelType=CommonTree; // type of $stat.tree ref etc...
}
tokens {
	ALIAS = 'alias';
	BIND = 'bind';
	EXEC = 'exec';
	RCON = 'rcon';
	INCREMENT = 'incrementvar';
	ECHO = 'echo';
	SAY = 'say';
	META = '//#';
	COMMAND;
	METAINT;
	METATEXT;
}
 
 @header {
	using System.Collections.Generic;
	using Installer.Model;
	using System.Diagnostics;
}
 @members 
{
	Script _script;
}
// PARSER RULES ////////////////////////////////////////////////////

prog [Script passedScriptInstance]
@init { _script = passedScriptInstance; }
	: 	( guiRule { Debug.WriteLine($guiRule.tree.ToStringTree()); } | stat { Debug.WriteLine($stat.tree.ToStringTree()); } | LINEBREAK! )+
	; 
	
stat	:	ALIAS id '"' multExpr '"' -> ^(ALIAS id multExpr)
	|	ALIAS id command -> ^(ALIAS id command)
	|	ALIAS id emptyQuotes? -> ^(ALIAS id)
	|	BIND id '"' multExpr '"'  -> ^(BIND id multExpr)
	|	BIND id command -> ^(BIND id command)
	|	BIND id emptyQuotes? -> ^(BIND id)
	|	RCON? EXEC '"' ID '"' -> ^(EXEC ID RCON?)
	|	RCON? EXEC ID -> ^(EXEC ID RCON?)
	|	command
	|	INCREMENT id id id id -> ^(INCREMENT id id id id)
	|	ECHO '"' ID* '"' -> ECHO
	|	ECHO ID -> ECHO
	|	SAY '"' ID* '"' -> SAY
	|	SAY ID -> SAY
	;
multExpr
	:	innerStat (LINEBREAK! innerStat)+
	;
innerStat
	:	ALIAS ID innerCommand? -> ^(ALIAS ID innerCommand?)
	|	BIND ID innerCommand? -> ^(BIND ID ID?)
	|	innerCommand
	|	INCREMENT ID ID ID ID -> ^(INCREMENT ID ID ID ID)
	|	RCON? EXEC ID -> ^(EXEC ID)
	|	ECHO ID* -> ECHO
	|	SAY ID* -> SAY
	;
	
id	:	ID
	|	'"' ID '"'
	->	ID
	;
command	:	RCON? ID -> ^(COMMAND ID RCON?) // emptyQuotes is illegal here
	|	RCON? ID id -> ^(COMMAND ID id RCON?) 
	;
innerCommand	
	:	RCON? ID -> ^(COMMAND ID RCON?) // emptyQuotes is illegal here
	|	RCON? ID ID -> ^(COMMAND ID ID RCON?) 
	;
guiRule
	:	META guiFields LINEBREAK* stat
		-> 	^(META guiFields stat)
	;

guiFields
scope { bool first; int n; string metaType; }
@init { $guiFields::first = true; $guiFields::n = 0; }
	// we want to find out what the first guiField is always to determine what type it is
	// after that we make sure the current count is less than the number of fields allowed for that type
	//  ( {if (first || n<NumberOfFields)} '"' guiField+ '"' {n++} )+
	:	(guiField {$guiFields::n++;})+
	;
guiField:	identifyingMetaElement
	|	{($guiFields::first==false && $guiFields::n < _script.SupportedMetaData[$guiFields::metaType].NumberOfMetaFields)}?=>('"' metaElement '"')+
		-> metaElement+	
	;
identifyingMetaElement
	:	({$guiFields::first}?=>'"' id1=ID '"'{ $guiFields::metaType=$id1.text; $guiFields::first = false; })
			{_script.SupportedMetaData[$id1.text].IsAValidField($guiFields::n, $id1.text, $guiFields::first) }? 
		-> ID 
	;
metaElement
	:	//if this particular field is an int then only allow one field
		{_script.SupportedMetaData[$guiFields::metaType].FieldIsInt($guiFields::n)}?=>INT
		-> ^(METAINT INT)
	|	{!_script.SupportedMetaData[$guiFields::metaType].FieldIsInt($guiFields::n)}?=>ID+
		-> ^(METATEXT ID+)
	;
 emptyQuotes
 	:	'"''"'
 	;
// LEXER RULES /////////////////////////////////////////////////////

LINEBREAK 
	:	';'
	|	'\r\n'  // Evil DOS
	|	'\r'    // Macintosh
	|	'\n'    // Unix
	;
INT	:	(options { greedy=false;  } :'0'..'9')
	;

ID 	: 	CHARACTER+;

fragment CHARACTER : ~('"' | ';' | '\r' | '\n' | '\r\n' | ' ' | '\t' | '\u000C');
	
WS: (' ' | '\t' | '\u000C')+ { $channel = HIDDEN; };

SLINE_COMMENT	:	'//' ~'#' (~('\r'|'\n'))* { $channel = HIDDEN; };

