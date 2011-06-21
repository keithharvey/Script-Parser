grammar SourceMetaExpr;

options 
{
	//language=CSharp2;
	output=AST;
	ASTLabelType=CommonTree; // type of $stat.tree ref etc...
}
tokens {
	ALIAS = 'alias';
	BIND = 'bind';
	RCON = 'rcon';
	META = '///';
	METADATA;
	TYPE;
	SCRIPTINFO;
	WHITESPACE;
}
// PARSER RULES ////////////////////////////////////////////////////
prog	: 	( metaDecl /*{ Console.WriteLine($metaDecl.tree.ToStringTree());}*/ | whiteSpace | NEWLINE! )+
	;
metaDecl:	metaData NEWLINE ALIAS id unNeededLineEnding -> ^(NAME id metaData)
	|	metaData NEWLINE RCON? id unNeededLineEnding -> ^(NAME id metaData)
	|	overallScriptInfo
	|	explicitMetaData
	;
whiteSpace
	:	ALIAS id unNeededLineEnding -> WHITESPACE// for alias shit we don't care about
	|	RCON? id unNeededLineEnding -> WHITESPACE // for alias shit we don't care about
	|	BIND id unNeededLineEnding -> WHITESPACE
	;
unNeededLineEnding
	:	('"' | SEMI | RCON | BIND | ID | ALIAS)* (NEWLINE | EOF)
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
	:	NAME id NEWLINE metaData -> ^(NAME id metaData)
	;
metaData:	metaStat (linebreak metaStat)* -> metaStat+
	;
metaStat:	typeStat
	|	descStat
	|	iconStat
	|	altNameStat
	;
typeStat:	TOGGLE -> ^(TYPE TOGGLE)
	|	KEY -> ^(TYPE KEY)
	|	SUBKEY -> ^(TYPE SUBKEY)
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
	|	'\r'    // Macintosh
	|	'\n'    // Unix
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
fragment CHARACTER : ~('"' | '/' | ';' | '\r' | '\n' | '\r\n' | ' ' | '\t' | '\u000C');
