tree grammar SourceEval;

options {
	language=CSharp2;
	tokenVocab=SourceExpr; // read token types from SourceExpr.tokens file
	ASTLabelType=CommonTree; // what is type of nodes?
	output=true;
}

@header {
	using System.Collections.Generic;
	using Installer.Model;
	using System.Diagnostics;
}


@members 
{
	Script _script;
	MetaData<IMeta> currentMetaData = null;
}
prog [Script passedScriptInstance]
@init { _script = passedScriptInstance; }
	: 	(guiRule | stat {currentMetaData = null;})+
	;

stat
	:	a=alias {if($a.alias != null) {_script.Content.Add($a.alias);}}
	|	b=bind {if($b.bind != null) {_script.Content.Add($b.bind);}}
	|	e=exec  {if($e.exec != null) {_script.Content.Add($e.exec);}}
	|	c=command {if($c.command !=null) {_script.Content.Add($c.command);}}
	|	increment
	|	ECHO
	|	SAY
	;


alias returns [Alias alias]
	// Alias(string identifier, List<Statement> value, StatementType statementType, MetaData metaData)
	@init { List<IStatement> innerList = new List<IStatement>(); }
	:	^(ALIAS ID  (id=innerStat{if($id.innerStat != null) {innerList.Add($id.innerStat);}} )+ ) 
			{alias = new Alias($ID.text, innerList , StatementType.Alias, currentMetaData); }
	|	sA=simpleAlias {alias = $sA.simpleAlias;}
	;

bind returns [Bind bind]
	// Bind(string key, List<IStatement> value, StatementType statementType, MetaData metaData)
	@init{ List<IStatement> innerList = new List<IStatement>(); }
	:	^(BIND ID ( id=innerStat{if($id.innerStat != null) {innerList.Add($id.innerStat);}} )+) 
			{ bind = new Bind($ID.text, innerList, StatementType.Alias, currentMetaData); }
	|	sB=simpleBind {bind = $sB.simpleBind; }
	;
	
innerStat returns [IStatement innerStat]
	:	sA=simpleAlias { innerStat = $sA.simpleAlias; }
	|	sB=simpleBind { innerStat = $sB.simpleBind; }
	|	c=command { innerStat = $c.command; }
	|	increment { innerStat = null; }
	|	e=exec { innerStat = $e.exec; }
	|	ECHO
	|	SAY
	;
	
simpleAlias returns [Alias simpleAlias]
	// Alias(string identifier, List<Statement> value, StatementType statementType, MetaData metaData)
	@init{ string id1 = null; List<IStatement> statList = new List<IStatement>(); }
	@after{ simpleAlias = new Alias(id1, statList, StatementType.Alias, currentMetaData); }
	:	^(ALIAS i1=ID) { id1 = $i1.text; }
	|	^(ALIAS i1=ID c=command) { id1 = $i1.text; statList.Add($c.command); }
	;


simpleBind returns [Bind simpleBind]
	// Bind(string key, List<IStatement> value, StatementType statementType, MetaData metaData)
	@init{ string id1 = null; List<IStatement> statList = new List<IStatement>(); }
	@after{ simpleBind = new Bind(id1, statList, StatementType.Bind, currentMetaData); }
	:	^(BIND i1=ID) { id1 = $i1.text; }
	|	^(BIND i1=ID c=command) { id1 = $i1.text; statList.Add($c.command); }
	;

increment
	:	^(INCREMENT ID ID ID ID)
	;

	
exec returns [Exec exec]
	@init{ string id1 = null;  bool rcon=false; }
	@after{ exec = new Exec(id1, StatementType.Exec, currentMetaData, rcon); }
	:	^(EXEC i1=ID) {id1=$i1.text;}
	|	^(EXEC i1=ID RCON) {id1=$i1.text; rcon=true;}
	;

command returns [Command command]
	// Command(string identifier, string value, StatementType statementType, MetaData metaData, bool rcon)
	@init{ string id1 = null; string id2 = null;  bool rcon=false; }
	@after{ command = new Command(id1, id2, StatementType.Command, currentMetaData, rcon); }
	:	^(COMMAND ID) { id1 = $ID.text; }
	|	^(COMMAND i1=ID i2=ID) { id1 = $i1.text; id2=$i2.text; }
	|	^(COMMAND i1=ID i2=ID RCON) { id1 = $i1.text; id2=$i2.text; rcon=true; }
	;

guiRule
	:	^(META guiFields stat)
	;

guiFields
	scope { bool first; int n; string metaType; }
	@init { $guiFields::first = true; $guiFields::n = 0; }
	//  ( {if (first || n<NumberOfFields)} '"' guiField+ '"' {n++} )+
	:	(guiField {$guiFields::n++;})+
	;
guiField
	:	{$guiFields::first}?=>
			id1=ID
			{$guiFields::metaType=$id1.text; 
			$guiFields::first = false;
			currentMetaData = new MetaData<IMeta>(_script.SupportedMetaData[$guiFields::metaType]);
			currentMetaData.MetaInfo.AddMetaField($guiFields::n, $id1.text); 
			}
	|	{$guiFields::first==false}?=>(metaElement{$guiFields::n++;} )+
	;

metaElement
	:	^(METAINT int1=INT) {currentMetaData.MetaInfo.AddMetaField($guiFields::n, $int1.int); }
	|	{string metaText = String.Empty;}
		^(METATEXT (id1=ID {metaText+=" " + id1;} )+) {currentMetaData.MetaInfo.AddMetaField($guiFields::n, metaText); }
	;
	
