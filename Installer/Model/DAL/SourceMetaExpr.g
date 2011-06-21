grammar SourceMetaExpr;

options 
{
	language=CSharp2;
	output=AST;
	ASTLabelType=CommonTree; // type of $stat.tree ref etc...
}
tokens {
	ALIAS = 'alias';
	BIND = 'bind';
	RCON = 'rcon';
	EXEC = 'exec';
	META = '///';
	METADATA;
	COMMAND;
	TYPE;
	SCRIPTINFO;
	WHITESPACE;
}
@header {
	using System.Diagnostics;
}
// PARSER RULES ////////////////////////////////////////////////////
prog	: 	( metaDecl /*{ Debug.WriteLine($metaDecl.tree.ToStringTree());}*/ | whiteSpace | NEWLINE! )+
	;
metaDecl:	overallScriptInfo
	|	explicitMetaData
	|	metaData NEWLINE ALIAS id unNeededLineEnding -> ^(ALIAS id metaData)
	|	metaData NEWLINE RCON? id unNeededLineEnding -> ^(COMMAND id metaData)
	;
whiteSpace
	:	ALIAS id unNeededLineEnding -> WHITESPACE // for alias shit we don't care about
	|	RCON? id unNeededLineEnding -> WHITESPACE // for alias shit we don't care about
	|	BIND id unNeededLineEnding -> WHITESPACE
	|	RCON? EXEC id unNeededLineEnding -> WHITESPACE
	;
unNeededLineEnding
	:	('"' | SEMI | RCON | EXEC | BIND | ID | ALIAS)* (NEWLINE | EOF)
	;
// ScriptInfo definitions
overallScriptInfo
	:	overallNameStat linebreak descStat linebreak
	->	^(SCRIPTINFO overallNameStat descStat)
	|	overallNameStat linebreak
	->	^(SCRIPTINFO overallNameStat)
	;
overallNameStat
	:	SCRIPTNAME id+ -> ^(SCRIPTNAME id+)
	;
// meta data definitions
explicitMetaData
	:	NAME id NEWLINE metaData NEWLINE -> ^(NAME id metaData)
	;
metaData:	metaStat (linebreak metaStat)* -> metaStat+
	;
metaStat:	typeStat
	|	descStat
	|	iconStat
	|	altNameStat
	;
typeStat:	TOGGLE -> TOGGLE
	|	KEY -> KEY
	|	SUBKEY -> SUBKEY
	;
descStat:	DESCRIPTION id+ -> ^(DESCRIPTION id+)
	;
altNameStat
	:	ALTNAME id+ -> ^(ALTNAME id+)
	;
iconStat
	:	ICON id -> ^(ICON id)
	;
id	:	'"'! ID '"'!
	|	ID
	;
linebreak
	:	SEMI
	|	NEWLINE
	;
// LEXER RULES /////////////////////////////////////////////////////
SEMI	:	';'
	;
NEWLINE
	:	'\r\n'  // Evil DOS
	|	'\r'    // Macintosh (still evil)
	|	'\n'    // Unix (too simple)
	;
NAME	:	META ' '* ('name:' | 'name')
	|	META ' '* ('prefix:' | 'prefix')
	;
DESCRIPTION
	:	META ' '* 'description'
	|	META ' '* 'description:'
	;
SCRIPTNAME
	:	META ' '* 'script name'
	|	META ' '* 'script name:'
	;
ALTNAME	:	META ' '* 'alt name'
	|	META ' '* 'alt name:'
	;
ICON	:	META ' '* 'icon'
	|	META ' '* 'icon:'
	;
TOGGLE 	:	META ' '* 'type' ' '* 'toggle'
	|	META ' '* 'type:' ' '* 'toggle'
	;
KEY 	:	META ' '* 'type' ' '* 'key'
	|	META ' '* 'type:' ' '* 'key'
	;
SUBKEY 	:	META ' '* 'type' ' '* 'subkey'
	|	META ' '* 'type:' ' '* 'subkey'
	;
SL_COMMENT 
	: '//' ~('/' | '\r' | '\n'). (~('\r'| '\n'))*
	{ $channel=HIDDEN; }
	;
WS	: (' ' | '\t' | '\u000C')+ { $channel = HIDDEN; };

ID : CHARACTER+;
fragment CHARACTER : ~('"' | ';' | '\r' | '\n' | '\r\n' | ' ' | '\t' | '\u000C');
