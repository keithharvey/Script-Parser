// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g 2011-06-23 01:54:01

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System.Collections.Generic;
	using Installer.Model;
	using System.Diagnostics;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

public partial class SourceExprParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ALIAS", 
		"BIND", 
		"EXEC", 
		"RCON", 
		"INCREMENT", 
		"ECHO", 
		"SAY", 
		"META", 
		"COMMAND", 
		"METAINT", 
		"METATEXT", 
		"LINEBREAK", 
		"ID", 
		"INT", 
		"CHARACTER", 
		"WS", 
		"SLINE_COMMENT", 
		"'\"'"
    };

    public const int T__21 = 21;
    public const int EXEC = 6;
    public const int INT = 17;
    public const int ID = 16;
    public const int EOF = -1;
    public const int METATEXT = 14;
    public const int SAY = 10;
    public const int META = 11;
    public const int CHARACTER = 18;
    public const int COMMAND = 12;
    public const int METAINT = 13;
    public const int INCREMENT = 8;
    public const int ECHO = 9;
    public const int WS = 19;
    public const int BIND = 5;
    public const int ALIAS = 4;
    public const int SLINE_COMMENT = 20;
    public const int LINEBREAK = 15;
    public const int RCON = 7;

    // delegates
    // delegators



        public SourceExprParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SourceExprParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return SourceExprParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g"; }
    }


    	Script _script;


    public class prog_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "prog"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:34:1: prog[Script passedScriptInstance] : ( guiRule | stat | LINEBREAK )+ ;
    public SourceExprParser.prog_return prog(Script passedScriptInstance) // throws RecognitionException [1]
    {   
        SourceExprParser.prog_return retval = new SourceExprParser.prog_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LINEBREAK3 = null;
        SourceExprParser.guiRule_return guiRule1 = default(SourceExprParser.guiRule_return);

        SourceExprParser.stat_return stat2 = default(SourceExprParser.stat_return);


        CommonTree LINEBREAK3_tree=null;

         _script = passedScriptInstance; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:2: ( ( guiRule | stat | LINEBREAK )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:5: ( guiRule | stat | LINEBREAK )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:5: ( guiRule | stat | LINEBREAK )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case META:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case ALIAS:
            	    case BIND:
            	    case EXEC:
            	    case RCON:
            	    case INCREMENT:
            	    case ECHO:
            	    case SAY:
            	    case ID:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;
            	    case LINEBREAK:
            	    	{
            	        alt1 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:7: guiRule
            			    {
            			    	PushFollow(FOLLOW_guiRule_in_prog140);
            			    	guiRule1 = guiRule();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, guiRule1.Tree);
            			    	 Debug.WriteLine(((guiRule1 != null) ? ((CommonTree)guiRule1.Tree) : null).ToStringTree()); 

            			    }
            			    break;
            			case 2 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:68: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog146);
            			    	stat2 = stat();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, stat2.Tree);
            			    	 Debug.WriteLine(((stat2 != null) ? ((CommonTree)stat2.Tree) : null).ToStringTree()); 

            			    }
            			    break;
            			case 3 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:123: LINEBREAK
            			    {
            			    	LINEBREAK3=(IToken)Match(input,LINEBREAK,FOLLOW_LINEBREAK_in_prog152); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "prog"

    public class stat_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "stat"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:39:1: stat : ( ALIAS id '\"' multExpr '\"' -> ^( ALIAS id multExpr ) | ALIAS id command -> ^( ALIAS id command ) | ALIAS id ( emptyQuotes )? -> ^( ALIAS id ) | BIND id '\"' multExpr '\"' -> ^( BIND id multExpr ) | BIND id command -> ^( BIND id command ) | BIND id ( emptyQuotes )? -> ^( BIND id ) | ( RCON )? EXEC '\"' ID '\"' -> ^( EXEC ID ( RCON )? ) | ( RCON )? EXEC ID -> ^( EXEC ID ( RCON )? ) | command | INCREMENT id id id id -> ^( INCREMENT id id id id ) | ECHO '\"' ( ID )* '\"' -> ECHO | ECHO ID -> ECHO | SAY '\"' ( ID )* '\"' -> SAY | SAY ID -> SAY );
    public SourceExprParser.stat_return stat() // throws RecognitionException [1]
    {   
        SourceExprParser.stat_return retval = new SourceExprParser.stat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ALIAS4 = null;
        IToken char_literal6 = null;
        IToken char_literal8 = null;
        IToken ALIAS9 = null;
        IToken ALIAS12 = null;
        IToken BIND15 = null;
        IToken char_literal17 = null;
        IToken char_literal19 = null;
        IToken BIND20 = null;
        IToken BIND23 = null;
        IToken RCON26 = null;
        IToken EXEC27 = null;
        IToken char_literal28 = null;
        IToken ID29 = null;
        IToken char_literal30 = null;
        IToken RCON31 = null;
        IToken EXEC32 = null;
        IToken ID33 = null;
        IToken INCREMENT35 = null;
        IToken ECHO40 = null;
        IToken char_literal41 = null;
        IToken ID42 = null;
        IToken char_literal43 = null;
        IToken ECHO44 = null;
        IToken ID45 = null;
        IToken SAY46 = null;
        IToken char_literal47 = null;
        IToken ID48 = null;
        IToken char_literal49 = null;
        IToken SAY50 = null;
        IToken ID51 = null;
        SourceExprParser.id_return id5 = default(SourceExprParser.id_return);

        SourceExprParser.multExpr_return multExpr7 = default(SourceExprParser.multExpr_return);

        SourceExprParser.id_return id10 = default(SourceExprParser.id_return);

        SourceExprParser.command_return command11 = default(SourceExprParser.command_return);

        SourceExprParser.id_return id13 = default(SourceExprParser.id_return);

        SourceExprParser.emptyQuotes_return emptyQuotes14 = default(SourceExprParser.emptyQuotes_return);

        SourceExprParser.id_return id16 = default(SourceExprParser.id_return);

        SourceExprParser.multExpr_return multExpr18 = default(SourceExprParser.multExpr_return);

        SourceExprParser.id_return id21 = default(SourceExprParser.id_return);

        SourceExprParser.command_return command22 = default(SourceExprParser.command_return);

        SourceExprParser.id_return id24 = default(SourceExprParser.id_return);

        SourceExprParser.emptyQuotes_return emptyQuotes25 = default(SourceExprParser.emptyQuotes_return);

        SourceExprParser.command_return command34 = default(SourceExprParser.command_return);

        SourceExprParser.id_return id36 = default(SourceExprParser.id_return);

        SourceExprParser.id_return id37 = default(SourceExprParser.id_return);

        SourceExprParser.id_return id38 = default(SourceExprParser.id_return);

        SourceExprParser.id_return id39 = default(SourceExprParser.id_return);


        CommonTree ALIAS4_tree=null;
        CommonTree char_literal6_tree=null;
        CommonTree char_literal8_tree=null;
        CommonTree ALIAS9_tree=null;
        CommonTree ALIAS12_tree=null;
        CommonTree BIND15_tree=null;
        CommonTree char_literal17_tree=null;
        CommonTree char_literal19_tree=null;
        CommonTree BIND20_tree=null;
        CommonTree BIND23_tree=null;
        CommonTree RCON26_tree=null;
        CommonTree EXEC27_tree=null;
        CommonTree char_literal28_tree=null;
        CommonTree ID29_tree=null;
        CommonTree char_literal30_tree=null;
        CommonTree RCON31_tree=null;
        CommonTree EXEC32_tree=null;
        CommonTree ID33_tree=null;
        CommonTree INCREMENT35_tree=null;
        CommonTree ECHO40_tree=null;
        CommonTree char_literal41_tree=null;
        CommonTree ID42_tree=null;
        CommonTree char_literal43_tree=null;
        CommonTree ECHO44_tree=null;
        CommonTree ID45_tree=null;
        CommonTree SAY46_tree=null;
        CommonTree char_literal47_tree=null;
        CommonTree ID48_tree=null;
        CommonTree char_literal49_tree=null;
        CommonTree SAY50_tree=null;
        CommonTree ID51_tree=null;
        RewriteRuleTokenStream stream_21 = new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleTokenStream stream_INCREMENT = new RewriteRuleTokenStream(adaptor,"token INCREMENT");
        RewriteRuleTokenStream stream_ECHO = new RewriteRuleTokenStream(adaptor,"token ECHO");
        RewriteRuleTokenStream stream_EXEC = new RewriteRuleTokenStream(adaptor,"token EXEC");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_SAY = new RewriteRuleTokenStream(adaptor,"token SAY");
        RewriteRuleTokenStream stream_BIND = new RewriteRuleTokenStream(adaptor,"token BIND");
        RewriteRuleTokenStream stream_RCON = new RewriteRuleTokenStream(adaptor,"token RCON");
        RewriteRuleTokenStream stream_ALIAS = new RewriteRuleTokenStream(adaptor,"token ALIAS");
        RewriteRuleSubtreeStream stream_id = new RewriteRuleSubtreeStream(adaptor,"rule id");
        RewriteRuleSubtreeStream stream_multExpr = new RewriteRuleSubtreeStream(adaptor,"rule multExpr");
        RewriteRuleSubtreeStream stream_command = new RewriteRuleSubtreeStream(adaptor,"rule command");
        RewriteRuleSubtreeStream stream_emptyQuotes = new RewriteRuleSubtreeStream(adaptor,"rule emptyQuotes");
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:39:6: ( ALIAS id '\"' multExpr '\"' -> ^( ALIAS id multExpr ) | ALIAS id command -> ^( ALIAS id command ) | ALIAS id ( emptyQuotes )? -> ^( ALIAS id ) | BIND id '\"' multExpr '\"' -> ^( BIND id multExpr ) | BIND id command -> ^( BIND id command ) | BIND id ( emptyQuotes )? -> ^( BIND id ) | ( RCON )? EXEC '\"' ID '\"' -> ^( EXEC ID ( RCON )? ) | ( RCON )? EXEC ID -> ^( EXEC ID ( RCON )? ) | command | INCREMENT id id id id -> ^( INCREMENT id id id id ) | ECHO '\"' ( ID )* '\"' -> ECHO | ECHO ID -> ECHO | SAY '\"' ( ID )* '\"' -> SAY | SAY ID -> SAY )
            int alt8 = 14;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:39:8: ALIAS id '\"' multExpr '\"'
                    {
                    	ALIAS4=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_stat168);  
                    	stream_ALIAS.Add(ALIAS4);

                    	PushFollow(FOLLOW_id_in_stat170);
                    	id5 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id5.Tree);
                    	char_literal6=(IToken)Match(input,21,FOLLOW_21_in_stat172);  
                    	stream_21.Add(char_literal6);

                    	PushFollow(FOLLOW_multExpr_in_stat174);
                    	multExpr7 = multExpr();
                    	state.followingStackPointer--;

                    	stream_multExpr.Add(multExpr7.Tree);
                    	char_literal8=(IToken)Match(input,21,FOLLOW_21_in_stat176);  
                    	stream_21.Add(char_literal8);



                    	// AST REWRITE
                    	// elements:          multExpr, id, ALIAS
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 39:34: -> ^( ALIAS id multExpr )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:39:37: ^( ALIAS id multExpr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_ALIAS.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    adaptor.AddChild(root_1, stream_multExpr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:40:4: ALIAS id command
                    {
                    	ALIAS9=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_stat191);  
                    	stream_ALIAS.Add(ALIAS9);

                    	PushFollow(FOLLOW_id_in_stat193);
                    	id10 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id10.Tree);
                    	PushFollow(FOLLOW_command_in_stat195);
                    	command11 = command();
                    	state.followingStackPointer--;

                    	stream_command.Add(command11.Tree);


                    	// AST REWRITE
                    	// elements:          id, command, ALIAS
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 40:21: -> ^( ALIAS id command )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:40:24: ^( ALIAS id command )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_ALIAS.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    adaptor.AddChild(root_1, stream_command.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:41:4: ALIAS id ( emptyQuotes )?
                    {
                    	ALIAS12=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_stat210);  
                    	stream_ALIAS.Add(ALIAS12);

                    	PushFollow(FOLLOW_id_in_stat212);
                    	id13 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id13.Tree);
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:41:13: ( emptyQuotes )?
                    	int alt2 = 2;
                    	int LA2_0 = input.LA(1);

                    	if ( (LA2_0 == 21) )
                    	{
                    	    alt2 = 1;
                    	}
                    	switch (alt2) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:41:13: emptyQuotes
                    	        {
                    	        	PushFollow(FOLLOW_emptyQuotes_in_stat214);
                    	        	emptyQuotes14 = emptyQuotes();
                    	        	state.followingStackPointer--;

                    	        	stream_emptyQuotes.Add(emptyQuotes14.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          ALIAS, id
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 41:26: -> ^( ALIAS id )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:41:29: ^( ALIAS id )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_ALIAS.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_id.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:42:4: BIND id '\"' multExpr '\"'
                    {
                    	BIND15=(IToken)Match(input,BIND,FOLLOW_BIND_in_stat228);  
                    	stream_BIND.Add(BIND15);

                    	PushFollow(FOLLOW_id_in_stat230);
                    	id16 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id16.Tree);
                    	char_literal17=(IToken)Match(input,21,FOLLOW_21_in_stat232);  
                    	stream_21.Add(char_literal17);

                    	PushFollow(FOLLOW_multExpr_in_stat234);
                    	multExpr18 = multExpr();
                    	state.followingStackPointer--;

                    	stream_multExpr.Add(multExpr18.Tree);
                    	char_literal19=(IToken)Match(input,21,FOLLOW_21_in_stat236);  
                    	stream_21.Add(char_literal19);



                    	// AST REWRITE
                    	// elements:          BIND, id, multExpr
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 42:30: -> ^( BIND id multExpr )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:42:33: ^( BIND id multExpr )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_BIND.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    adaptor.AddChild(root_1, stream_multExpr.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 5 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:43:4: BIND id command
                    {
                    	BIND20=(IToken)Match(input,BIND,FOLLOW_BIND_in_stat252);  
                    	stream_BIND.Add(BIND20);

                    	PushFollow(FOLLOW_id_in_stat254);
                    	id21 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id21.Tree);
                    	PushFollow(FOLLOW_command_in_stat256);
                    	command22 = command();
                    	state.followingStackPointer--;

                    	stream_command.Add(command22.Tree);


                    	// AST REWRITE
                    	// elements:          id, command, BIND
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 43:20: -> ^( BIND id command )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:43:23: ^( BIND id command )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_BIND.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    adaptor.AddChild(root_1, stream_command.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 6 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:44:4: BIND id ( emptyQuotes )?
                    {
                    	BIND23=(IToken)Match(input,BIND,FOLLOW_BIND_in_stat271);  
                    	stream_BIND.Add(BIND23);

                    	PushFollow(FOLLOW_id_in_stat273);
                    	id24 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id24.Tree);
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:44:12: ( emptyQuotes )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 21) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:44:12: emptyQuotes
                    	        {
                    	        	PushFollow(FOLLOW_emptyQuotes_in_stat275);
                    	        	emptyQuotes25 = emptyQuotes();
                    	        	state.followingStackPointer--;

                    	        	stream_emptyQuotes.Add(emptyQuotes25.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          id, BIND
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 44:25: -> ^( BIND id )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:44:28: ^( BIND id )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_BIND.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_id.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 7 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:45:4: ( RCON )? EXEC '\"' ID '\"'
                    {
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:45:4: ( RCON )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == RCON) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:45:4: RCON
                    	        {
                    	        	RCON26=(IToken)Match(input,RCON,FOLLOW_RCON_in_stat289);  
                    	        	stream_RCON.Add(RCON26);


                    	        }
                    	        break;

                    	}

                    	EXEC27=(IToken)Match(input,EXEC,FOLLOW_EXEC_in_stat292);  
                    	stream_EXEC.Add(EXEC27);

                    	char_literal28=(IToken)Match(input,21,FOLLOW_21_in_stat294);  
                    	stream_21.Add(char_literal28);

                    	ID29=(IToken)Match(input,ID,FOLLOW_ID_in_stat296);  
                    	stream_ID.Add(ID29);

                    	char_literal30=(IToken)Match(input,21,FOLLOW_21_in_stat298);  
                    	stream_21.Add(char_literal30);



                    	// AST REWRITE
                    	// elements:          EXEC, ID, RCON
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 45:26: -> ^( EXEC ID ( RCON )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:45:29: ^( EXEC ID ( RCON )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EXEC.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:45:39: ( RCON )?
                    	    if ( stream_RCON.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_RCON.NextNode());

                    	    }
                    	    stream_RCON.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 8 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:46:4: ( RCON )? EXEC ID
                    {
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:46:4: ( RCON )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == RCON) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:46:4: RCON
                    	        {
                    	        	RCON31=(IToken)Match(input,RCON,FOLLOW_RCON_in_stat314);  
                    	        	stream_RCON.Add(RCON31);


                    	        }
                    	        break;

                    	}

                    	EXEC32=(IToken)Match(input,EXEC,FOLLOW_EXEC_in_stat317);  
                    	stream_EXEC.Add(EXEC32);

                    	ID33=(IToken)Match(input,ID,FOLLOW_ID_in_stat319);  
                    	stream_ID.Add(ID33);



                    	// AST REWRITE
                    	// elements:          ID, EXEC, RCON
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 46:18: -> ^( EXEC ID ( RCON )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:46:21: ^( EXEC ID ( RCON )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EXEC.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:46:31: ( RCON )?
                    	    if ( stream_RCON.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_RCON.NextNode());

                    	    }
                    	    stream_RCON.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 9 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:47:4: command
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_command_in_stat335);
                    	command34 = command();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, command34.Tree);

                    }
                    break;
                case 10 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:48:4: INCREMENT id id id id
                    {
                    	INCREMENT35=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_stat340);  
                    	stream_INCREMENT.Add(INCREMENT35);

                    	PushFollow(FOLLOW_id_in_stat342);
                    	id36 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id36.Tree);
                    	PushFollow(FOLLOW_id_in_stat344);
                    	id37 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id37.Tree);
                    	PushFollow(FOLLOW_id_in_stat346);
                    	id38 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id38.Tree);
                    	PushFollow(FOLLOW_id_in_stat348);
                    	id39 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id39.Tree);


                    	// AST REWRITE
                    	// elements:          id, id, INCREMENT, id, id
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 48:26: -> ^( INCREMENT id id id id )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:48:29: ^( INCREMENT id id id id )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_INCREMENT.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    adaptor.AddChild(root_1, stream_id.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 11 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:49:4: ECHO '\"' ( ID )* '\"'
                    {
                    	ECHO40=(IToken)Match(input,ECHO,FOLLOW_ECHO_in_stat367);  
                    	stream_ECHO.Add(ECHO40);

                    	char_literal41=(IToken)Match(input,21,FOLLOW_21_in_stat369);  
                    	stream_21.Add(char_literal41);

                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:49:13: ( ID )*
                    	do 
                    	{
                    	    int alt6 = 2;
                    	    int LA6_0 = input.LA(1);

                    	    if ( (LA6_0 == ID) )
                    	    {
                    	        alt6 = 1;
                    	    }


                    	    switch (alt6) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:49:13: ID
                    			    {
                    			    	ID42=(IToken)Match(input,ID,FOLLOW_ID_in_stat371);  
                    			    	stream_ID.Add(ID42);


                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	char_literal43=(IToken)Match(input,21,FOLLOW_21_in_stat374);  
                    	stream_21.Add(char_literal43);



                    	// AST REWRITE
                    	// elements:          ECHO
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 49:21: -> ECHO
                    	{
                    	    adaptor.AddChild(root_0, stream_ECHO.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 12 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:50:4: ECHO ID
                    {
                    	ECHO44=(IToken)Match(input,ECHO,FOLLOW_ECHO_in_stat383);  
                    	stream_ECHO.Add(ECHO44);

                    	ID45=(IToken)Match(input,ID,FOLLOW_ID_in_stat385);  
                    	stream_ID.Add(ID45);



                    	// AST REWRITE
                    	// elements:          ECHO
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 50:12: -> ECHO
                    	{
                    	    adaptor.AddChild(root_0, stream_ECHO.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 13 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:51:4: SAY '\"' ( ID )* '\"'
                    {
                    	SAY46=(IToken)Match(input,SAY,FOLLOW_SAY_in_stat394);  
                    	stream_SAY.Add(SAY46);

                    	char_literal47=(IToken)Match(input,21,FOLLOW_21_in_stat396);  
                    	stream_21.Add(char_literal47);

                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:51:12: ( ID )*
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( (LA7_0 == ID) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:51:12: ID
                    			    {
                    			    	ID48=(IToken)Match(input,ID,FOLLOW_ID_in_stat398);  
                    			    	stream_ID.Add(ID48);


                    			    }
                    			    break;

                    			default:
                    			    goto loop7;
                    	    }
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	char_literal49=(IToken)Match(input,21,FOLLOW_21_in_stat401);  
                    	stream_21.Add(char_literal49);



                    	// AST REWRITE
                    	// elements:          SAY
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 51:20: -> SAY
                    	{
                    	    adaptor.AddChild(root_0, stream_SAY.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 14 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:52:4: SAY ID
                    {
                    	SAY50=(IToken)Match(input,SAY,FOLLOW_SAY_in_stat410);  
                    	stream_SAY.Add(SAY50);

                    	ID51=(IToken)Match(input,ID,FOLLOW_ID_in_stat412);  
                    	stream_ID.Add(ID51);



                    	// AST REWRITE
                    	// elements:          SAY
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 52:11: -> SAY
                    	{
                    	    adaptor.AddChild(root_0, stream_SAY.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "stat"

    public class multExpr_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "multExpr"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:54:1: multExpr : innerStat ( LINEBREAK innerStat )+ ;
    public SourceExprParser.multExpr_return multExpr() // throws RecognitionException [1]
    {   
        SourceExprParser.multExpr_return retval = new SourceExprParser.multExpr_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LINEBREAK53 = null;
        SourceExprParser.innerStat_return innerStat52 = default(SourceExprParser.innerStat_return);

        SourceExprParser.innerStat_return innerStat54 = default(SourceExprParser.innerStat_return);


        CommonTree LINEBREAK53_tree=null;

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:55:2: ( innerStat ( LINEBREAK innerStat )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:55:4: innerStat ( LINEBREAK innerStat )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_innerStat_in_multExpr426);
            	innerStat52 = innerStat();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, innerStat52.Tree);
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:55:14: ( LINEBREAK innerStat )+
            	int cnt9 = 0;
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == LINEBREAK) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:55:15: LINEBREAK innerStat
            			    {
            			    	LINEBREAK53=(IToken)Match(input,LINEBREAK,FOLLOW_LINEBREAK_in_multExpr429); 
            			    	PushFollow(FOLLOW_innerStat_in_multExpr432);
            			    	innerStat54 = innerStat();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, innerStat54.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt9 >= 1 ) goto loop9;
            		            EarlyExitException eee9 =
            		                new EarlyExitException(9, input);
            		            throw eee9;
            	    }
            	    cnt9++;
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multExpr"

    public class innerStat_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "innerStat"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:57:1: innerStat : ( ALIAS ID ( innerCommand )? -> ^( ALIAS ID ( innerCommand )? ) | BIND ID ( innerCommand )? -> ^( BIND ID ( ID )? ) | innerCommand | INCREMENT ID ID ID ID -> ^( INCREMENT ID ID ID ID ) | ( RCON )? EXEC ID -> ^( EXEC ID ) | ECHO ( ID )* -> ECHO | SAY ( ID )* -> SAY );
    public SourceExprParser.innerStat_return innerStat() // throws RecognitionException [1]
    {   
        SourceExprParser.innerStat_return retval = new SourceExprParser.innerStat_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ALIAS55 = null;
        IToken ID56 = null;
        IToken BIND58 = null;
        IToken ID59 = null;
        IToken INCREMENT62 = null;
        IToken ID63 = null;
        IToken ID64 = null;
        IToken ID65 = null;
        IToken ID66 = null;
        IToken RCON67 = null;
        IToken EXEC68 = null;
        IToken ID69 = null;
        IToken ECHO70 = null;
        IToken ID71 = null;
        IToken SAY72 = null;
        IToken ID73 = null;
        SourceExprParser.innerCommand_return innerCommand57 = default(SourceExprParser.innerCommand_return);

        SourceExprParser.innerCommand_return innerCommand60 = default(SourceExprParser.innerCommand_return);

        SourceExprParser.innerCommand_return innerCommand61 = default(SourceExprParser.innerCommand_return);


        CommonTree ALIAS55_tree=null;
        CommonTree ID56_tree=null;
        CommonTree BIND58_tree=null;
        CommonTree ID59_tree=null;
        CommonTree INCREMENT62_tree=null;
        CommonTree ID63_tree=null;
        CommonTree ID64_tree=null;
        CommonTree ID65_tree=null;
        CommonTree ID66_tree=null;
        CommonTree RCON67_tree=null;
        CommonTree EXEC68_tree=null;
        CommonTree ID69_tree=null;
        CommonTree ECHO70_tree=null;
        CommonTree ID71_tree=null;
        CommonTree SAY72_tree=null;
        CommonTree ID73_tree=null;
        RewriteRuleTokenStream stream_INCREMENT = new RewriteRuleTokenStream(adaptor,"token INCREMENT");
        RewriteRuleTokenStream stream_ECHO = new RewriteRuleTokenStream(adaptor,"token ECHO");
        RewriteRuleTokenStream stream_EXEC = new RewriteRuleTokenStream(adaptor,"token EXEC");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_SAY = new RewriteRuleTokenStream(adaptor,"token SAY");
        RewriteRuleTokenStream stream_BIND = new RewriteRuleTokenStream(adaptor,"token BIND");
        RewriteRuleTokenStream stream_RCON = new RewriteRuleTokenStream(adaptor,"token RCON");
        RewriteRuleTokenStream stream_ALIAS = new RewriteRuleTokenStream(adaptor,"token ALIAS");
        RewriteRuleSubtreeStream stream_innerCommand = new RewriteRuleSubtreeStream(adaptor,"rule innerCommand");
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:58:2: ( ALIAS ID ( innerCommand )? -> ^( ALIAS ID ( innerCommand )? ) | BIND ID ( innerCommand )? -> ^( BIND ID ( ID )? ) | innerCommand | INCREMENT ID ID ID ID -> ^( INCREMENT ID ID ID ID ) | ( RCON )? EXEC ID -> ^( EXEC ID ) | ECHO ( ID )* -> ECHO | SAY ( ID )* -> SAY )
            int alt15 = 7;
            switch ( input.LA(1) ) 
            {
            case ALIAS:
            	{
                alt15 = 1;
                }
                break;
            case BIND:
            	{
                alt15 = 2;
                }
                break;
            case RCON:
            	{
                int LA15_3 = input.LA(2);

                if ( (LA15_3 == EXEC) )
                {
                    alt15 = 5;
                }
                else if ( (LA15_3 == ID) )
                {
                    alt15 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d15s3 =
                        new NoViableAltException("", 15, 3, input);

                    throw nvae_d15s3;
                }
                }
                break;
            case ID:
            	{
                alt15 = 3;
                }
                break;
            case INCREMENT:
            	{
                alt15 = 4;
                }
                break;
            case EXEC:
            	{
                alt15 = 5;
                }
                break;
            case ECHO:
            	{
                alt15 = 6;
                }
                break;
            case SAY:
            	{
                alt15 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:58:4: ALIAS ID ( innerCommand )?
                    {
                    	ALIAS55=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_innerStat444);  
                    	stream_ALIAS.Add(ALIAS55);

                    	ID56=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat446);  
                    	stream_ID.Add(ID56);

                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:58:13: ( innerCommand )?
                    	int alt10 = 2;
                    	int LA10_0 = input.LA(1);

                    	if ( (LA10_0 == RCON || LA10_0 == ID) )
                    	{
                    	    alt10 = 1;
                    	}
                    	switch (alt10) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:58:13: innerCommand
                    	        {
                    	        	PushFollow(FOLLOW_innerCommand_in_innerStat448);
                    	        	innerCommand57 = innerCommand();
                    	        	state.followingStackPointer--;

                    	        	stream_innerCommand.Add(innerCommand57.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          innerCommand, ID, ALIAS
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 58:27: -> ^( ALIAS ID ( innerCommand )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:58:30: ^( ALIAS ID ( innerCommand )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_ALIAS.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:58:41: ( innerCommand )?
                    	    if ( stream_innerCommand.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_innerCommand.NextTree());

                    	    }
                    	    stream_innerCommand.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:59:4: BIND ID ( innerCommand )?
                    {
                    	BIND58=(IToken)Match(input,BIND,FOLLOW_BIND_in_innerStat465);  
                    	stream_BIND.Add(BIND58);

                    	ID59=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat467);  
                    	stream_ID.Add(ID59);

                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:59:12: ( innerCommand )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( (LA11_0 == RCON || LA11_0 == ID) )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:59:12: innerCommand
                    	        {
                    	        	PushFollow(FOLLOW_innerCommand_in_innerStat469);
                    	        	innerCommand60 = innerCommand();
                    	        	state.followingStackPointer--;

                    	        	stream_innerCommand.Add(innerCommand60.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          ID, ID, BIND
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 59:26: -> ^( BIND ID ( ID )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:59:29: ^( BIND ID ( ID )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_BIND.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:59:39: ( ID )?
                    	    if ( stream_ID.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    }
                    	    stream_ID.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:60:4: innerCommand
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_innerCommand_in_innerStat486);
                    	innerCommand61 = innerCommand();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, innerCommand61.Tree);

                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:61:4: INCREMENT ID ID ID ID
                    {
                    	INCREMENT62=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_innerStat491);  
                    	stream_INCREMENT.Add(INCREMENT62);

                    	ID63=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat493);  
                    	stream_ID.Add(ID63);

                    	ID64=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat495);  
                    	stream_ID.Add(ID64);

                    	ID65=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat497);  
                    	stream_ID.Add(ID65);

                    	ID66=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat499);  
                    	stream_ID.Add(ID66);



                    	// AST REWRITE
                    	// elements:          INCREMENT, ID, ID, ID, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 61:26: -> ^( INCREMENT ID ID ID ID )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:61:29: ^( INCREMENT ID ID ID ID )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_INCREMENT.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 5 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:62:4: ( RCON )? EXEC ID
                    {
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:62:4: ( RCON )?
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == RCON) )
                    	{
                    	    alt12 = 1;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:62:4: RCON
                    	        {
                    	        	RCON67=(IToken)Match(input,RCON,FOLLOW_RCON_in_innerStat518);  
                    	        	stream_RCON.Add(RCON67);


                    	        }
                    	        break;

                    	}

                    	EXEC68=(IToken)Match(input,EXEC,FOLLOW_EXEC_in_innerStat521);  
                    	stream_EXEC.Add(EXEC68);

                    	ID69=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat523);  
                    	stream_ID.Add(ID69);



                    	// AST REWRITE
                    	// elements:          EXEC, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 62:18: -> ^( EXEC ID )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:62:21: ^( EXEC ID )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_EXEC.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 6 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:63:4: ECHO ( ID )*
                    {
                    	ECHO70=(IToken)Match(input,ECHO,FOLLOW_ECHO_in_innerStat536);  
                    	stream_ECHO.Add(ECHO70);

                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:63:9: ( ID )*
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == ID) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:63:9: ID
                    			    {
                    			    	ID71=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat538);  
                    			    	stream_ID.Add(ID71);


                    			    }
                    			    break;

                    			default:
                    			    goto loop13;
                    	    }
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements



                    	// AST REWRITE
                    	// elements:          ECHO
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 63:13: -> ECHO
                    	{
                    	    adaptor.AddChild(root_0, stream_ECHO.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 7 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:64:4: SAY ( ID )*
                    {
                    	SAY72=(IToken)Match(input,SAY,FOLLOW_SAY_in_innerStat548);  
                    	stream_SAY.Add(SAY72);

                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:64:8: ( ID )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( (LA14_0 == ID) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:64:8: ID
                    			    {
                    			    	ID73=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat550);  
                    			    	stream_ID.Add(ID73);


                    			    }
                    			    break;

                    			default:
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements



                    	// AST REWRITE
                    	// elements:          SAY
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 64:12: -> SAY
                    	{
                    	    adaptor.AddChild(root_0, stream_SAY.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "innerStat"

    public class id_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "id"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:67:1: id : ( ID | '\"' ID '\"' -> ID );
    public SourceExprParser.id_return id() // throws RecognitionException [1]
    {   
        SourceExprParser.id_return retval = new SourceExprParser.id_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ID74 = null;
        IToken char_literal75 = null;
        IToken ID76 = null;
        IToken char_literal77 = null;

        CommonTree ID74_tree=null;
        CommonTree char_literal75_tree=null;
        CommonTree ID76_tree=null;
        CommonTree char_literal77_tree=null;
        RewriteRuleTokenStream stream_21 = new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:67:4: ( ID | '\"' ID '\"' -> ID )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == ID) )
            {
                alt16 = 1;
            }
            else if ( (LA16_0 == 21) )
            {
                alt16 = 2;
            }
            else 
            {
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:67:6: ID
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ID74=(IToken)Match(input,ID,FOLLOW_ID_in_id566); 
                    		ID74_tree = (CommonTree)adaptor.Create(ID74);
                    		adaptor.AddChild(root_0, ID74_tree);


                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:68:4: '\"' ID '\"'
                    {
                    	char_literal75=(IToken)Match(input,21,FOLLOW_21_in_id571);  
                    	stream_21.Add(char_literal75);

                    	ID76=(IToken)Match(input,ID,FOLLOW_ID_in_id573);  
                    	stream_ID.Add(ID76);

                    	char_literal77=(IToken)Match(input,21,FOLLOW_21_in_id575);  
                    	stream_21.Add(char_literal77);



                    	// AST REWRITE
                    	// elements:          ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 69:2: -> ID
                    	{
                    	    adaptor.AddChild(root_0, stream_ID.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "id"

    public class command_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "command"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:71:1: command : ( ( RCON )? ID -> ^( COMMAND ID ( RCON )? ) | ( RCON )? ID id -> ^( COMMAND ID id ( RCON )? ) );
    public SourceExprParser.command_return command() // throws RecognitionException [1]
    {   
        SourceExprParser.command_return retval = new SourceExprParser.command_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken RCON78 = null;
        IToken ID79 = null;
        IToken RCON80 = null;
        IToken ID81 = null;
        SourceExprParser.id_return id82 = default(SourceExprParser.id_return);


        CommonTree RCON78_tree=null;
        CommonTree ID79_tree=null;
        CommonTree RCON80_tree=null;
        CommonTree ID81_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RCON = new RewriteRuleTokenStream(adaptor,"token RCON");
        RewriteRuleSubtreeStream stream_id = new RewriteRuleSubtreeStream(adaptor,"rule id");
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:71:9: ( ( RCON )? ID -> ^( COMMAND ID ( RCON )? ) | ( RCON )? ID id -> ^( COMMAND ID id ( RCON )? ) )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == RCON) )
            {
                int LA19_1 = input.LA(2);

                if ( (LA19_1 == ID) )
                {
                    int LA19_2 = input.LA(3);

                    if ( (LA19_2 == EOF || (LA19_2 >= ALIAS && LA19_2 <= META) || (LA19_2 >= LINEBREAK && LA19_2 <= ID)) )
                    {
                        alt19 = 1;
                    }
                    else if ( (LA19_2 == 21) )
                    {
                        alt19 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d19s2 =
                            new NoViableAltException("", 19, 2, input);

                        throw nvae_d19s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d19s1 =
                        new NoViableAltException("", 19, 1, input);

                    throw nvae_d19s1;
                }
            }
            else if ( (LA19_0 == ID) )
            {
                int LA19_2 = input.LA(2);

                if ( (LA19_2 == EOF || (LA19_2 >= ALIAS && LA19_2 <= META) || (LA19_2 >= LINEBREAK && LA19_2 <= ID)) )
                {
                    alt19 = 1;
                }
                else if ( (LA19_2 == 21) )
                {
                    alt19 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d19s2 =
                        new NoViableAltException("", 19, 2, input);

                    throw nvae_d19s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:71:11: ( RCON )? ID
                    {
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:71:11: ( RCON )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( (LA17_0 == RCON) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:71:11: RCON
                    	        {
                    	        	RCON78=(IToken)Match(input,RCON,FOLLOW_RCON_in_command589);  
                    	        	stream_RCON.Add(RCON78);


                    	        }
                    	        break;

                    	}

                    	ID79=(IToken)Match(input,ID,FOLLOW_ID_in_command592);  
                    	stream_ID.Add(ID79);



                    	// AST REWRITE
                    	// elements:          ID, RCON
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 71:20: -> ^( COMMAND ID ( RCON )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:71:23: ^( COMMAND ID ( RCON )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMMAND, "COMMAND"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:71:36: ( RCON )?
                    	    if ( stream_RCON.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_RCON.NextNode());

                    	    }
                    	    stream_RCON.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:72:4: ( RCON )? ID id
                    {
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:72:4: ( RCON )?
                    	int alt18 = 2;
                    	int LA18_0 = input.LA(1);

                    	if ( (LA18_0 == RCON) )
                    	{
                    	    alt18 = 1;
                    	}
                    	switch (alt18) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:72:4: RCON
                    	        {
                    	        	RCON80=(IToken)Match(input,RCON,FOLLOW_RCON_in_command609);  
                    	        	stream_RCON.Add(RCON80);


                    	        }
                    	        break;

                    	}

                    	ID81=(IToken)Match(input,ID,FOLLOW_ID_in_command612);  
                    	stream_ID.Add(ID81);

                    	PushFollow(FOLLOW_id_in_command614);
                    	id82 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id82.Tree);


                    	// AST REWRITE
                    	// elements:          ID, id, RCON
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 72:16: -> ^( COMMAND ID id ( RCON )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:72:19: ^( COMMAND ID id ( RCON )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMMAND, "COMMAND"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_id.NextTree());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:72:35: ( RCON )?
                    	    if ( stream_RCON.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_RCON.NextNode());

                    	    }
                    	    stream_RCON.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "command"

    public class innerCommand_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "innerCommand"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:74:1: innerCommand : ( ( RCON )? ID -> ^( COMMAND ID ( RCON )? ) | ( RCON )? ID ID -> ^( COMMAND ID ID ( RCON )? ) );
    public SourceExprParser.innerCommand_return innerCommand() // throws RecognitionException [1]
    {   
        SourceExprParser.innerCommand_return retval = new SourceExprParser.innerCommand_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken RCON83 = null;
        IToken ID84 = null;
        IToken RCON85 = null;
        IToken ID86 = null;
        IToken ID87 = null;

        CommonTree RCON83_tree=null;
        CommonTree ID84_tree=null;
        CommonTree RCON85_tree=null;
        CommonTree ID86_tree=null;
        CommonTree ID87_tree=null;
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");
        RewriteRuleTokenStream stream_RCON = new RewriteRuleTokenStream(adaptor,"token RCON");

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:75:2: ( ( RCON )? ID -> ^( COMMAND ID ( RCON )? ) | ( RCON )? ID ID -> ^( COMMAND ID ID ( RCON )? ) )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == RCON) )
            {
                int LA22_1 = input.LA(2);

                if ( (LA22_1 == ID) )
                {
                    int LA22_2 = input.LA(3);

                    if ( (LA22_2 == ID) )
                    {
                        alt22 = 2;
                    }
                    else if ( (LA22_2 == LINEBREAK || LA22_2 == 21) )
                    {
                        alt22 = 1;
                    }
                    else 
                    {
                        NoViableAltException nvae_d22s2 =
                            new NoViableAltException("", 22, 2, input);

                        throw nvae_d22s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d22s1 =
                        new NoViableAltException("", 22, 1, input);

                    throw nvae_d22s1;
                }
            }
            else if ( (LA22_0 == ID) )
            {
                int LA22_2 = input.LA(2);

                if ( (LA22_2 == ID) )
                {
                    alt22 = 2;
                }
                else if ( (LA22_2 == LINEBREAK || LA22_2 == 21) )
                {
                    alt22 = 1;
                }
                else 
                {
                    NoViableAltException nvae_d22s2 =
                        new NoViableAltException("", 22, 2, input);

                    throw nvae_d22s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:75:4: ( RCON )? ID
                    {
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:75:4: ( RCON )?
                    	int alt20 = 2;
                    	int LA20_0 = input.LA(1);

                    	if ( (LA20_0 == RCON) )
                    	{
                    	    alt20 = 1;
                    	}
                    	switch (alt20) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:75:4: RCON
                    	        {
                    	        	RCON83=(IToken)Match(input,RCON,FOLLOW_RCON_in_innerCommand639);  
                    	        	stream_RCON.Add(RCON83);


                    	        }
                    	        break;

                    	}

                    	ID84=(IToken)Match(input,ID,FOLLOW_ID_in_innerCommand642);  
                    	stream_ID.Add(ID84);



                    	// AST REWRITE
                    	// elements:          RCON, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 75:13: -> ^( COMMAND ID ( RCON )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:75:16: ^( COMMAND ID ( RCON )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMMAND, "COMMAND"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:75:29: ( RCON )?
                    	    if ( stream_RCON.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_RCON.NextNode());

                    	    }
                    	    stream_RCON.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:76:4: ( RCON )? ID ID
                    {
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:76:4: ( RCON )?
                    	int alt21 = 2;
                    	int LA21_0 = input.LA(1);

                    	if ( (LA21_0 == RCON) )
                    	{
                    	    alt21 = 1;
                    	}
                    	switch (alt21) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:76:4: RCON
                    	        {
                    	        	RCON85=(IToken)Match(input,RCON,FOLLOW_RCON_in_innerCommand659);  
                    	        	stream_RCON.Add(RCON85);


                    	        }
                    	        break;

                    	}

                    	ID86=(IToken)Match(input,ID,FOLLOW_ID_in_innerCommand662);  
                    	stream_ID.Add(ID86);

                    	ID87=(IToken)Match(input,ID,FOLLOW_ID_in_innerCommand664);  
                    	stream_ID.Add(ID87);



                    	// AST REWRITE
                    	// elements:          ID, RCON, ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 76:16: -> ^( COMMAND ID ID ( RCON )? )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:76:19: ^( COMMAND ID ID ( RCON )? )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(COMMAND, "COMMAND"), root_1);

                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    adaptor.AddChild(root_1, stream_ID.NextNode());
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:76:35: ( RCON )?
                    	    if ( stream_RCON.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_RCON.NextNode());

                    	    }
                    	    stream_RCON.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "innerCommand"

    protected class guiRule_scope 
    {
        protected internal string metaType;
    }
    protected Stack guiRule_stack = new Stack();

    public class guiRule_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "guiRule"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:78:1: guiRule : META firstGuiField metaEnding -> ^( META firstGuiField metaEnding ) ;
    public SourceExprParser.guiRule_return guiRule() // throws RecognitionException [1]
    {   
        guiRule_stack.Push(new guiRule_scope());
        SourceExprParser.guiRule_return retval = new SourceExprParser.guiRule_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken META88 = null;
        SourceExprParser.firstGuiField_return firstGuiField89 = default(SourceExprParser.firstGuiField_return);

        SourceExprParser.metaEnding_return metaEnding90 = default(SourceExprParser.metaEnding_return);


        CommonTree META88_tree=null;
        RewriteRuleTokenStream stream_META = new RewriteRuleTokenStream(adaptor,"token META");
        RewriteRuleSubtreeStream stream_metaEnding = new RewriteRuleSubtreeStream(adaptor,"rule metaEnding");
        RewriteRuleSubtreeStream stream_firstGuiField = new RewriteRuleSubtreeStream(adaptor,"rule firstGuiField");
         ((guiRule_scope)guiRule_stack.Peek()).metaType =  String.Empty; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:81:2: ( META firstGuiField metaEnding -> ^( META firstGuiField metaEnding ) )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:81:4: META firstGuiField metaEnding
            {
            	META88=(IToken)Match(input,META,FOLLOW_META_in_guiRule697);  
            	stream_META.Add(META88);

            	PushFollow(FOLLOW_firstGuiField_in_guiRule699);
            	firstGuiField89 = firstGuiField();
            	state.followingStackPointer--;

            	stream_firstGuiField.Add(firstGuiField89.Tree);
            	PushFollow(FOLLOW_metaEnding_in_guiRule701);
            	metaEnding90 = metaEnding();
            	state.followingStackPointer--;

            	stream_metaEnding.Add(metaEnding90.Tree);


            	// AST REWRITE
            	// elements:          metaEnding, firstGuiField, META
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 82:3: -> ^( META firstGuiField metaEnding )
            	{
            	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:82:7: ^( META firstGuiField metaEnding )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_META.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_firstGuiField.NextTree());
            	    adaptor.AddChild(root_1, stream_metaEnding.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            guiRule_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "guiRule"

    public class firstGuiField_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "firstGuiField"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:85:1: firstGuiField : '\"' id1= ID '\"' {...}? -> ID ;
    public SourceExprParser.firstGuiField_return firstGuiField() // throws RecognitionException [1]
    {   
        SourceExprParser.firstGuiField_return retval = new SourceExprParser.firstGuiField_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken id1 = null;
        IToken char_literal91 = null;
        IToken char_literal92 = null;

        CommonTree id1_tree=null;
        CommonTree char_literal91_tree=null;
        CommonTree char_literal92_tree=null;
        RewriteRuleTokenStream stream_21 = new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:86:2: ( '\"' id1= ID '\"' {...}? -> ID )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:86:4: '\"' id1= ID '\"' {...}?
            {
            	char_literal91=(IToken)Match(input,21,FOLLOW_21_in_firstGuiField725);  
            	stream_21.Add(char_literal91);

            	id1=(IToken)Match(input,ID,FOLLOW_ID_in_firstGuiField729);  
            	stream_ID.Add(id1);

            	char_literal92=(IToken)Match(input,21,FOLLOW_21_in_firstGuiField731);  
            	stream_21.Add(char_literal92);

            	 ((guiRule_scope)guiRule_stack.Peek()).metaType = ((id1 != null) ? id1.Text : null); Debug.WriteLine("Reached end of firstGuiField");
            	if ( !((_script.SupportedMetaData[((id1 != null) ? id1.Text : null)].IsAValidField(0, ((id1 != null) ? id1.Text : null), true) )) ) 
            	{
            	    throw new FailedPredicateException(input, "firstGuiField", "_script.SupportedMetaData[$id1.text].IsAValidField(0, $id1.text, true) ");
            	}


            	// AST REWRITE
            	// elements:          ID
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 88:5: -> ID
            	{
            	    adaptor.AddChild(root_0, stream_ID.NextNode());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "firstGuiField"

    public class metaEnding_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "metaEnding"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:91:1: metaEnding : ({...}? => guiFields | {...}? => guiFields ( LINEBREAK )* stat );
    public SourceExprParser.metaEnding_return metaEnding() // throws RecognitionException [1]
    {   
        SourceExprParser.metaEnding_return retval = new SourceExprParser.metaEnding_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LINEBREAK95 = null;
        SourceExprParser.guiFields_return guiFields93 = default(SourceExprParser.guiFields_return);

        SourceExprParser.guiFields_return guiFields94 = default(SourceExprParser.guiFields_return);

        SourceExprParser.stat_return stat96 = default(SourceExprParser.stat_return);


        CommonTree LINEBREAK95_tree=null;

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:92:2: ({...}? => guiFields | {...}? => guiFields ( LINEBREAK )* stat )
            int alt24 = 2;
            alt24 = dfa24.Predict(input);
            switch (alt24) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:92:4: {...}? => guiFields
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	if ( !(((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) 
                    	{
                    	    throw new FailedPredicateException(input, "metaEnding", "(_script.SupportedMetaData[$guiRule::metaType].IsIndependent == true)");
                    	}
                    	Debug.WriteLine("meta ending reached, independent");
                    	PushFollow(FOLLOW_guiFields_in_metaEnding760);
                    	guiFields93 = guiFields();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, guiFields93.Tree);

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:93:4: {...}? => guiFields ( LINEBREAK )* stat
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	if ( !(((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) 
                    	{
                    	    throw new FailedPredicateException(input, "metaEnding", "(_script.SupportedMetaData[$guiRule::metaType].IsIndependent == false)");
                    	}
                    	Debug.WriteLine("meta ending reached, dependent");
                    	PushFollow(FOLLOW_guiFields_in_metaEnding768);
                    	guiFields94 = guiFields();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, guiFields94.Tree);
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:93:141: ( LINEBREAK )*
                    	do 
                    	{
                    	    int alt23 = 2;
                    	    int LA23_0 = input.LA(1);

                    	    if ( (LA23_0 == LINEBREAK) )
                    	    {
                    	        alt23 = 1;
                    	    }


                    	    switch (alt23) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:93:141: LINEBREAK
                    			    {
                    			    	LINEBREAK95=(IToken)Match(input,LINEBREAK,FOLLOW_LINEBREAK_in_metaEnding770); 
                    			    		LINEBREAK95_tree = (CommonTree)adaptor.Create(LINEBREAK95);
                    			    		adaptor.AddChild(root_0, LINEBREAK95_tree);


                    			    }
                    			    break;

                    			default:
                    			    goto loop23;
                    	    }
                    	} while (true);

                    	loop23:
                    		;	// Stops C# compiler whining that label 'loop23' has no statements

                    	PushFollow(FOLLOW_stat_in_metaEnding773);
                    	stat96 = stat();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, stat96.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "metaEnding"

    protected class guiFields_scope 
    {
        protected internal int n;
    }
    protected Stack guiFields_stack = new Stack();

    public class guiFields_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "guiFields"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:96:1: guiFields : ( guiField )+ ;
    public SourceExprParser.guiFields_return guiFields() // throws RecognitionException [1]
    {   
        guiFields_stack.Push(new guiFields_scope());
        SourceExprParser.guiFields_return retval = new SourceExprParser.guiFields_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SourceExprParser.guiField_return guiField97 = default(SourceExprParser.guiField_return);



         ((guiFields_scope)guiFields_stack.Peek()).n =  1; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:101:2: ( ( guiField )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:101:4: ( guiField )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:101:4: ( guiField )+
            	int cnt25 = 0;
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == 21) && ((((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].NumberOfMetaFields)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:101:5: guiField
            			    {
            			    	PushFollow(FOLLOW_guiField_in_guiFields798);
            			    	guiField97 = guiField();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, guiField97.Tree);
            			    	((guiFields_scope)guiFields_stack.Peek()).n++;

            			    }
            			    break;

            			default:
            			    if ( cnt25 >= 1 ) goto loop25;
            		            EarlyExitException eee25 =
            		                new EarlyExitException(25, input);
            		            throw eee25;
            	    }
            	    cnt25++;
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
            guiFields_stack.Pop();
        }
        return retval;
    }
    // $ANTLR end "guiFields"

    public class guiField_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "guiField"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:103:1: guiField : {...}? => '\"' metaElement '\"' -> metaElement ;
    public SourceExprParser.guiField_return guiField() // throws RecognitionException [1]
    {   
        SourceExprParser.guiField_return retval = new SourceExprParser.guiField_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal98 = null;
        IToken char_literal100 = null;
        SourceExprParser.metaElement_return metaElement99 = default(SourceExprParser.metaElement_return);


        CommonTree char_literal98_tree=null;
        CommonTree char_literal100_tree=null;
        RewriteRuleTokenStream stream_21 = new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleSubtreeStream stream_metaElement = new RewriteRuleSubtreeStream(adaptor,"rule metaElement");
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:103:9: ({...}? => '\"' metaElement '\"' -> metaElement )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:103:11: {...}? => '\"' metaElement '\"'
            {
            	if ( !((((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].NumberOfMetaFields)) ) 
            	{
            	    throw new FailedPredicateException(input, "guiField", "$guiFields::n < _script.SupportedMetaData[$guiRule::metaType].NumberOfMetaFields");
            	}
            	char_literal98=(IToken)Match(input,21,FOLLOW_21_in_guiField812);  
            	stream_21.Add(char_literal98);

            	PushFollow(FOLLOW_metaElement_in_guiField814);
            	metaElement99 = metaElement();
            	state.followingStackPointer--;

            	stream_metaElement.Add(metaElement99.Tree);
            	char_literal100=(IToken)Match(input,21,FOLLOW_21_in_guiField816);  
            	stream_21.Add(char_literal100);



            	// AST REWRITE
            	// elements:          metaElement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 104:3: -> metaElement
            	{
            	    adaptor.AddChild(root_0, stream_metaElement.NextTree());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "guiField"

    public class metaElement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "metaElement"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:106:1: metaElement : ({...}? => INT -> ^( METAINT INT ) | {...}? => ( ID )+ -> ^( METATEXT ( ID )+ ) );
    public SourceExprParser.metaElement_return metaElement() // throws RecognitionException [1]
    {   
        SourceExprParser.metaElement_return retval = new SourceExprParser.metaElement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken INT101 = null;
        IToken ID102 = null;

        CommonTree INT101_tree=null;
        CommonTree ID102_tree=null;
        RewriteRuleTokenStream stream_INT = new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:107:2: ({...}? => INT -> ^( METAINT INT ) | {...}? => ( ID )+ -> ^( METATEXT ( ID )+ ) )
            int alt27 = 2;
            int LA27_0 = input.LA(1);

            if ( (LA27_0 == INT) && ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) )
            {
                alt27 = 1;
            }
            else if ( (LA27_0 == ID) && ((!_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) )
            {
                alt27 = 2;
            }
            else 
            {
                NoViableAltException nvae_d27s0 =
                    new NoViableAltException("", 27, 0, input);

                throw nvae_d27s0;
            }
            switch (alt27) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:107:4: {...}? => INT
                    {
                    	if ( !((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) ) 
                    	{
                    	    throw new FailedPredicateException(input, "metaElement", "_script.SupportedMetaData[$guiRule::metaType].FieldIsInt($guiFields::n)");
                    	}
                    	INT101=(IToken)Match(input,INT,FOLLOW_INT_in_metaElement834);  
                    	stream_INT.Add(INT101);



                    	// AST REWRITE
                    	// elements:          INT
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 108:3: -> ^( METAINT INT )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:108:6: ^( METAINT INT )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(METAINT, "METAINT"), root_1);

                    	    adaptor.AddChild(root_1, stream_INT.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:109:4: {...}? => ( ID )+
                    {
                    	if ( !((!_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) ) 
                    	{
                    	    throw new FailedPredicateException(input, "metaElement", "!_script.SupportedMetaData[$guiRule::metaType].FieldIsInt($guiFields::n)");
                    	}
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:109:81: ( ID )+
                    	int cnt26 = 0;
                    	do 
                    	{
                    	    int alt26 = 2;
                    	    int LA26_0 = input.LA(1);

                    	    if ( (LA26_0 == ID) )
                    	    {
                    	        alt26 = 1;
                    	    }


                    	    switch (alt26) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:109:81: ID
                    			    {
                    			    	ID102=(IToken)Match(input,ID,FOLLOW_ID_in_metaElement851);  
                    			    	stream_ID.Add(ID102);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt26 >= 1 ) goto loop26;
                    		            EarlyExitException eee26 =
                    		                new EarlyExitException(26, input);
                    		            throw eee26;
                    	    }
                    	    cnt26++;
                    	} while (true);

                    	loop26:
                    		;	// Stops C# compiler whining that label 'loop26' has no statements



                    	// AST REWRITE
                    	// elements:          ID
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (CommonTree)adaptor.GetNilNode();
                    	// 110:3: -> ^( METATEXT ( ID )+ )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:110:6: ^( METATEXT ( ID )+ )
                    	    {
                    	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
                    	    root_1 = (CommonTree)adaptor.BecomeRoot((CommonTree)adaptor.Create(METATEXT, "METATEXT"), root_1);

                    	    if ( !(stream_ID.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_ID.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_ID.NextNode());

                    	    }
                    	    stream_ID.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "metaElement"

    public class emptyQuotes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "emptyQuotes"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:112:2: emptyQuotes : '\"' '\"' ;
    public SourceExprParser.emptyQuotes_return emptyQuotes() // throws RecognitionException [1]
    {   
        SourceExprParser.emptyQuotes_return retval = new SourceExprParser.emptyQuotes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal103 = null;
        IToken char_literal104 = null;

        CommonTree char_literal103_tree=null;
        CommonTree char_literal104_tree=null;

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:113:3: ( '\"' '\"' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:113:5: '\"' '\"'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal103=(IToken)Match(input,21,FOLLOW_21_in_emptyQuotes875); 
            		char_literal103_tree = (CommonTree)adaptor.Create(char_literal103);
            		adaptor.AddChild(root_0, char_literal103_tree);

            	char_literal104=(IToken)Match(input,21,FOLLOW_21_in_emptyQuotes876); 
            		char_literal104_tree = (CommonTree)adaptor.Create(char_literal104);
            		adaptor.AddChild(root_0, char_literal104_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "emptyQuotes"

    // Delegated rules


   	protected DFA8 dfa8;
   	protected DFA24 dfa24;
	private void InitializeCyclicDFAs()
	{
    	this.dfa8 = new DFA8(this);
    	this.dfa24 = new DFA24(this);
	    this.dfa24.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA24_SpecialStateTransition);
	}

    const string DFA8_eotS =
        "\x21\uffff";
    const string DFA8_eofS =
        "\x09\uffff\x01\x16\x01\uffff\x01\x1b\x12\uffff\x01\x16\x01\uffff"+
        "\x01\x1b";
    const string DFA8_minS =
        "\x01\x04\x02\x10\x01\x06\x01\x10\x02\uffff\x02\x10\x01\x04\x01"+
        "\x10\x01\x04\x01\x10\x06\uffff\x01\x06\x01\uffff\x01\x04\x01\uffff"+
        "\x01\x15\x01\x06\x01\uffff\x01\x04\x01\uffff\x01\x15\x01\uffff\x01"+
        "\x04\x01\uffff\x01\x04";
    const string DFA8_maxS =
        "\x01\x10\x02\x15\x01\x10\x01\x15\x02\uffff\x03\x15\x01\x10\x01"+
        "\x15\x01\x10\x06\uffff\x01\x10\x01\uffff\x01\x15\x01\uffff\x01\x15"+
        "\x01\x10\x01\uffff\x01\x15\x01\uffff\x01\x15\x01\uffff\x01\x15\x01"+
        "\uffff\x01\x15";
    const string DFA8_acceptS =
        "\x05\uffff\x01\x09\x01\x0a\x06\uffff\x01\x07\x01\x08\x01\x0b\x01"+
        "\x0c\x01\x0d\x01\x0e\x01\uffff\x01\x02\x01\uffff\x01\x03\x02\uffff"+
        "\x01\x05\x01\uffff\x01\x06\x01\uffff\x01\x01\x01\uffff\x01\x04\x01"+
        "\uffff";
    const string DFA8_specialS =
        "\x21\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x01\x01\x02\x01\x04\x01\x03\x01\x06\x01\x07\x01\x08\x05"+
            "\uffff\x01\x05",
            "\x01\x09\x04\uffff\x01\x0a",
            "\x01\x0b\x04\uffff\x01\x0c",
            "\x01\x04\x09\uffff\x01\x05",
            "\x01\x0e\x04\uffff\x01\x0d",
            "",
            "",
            "\x01\x10\x04\uffff\x01\x0f",
            "\x01\x12\x04\uffff\x01\x11",
            "\x03\x16\x01\x13\x04\x16\x03\uffff\x01\x16\x01\x14\x04\uffff"+
            "\x01\x15",
            "\x01\x17",
            "\x03\x1b\x01\x18\x04\x1b\x03\uffff\x01\x1b\x01\x19\x04\uffff"+
            "\x01\x1a",
            "\x01\x1c",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x16\x09\uffff\x01\x14",
            "",
            "\x07\x1d\x05\uffff\x01\x1d\x04\uffff\x01\x16",
            "",
            "\x01\x1e",
            "\x01\x1b\x09\uffff\x01\x19",
            "",
            "\x07\x1f\x05\uffff\x01\x1f\x04\uffff\x01\x1b",
            "",
            "\x01\x20",
            "",
            "\x03\x16\x01\x13\x04\x16\x03\uffff\x01\x16\x01\x14\x04\uffff"+
            "\x01\x15",
            "",
            "\x03\x1b\x01\x18\x04\x1b\x03\uffff\x01\x1b\x01\x19\x04\uffff"+
            "\x01\x1a"
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "39:1: stat : ( ALIAS id '\"' multExpr '\"' -> ^( ALIAS id multExpr ) | ALIAS id command -> ^( ALIAS id command ) | ALIAS id ( emptyQuotes )? -> ^( ALIAS id ) | BIND id '\"' multExpr '\"' -> ^( BIND id multExpr ) | BIND id command -> ^( BIND id command ) | BIND id ( emptyQuotes )? -> ^( BIND id ) | ( RCON )? EXEC '\"' ID '\"' -> ^( EXEC ID ( RCON )? ) | ( RCON )? EXEC ID -> ^( EXEC ID ( RCON )? ) | command | INCREMENT id id id id -> ^( INCREMENT id id id id ) | ECHO '\"' ( ID )* '\"' -> ECHO | ECHO ID -> ECHO | SAY '\"' ( ID )* '\"' -> SAY | SAY ID -> SAY );"; }
        }

    }

    const string DFA24_eotS =
        "\x34\uffff";
    const string DFA24_eofS =
        "\x04\uffff\x01\x05\x09\uffff\x01\x05\x25\uffff";
    const string DFA24_minS =
        "\x01\x15\x01\x10\x01\x15\x01\x10\x01\x04\x01\uffff\x02\x10\x01"+
        "\x06\x01\x10\x01\x00\x03\x10\x01\x04\x01\x00\x01\x10\x01\x00\x02"+
        "\x10\x01\x00\x01\uffff\x03\x10\x01\x00\x01\x10\x01\x00\x03\x15\x02"+
        "\x10\x01\x15\x01\x10\x01\x00\x01\x10\x04\x00\x02\x10\x01\x15\x01"+
        "\x10\x01\x00\x01\x10\x01\x15\x01\x10\x01\x15\x01\x10\x01\x00";
    const string DFA24_maxS =
        "\x01\x15\x01\x11\x03\x15\x01\uffff\x02\x15\x01\x10\x01\x15\x01"+
        "\x00\x03\x15\x01\x10\x01\x00\x01\x10\x01\x00\x02\x10\x01\x00\x01"+
        "\uffff\x01\x15\x01\x10\x01\x15\x01\x00\x01\x15\x01\x00\x04\x15\x01"+
        "\x10\x02\x15\x01\x00\x01\x15\x04\x00\x01\x15\x01\x10\x02\x15\x01"+
        "\x00\x01\x10\x04\x15\x01\x00";
    const string DFA24_acceptS =
        "\x05\uffff\x01\x01\x0f\uffff\x01\x02\x1e\uffff";
    const string DFA24_specialS =
        "\x01\x0c\x01\x02\x01\x06\x01\x07\x01\x2c\x01\uffff\x01\x00\x01"+
        "\x22\x01\x15\x01\x24\x01\x2a\x01\x05\x01\x2e\x01\x14\x01\x23\x01"+
        "\x0e\x01\x18\x01\x09\x01\x17\x01\x28\x01\x26\x01\uffff\x01\x0d\x01"+
        "\x1e\x01\x2d\x01\x04\x01\x16\x01\x30\x01\x11\x01\x12\x01\x27\x01"+
        "\x13\x01\x1f\x01\x1b\x01\x29\x01\x08\x01\x2b\x01\x01\x01\x25\x01"+
        "\x03\x01\x2f\x01\x0f\x01\x20\x01\x1c\x01\x10\x01\x0a\x01\x21\x01"+
        "\x1d\x01\x19\x01\x1a\x01\x31\x01\x0b}>";
    static readonly string[] DFA24_transitionS = {
            "\x01\x01",
            "\x01\x03\x01\x02",
            "\x01\x04",
            "\x01\x03\x04\uffff\x01\x04",
            "\x01\x06\x01\x07\x01\x09\x01\x08\x01\x0b\x01\x0c\x01\x0d\x01"+
            "\x05\x03\uffff\x01\x0e\x01\x0a\x04\uffff\x01\x01",
            "",
            "\x01\x0f\x04\uffff\x01\x10",
            "\x01\x11\x04\uffff\x01\x12",
            "\x01\x09\x09\uffff\x01\x0a",
            "\x01\x14\x04\uffff\x01\x13",
            "\x01\uffff",
            "\x01\x16\x04\uffff\x01\x17",
            "\x01\x19\x04\uffff\x01\x18",
            "\x01\x1b\x04\uffff\x01\x1a",
            "\x01\x06\x01\x07\x01\x09\x01\x08\x01\x0b\x01\x0c\x01\x0d\x01"+
            "\x05\x03\uffff\x01\x0e\x01\x0a",
            "\x01\uffff",
            "\x01\x1c",
            "\x01\uffff",
            "\x01\x1d",
            "\x01\x1e",
            "\x01\uffff",
            "",
            "\x01\x1f\x04\uffff\x01\x20",
            "\x01\x21",
            "\x01\x22\x04\uffff\x01\x23",
            "\x01\uffff",
            "\x01\x24\x04\uffff\x01\x25",
            "\x01\uffff",
            "\x01\x26",
            "\x01\x27",
            "\x01\x28",
            "\x01\x29\x04\uffff\x01\x2a",
            "\x01\x2b",
            "\x01\x2c",
            "\x01\x22\x04\uffff\x01\x23",
            "\x01\uffff",
            "\x01\x24\x04\uffff\x01\x25",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\uffff",
            "\x01\x2d\x04\uffff\x01\x2e",
            "\x01\x2f",
            "\x01\x30",
            "\x01\x1f\x04\uffff\x01\x20",
            "\x01\uffff",
            "\x01\x31",
            "\x01\x32",
            "\x01\x29\x04\uffff\x01\x2a",
            "\x01\x33",
            "\x01\x2d\x04\uffff\x01\x2e",
            "\x01\uffff"
    };

    static readonly short[] DFA24_eot = DFA.UnpackEncodedString(DFA24_eotS);
    static readonly short[] DFA24_eof = DFA.UnpackEncodedString(DFA24_eofS);
    static readonly char[] DFA24_min = DFA.UnpackEncodedStringToUnsignedChars(DFA24_minS);
    static readonly char[] DFA24_max = DFA.UnpackEncodedStringToUnsignedChars(DFA24_maxS);
    static readonly short[] DFA24_accept = DFA.UnpackEncodedString(DFA24_acceptS);
    static readonly short[] DFA24_special = DFA.UnpackEncodedString(DFA24_specialS);
    static readonly short[][] DFA24_transition = DFA.UnpackEncodedStringArray(DFA24_transitionS);

    protected class DFA24 : DFA
    {
        public DFA24(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 24;
            this.eot = DFA24_eot;
            this.eof = DFA24_eof;
            this.min = DFA24_min;
            this.max = DFA24_max;
            this.accept = DFA24_accept;
            this.special = DFA24_special;
            this.transition = DFA24_transition;

        }

        override public string Description
        {
            get { return "91:1: metaEnding : ({...}? => guiFields | {...}? => guiFields ( LINEBREAK )* stat );"; }
        }

    }


    protected internal int DFA24_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA24_6 = input.LA(1);

                   	 
                   	int index24_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_6 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 15; }

                   	else if ( (LA24_6 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 16; }

                   	 
                   	input.Seek(index24_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA24_37 = input.LA(1);

                   	 
                   	int index24_37 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_37);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA24_1 = input.LA(1);

                   	 
                   	int index24_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_1 == INT) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 2; }

                   	else if ( (LA24_1 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 3; }

                   	 
                   	input.Seek(index24_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA24_39 = input.LA(1);

                   	 
                   	int index24_39 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_39);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA24_25 = input.LA(1);

                   	 
                   	int index24_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA24_11 = input.LA(1);

                   	 
                   	int index24_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_11 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 22; }

                   	else if ( (LA24_11 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 23; }

                   	 
                   	input.Seek(index24_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA24_2 = input.LA(1);

                   	 
                   	int index24_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_2 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 4; }

                   	 
                   	input.Seek(index24_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA24_3 = input.LA(1);

                   	 
                   	int index24_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_3 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 4; }

                   	else if ( (LA24_3 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 3; }

                   	 
                   	input.Seek(index24_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA24_35 = input.LA(1);

                   	 
                   	int index24_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_35);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA24_17 = input.LA(1);

                   	 
                   	int index24_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_17);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA24_45 = input.LA(1);

                   	 
                   	int index24_45 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_45);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA24_51 = input.LA(1);

                   	 
                   	int index24_51 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_51);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA24_0 = input.LA(1);

                   	 
                   	int index24_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_0 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 1; }

                   	 
                   	input.Seek(index24_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA24_22 = input.LA(1);

                   	 
                   	int index24_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_22 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 31; }

                   	else if ( (LA24_22 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 32; }

                   	 
                   	input.Seek(index24_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA24_15 = input.LA(1);

                   	 
                   	int index24_15 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_15);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA24_41 = input.LA(1);

                   	 
                   	int index24_41 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_41 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 45; }

                   	else if ( (LA24_41 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 46; }

                   	 
                   	input.Seek(index24_41);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 16 : 
                   	int LA24_44 = input.LA(1);

                   	 
                   	int index24_44 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_44 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 31; }

                   	else if ( (LA24_44 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 32; }

                   	 
                   	input.Seek(index24_44);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 17 : 
                   	int LA24_28 = input.LA(1);

                   	 
                   	int index24_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_28 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 38; }

                   	 
                   	input.Seek(index24_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 18 : 
                   	int LA24_29 = input.LA(1);

                   	 
                   	int index24_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_29 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 39; }

                   	 
                   	input.Seek(index24_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 19 : 
                   	int LA24_31 = input.LA(1);

                   	 
                   	int index24_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_31 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 41; }

                   	else if ( (LA24_31 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 42; }

                   	 
                   	input.Seek(index24_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 20 : 
                   	int LA24_13 = input.LA(1);

                   	 
                   	int index24_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_13 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 26; }

                   	else if ( (LA24_13 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 27; }

                   	 
                   	input.Seek(index24_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 21 : 
                   	int LA24_8 = input.LA(1);

                   	 
                   	int index24_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_8 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 10; }

                   	else if ( (LA24_8 == EXEC) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 9; }

                   	 
                   	input.Seek(index24_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 22 : 
                   	int LA24_26 = input.LA(1);

                   	 
                   	int index24_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_26 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 36; }

                   	else if ( (LA24_26 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 37; }

                   	 
                   	input.Seek(index24_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 23 : 
                   	int LA24_18 = input.LA(1);

                   	 
                   	int index24_18 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_18 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 29; }

                   	 
                   	input.Seek(index24_18);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 24 : 
                   	int LA24_16 = input.LA(1);

                   	 
                   	int index24_16 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_16 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 28; }

                   	 
                   	input.Seek(index24_16);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 25 : 
                   	int LA24_48 = input.LA(1);

                   	 
                   	int index24_48 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_48 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 41; }

                   	else if ( (LA24_48 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 42; }

                   	 
                   	input.Seek(index24_48);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 26 : 
                   	int LA24_49 = input.LA(1);

                   	 
                   	int index24_49 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_49 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 51; }

                   	 
                   	input.Seek(index24_49);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 27 : 
                   	int LA24_33 = input.LA(1);

                   	 
                   	int index24_33 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_33 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 44; }

                   	 
                   	input.Seek(index24_33);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 28 : 
                   	int LA24_43 = input.LA(1);

                   	 
                   	int index24_43 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_43 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 48; }

                   	 
                   	input.Seek(index24_43);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 29 : 
                   	int LA24_47 = input.LA(1);

                   	 
                   	int index24_47 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_47 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 50; }

                   	 
                   	input.Seek(index24_47);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 30 : 
                   	int LA24_23 = input.LA(1);

                   	 
                   	int index24_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_23 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 33; }

                   	 
                   	input.Seek(index24_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 31 : 
                   	int LA24_32 = input.LA(1);

                   	 
                   	int index24_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_32 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 43; }

                   	 
                   	input.Seek(index24_32);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 32 : 
                   	int LA24_42 = input.LA(1);

                   	 
                   	int index24_42 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_42 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 47; }

                   	 
                   	input.Seek(index24_42);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 33 : 
                   	int LA24_46 = input.LA(1);

                   	 
                   	int index24_46 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_46 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 49; }

                   	 
                   	input.Seek(index24_46);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 34 : 
                   	int LA24_7 = input.LA(1);

                   	 
                   	int index24_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_7 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 17; }

                   	else if ( (LA24_7 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 18; }

                   	 
                   	input.Seek(index24_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 35 : 
                   	int LA24_14 = input.LA(1);

                   	 
                   	int index24_14 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_14 == EOF || LA24_14 == META) && (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (LA24_14 == ALIAS) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 6; }

                   	else if ( (LA24_14 == BIND) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 7; }

                   	else if ( (LA24_14 == RCON) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 8; }

                   	else if ( (LA24_14 == EXEC) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 9; }

                   	else if ( (LA24_14 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 10; }

                   	else if ( (LA24_14 == INCREMENT) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 11; }

                   	else if ( (LA24_14 == ECHO) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 12; }

                   	else if ( (LA24_14 == SAY) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 13; }

                   	else if ( (LA24_14 == LINEBREAK) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 14; }

                   	 
                   	input.Seek(index24_14);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 36 : 
                   	int LA24_9 = input.LA(1);

                   	 
                   	int index24_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_9 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 19; }

                   	else if ( (LA24_9 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 20; }

                   	 
                   	input.Seek(index24_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 37 : 
                   	int LA24_38 = input.LA(1);

                   	 
                   	int index24_38 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_38);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 38 : 
                   	int LA24_20 = input.LA(1);

                   	 
                   	int index24_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 39 : 
                   	int LA24_30 = input.LA(1);

                   	 
                   	int index24_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_30 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 40; }

                   	 
                   	input.Seek(index24_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 40 : 
                   	int LA24_19 = input.LA(1);

                   	 
                   	int index24_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_19 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 30; }

                   	 
                   	input.Seek(index24_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 41 : 
                   	int LA24_34 = input.LA(1);

                   	 
                   	int index24_34 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_34 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 35; }

                   	else if ( (LA24_34 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 34; }

                   	 
                   	input.Seek(index24_34);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 42 : 
                   	int LA24_10 = input.LA(1);

                   	 
                   	int index24_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 43 : 
                   	int LA24_36 = input.LA(1);

                   	 
                   	int index24_36 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_36 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 37; }

                   	else if ( (LA24_36 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 36; }

                   	 
                   	input.Seek(index24_36);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 44 : 
                   	int LA24_4 = input.LA(1);

                   	 
                   	int index24_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_4 == EOF || LA24_4 == META) && (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (LA24_4 == ALIAS) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 6; }

                   	else if ( (LA24_4 == BIND) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 7; }

                   	else if ( (LA24_4 == RCON) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 8; }

                   	else if ( (LA24_4 == EXEC) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 9; }

                   	else if ( (LA24_4 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 10; }

                   	else if ( (LA24_4 == INCREMENT) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 11; }

                   	else if ( (LA24_4 == ECHO) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 12; }

                   	else if ( (LA24_4 == SAY) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 13; }

                   	else if ( (LA24_4 == LINEBREAK) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 14; }

                   	else if ( (LA24_4 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 1; }

                   	 
                   	input.Seek(index24_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 45 : 
                   	int LA24_24 = input.LA(1);

                   	 
                   	int index24_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_24 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 34; }

                   	else if ( (LA24_24 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 35; }

                   	 
                   	input.Seek(index24_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 46 : 
                   	int LA24_12 = input.LA(1);

                   	 
                   	int index24_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_12 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 24; }

                   	else if ( (LA24_12 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 25; }

                   	 
                   	input.Seek(index24_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 47 : 
                   	int LA24_40 = input.LA(1);

                   	 
                   	int index24_40 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_40);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 48 : 
                   	int LA24_27 = input.LA(1);

                   	 
                   	int index24_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true))) ) { s = 5; }

                   	else if ( (((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))) ) { s = 21; }

                   	 
                   	input.Seek(index24_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 49 : 
                   	int LA24_50 = input.LA(1);

                   	 
                   	int index24_50 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA24_50 == ID) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 45; }

                   	else if ( (LA24_50 == 21) && ((((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == false))|| ((_script.SupportedMetaData[((guiRule_scope)guiRule_stack.Peek()).metaType].IsIndependent == true)))) ) { s = 46; }

                   	 
                   	input.Seek(index24_50);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae24 =
            new NoViableAltException(dfa.Description, 24, _s, input);
        dfa.Error(nvae24);
        throw nvae24;
    }
 

    public static readonly BitSet FOLLOW_guiRule_in_prog140 = new BitSet(new ulong[]{0x0000000000018FF2UL});
    public static readonly BitSet FOLLOW_stat_in_prog146 = new BitSet(new ulong[]{0x0000000000018FF2UL});
    public static readonly BitSet FOLLOW_LINEBREAK_in_prog152 = new BitSet(new ulong[]{0x0000000000018FF2UL});
    public static readonly BitSet FOLLOW_ALIAS_in_stat168 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat170 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat172 = new BitSet(new ulong[]{0x00000000000107F0UL});
    public static readonly BitSet FOLLOW_multExpr_in_stat174 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat176 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_stat191 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat193 = new BitSet(new ulong[]{0x0000000000010080UL});
    public static readonly BitSet FOLLOW_command_in_stat195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_stat210 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat212 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_emptyQuotes_in_stat214 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_stat228 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat230 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat232 = new BitSet(new ulong[]{0x00000000000107F0UL});
    public static readonly BitSet FOLLOW_multExpr_in_stat234 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat236 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_stat252 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat254 = new BitSet(new ulong[]{0x0000000000010080UL});
    public static readonly BitSet FOLLOW_command_in_stat256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_stat271 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat273 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_emptyQuotes_in_stat275 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_stat289 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_EXEC_in_stat292 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat294 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat296 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat298 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_stat314 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_EXEC_in_stat317 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat319 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_command_in_stat335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_stat340 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat342 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat344 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat346 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_stat367 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat369 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_ID_in_stat371 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_21_in_stat374 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_stat383 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAY_in_stat394 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat396 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_ID_in_stat398 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_21_in_stat401 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAY_in_stat410 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_innerStat_in_multExpr426 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LINEBREAK_in_multExpr429 = new BitSet(new ulong[]{0x00000000000107F0UL});
    public static readonly BitSet FOLLOW_innerStat_in_multExpr432 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_innerStat444 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat446 = new BitSet(new ulong[]{0x0000000000010082UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_innerStat465 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat467 = new BitSet(new ulong[]{0x0000000000010082UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat469 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_innerStat491 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat493 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat495 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat497 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_innerStat518 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_EXEC_in_innerStat521 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat523 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_innerStat536 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat538 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_SAY_in_innerStat548 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat550 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ID_in_id566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_id571 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_id573 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_id575 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_command589 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_command592 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_command609 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_command612 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_command614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_innerCommand639 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_innerCommand659 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand662 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_META_in_guiRule697 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_firstGuiField_in_guiRule699 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_metaEnding_in_guiRule701 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_firstGuiField725 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_firstGuiField729 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_firstGuiField731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_guiFields_in_metaEnding760 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_guiFields_in_metaEnding768 = new BitSet(new ulong[]{0x00000000000187F0UL});
    public static readonly BitSet FOLLOW_LINEBREAK_in_metaEnding770 = new BitSet(new ulong[]{0x00000000000187F0UL});
    public static readonly BitSet FOLLOW_stat_in_metaEnding773 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_guiField_in_guiFields798 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_21_in_guiField812 = new BitSet(new ulong[]{0x0000000000030000UL});
    public static readonly BitSet FOLLOW_metaElement_in_guiField814 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_guiField816 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_metaElement834 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_metaElement851 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_21_in_emptyQuotes875 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_emptyQuotes876 = new BitSet(new ulong[]{0x0000000000000002UL});

}
