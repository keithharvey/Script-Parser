// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g 2011-06-20 21:41:00

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
            			    	PushFollow(FOLLOW_guiRule_in_prog142);
            			    	guiRule1 = guiRule();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, guiRule1.Tree);
            			    	 Debug.WriteLine(((guiRule1 != null) ? ((CommonTree)guiRule1.Tree) : null).ToStringTree()); 

            			    }
            			    break;
            			case 2 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:68: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog148);
            			    	stat2 = stat();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, stat2.Tree);
            			    	 Debug.WriteLine(((stat2 != null) ? ((CommonTree)stat2.Tree) : null).ToStringTree()); 

            			    }
            			    break;
            			case 3 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:36:123: LINEBREAK
            			    {
            			    	LINEBREAK3=(IToken)Match(input,LINEBREAK,FOLLOW_LINEBREAK_in_prog154); 

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
                    	ALIAS4=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_stat170);  
                    	stream_ALIAS.Add(ALIAS4);

                    	PushFollow(FOLLOW_id_in_stat172);
                    	id5 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id5.Tree);
                    	char_literal6=(IToken)Match(input,21,FOLLOW_21_in_stat174);  
                    	stream_21.Add(char_literal6);

                    	PushFollow(FOLLOW_multExpr_in_stat176);
                    	multExpr7 = multExpr();
                    	state.followingStackPointer--;

                    	stream_multExpr.Add(multExpr7.Tree);
                    	char_literal8=(IToken)Match(input,21,FOLLOW_21_in_stat178);  
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
                    	ALIAS9=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_stat193);  
                    	stream_ALIAS.Add(ALIAS9);

                    	PushFollow(FOLLOW_id_in_stat195);
                    	id10 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id10.Tree);
                    	PushFollow(FOLLOW_command_in_stat197);
                    	command11 = command();
                    	state.followingStackPointer--;

                    	stream_command.Add(command11.Tree);


                    	// AST REWRITE
                    	// elements:          ALIAS, command, id
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
                    	ALIAS12=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_stat212);  
                    	stream_ALIAS.Add(ALIAS12);

                    	PushFollow(FOLLOW_id_in_stat214);
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
                    	        	PushFollow(FOLLOW_emptyQuotes_in_stat216);
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
                    	BIND15=(IToken)Match(input,BIND,FOLLOW_BIND_in_stat230);  
                    	stream_BIND.Add(BIND15);

                    	PushFollow(FOLLOW_id_in_stat232);
                    	id16 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id16.Tree);
                    	char_literal17=(IToken)Match(input,21,FOLLOW_21_in_stat234);  
                    	stream_21.Add(char_literal17);

                    	PushFollow(FOLLOW_multExpr_in_stat236);
                    	multExpr18 = multExpr();
                    	state.followingStackPointer--;

                    	stream_multExpr.Add(multExpr18.Tree);
                    	char_literal19=(IToken)Match(input,21,FOLLOW_21_in_stat238);  
                    	stream_21.Add(char_literal19);



                    	// AST REWRITE
                    	// elements:          id, BIND, multExpr
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
                    	BIND20=(IToken)Match(input,BIND,FOLLOW_BIND_in_stat254);  
                    	stream_BIND.Add(BIND20);

                    	PushFollow(FOLLOW_id_in_stat256);
                    	id21 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id21.Tree);
                    	PushFollow(FOLLOW_command_in_stat258);
                    	command22 = command();
                    	state.followingStackPointer--;

                    	stream_command.Add(command22.Tree);


                    	// AST REWRITE
                    	// elements:          command, BIND, id
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
                    	BIND23=(IToken)Match(input,BIND,FOLLOW_BIND_in_stat273);  
                    	stream_BIND.Add(BIND23);

                    	PushFollow(FOLLOW_id_in_stat275);
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
                    	        	PushFollow(FOLLOW_emptyQuotes_in_stat277);
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
                    	        	RCON26=(IToken)Match(input,RCON,FOLLOW_RCON_in_stat291);  
                    	        	stream_RCON.Add(RCON26);


                    	        }
                    	        break;

                    	}

                    	EXEC27=(IToken)Match(input,EXEC,FOLLOW_EXEC_in_stat294);  
                    	stream_EXEC.Add(EXEC27);

                    	char_literal28=(IToken)Match(input,21,FOLLOW_21_in_stat296);  
                    	stream_21.Add(char_literal28);

                    	ID29=(IToken)Match(input,ID,FOLLOW_ID_in_stat298);  
                    	stream_ID.Add(ID29);

                    	char_literal30=(IToken)Match(input,21,FOLLOW_21_in_stat300);  
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
                    	        	RCON31=(IToken)Match(input,RCON,FOLLOW_RCON_in_stat316);  
                    	        	stream_RCON.Add(RCON31);


                    	        }
                    	        break;

                    	}

                    	EXEC32=(IToken)Match(input,EXEC,FOLLOW_EXEC_in_stat319);  
                    	stream_EXEC.Add(EXEC32);

                    	ID33=(IToken)Match(input,ID,FOLLOW_ID_in_stat321);  
                    	stream_ID.Add(ID33);



                    	// AST REWRITE
                    	// elements:          EXEC, RCON, ID
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

                    	PushFollow(FOLLOW_command_in_stat337);
                    	command34 = command();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, command34.Tree);

                    }
                    break;
                case 10 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:48:4: INCREMENT id id id id
                    {
                    	INCREMENT35=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_stat342);  
                    	stream_INCREMENT.Add(INCREMENT35);

                    	PushFollow(FOLLOW_id_in_stat344);
                    	id36 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id36.Tree);
                    	PushFollow(FOLLOW_id_in_stat346);
                    	id37 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id37.Tree);
                    	PushFollow(FOLLOW_id_in_stat348);
                    	id38 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id38.Tree);
                    	PushFollow(FOLLOW_id_in_stat350);
                    	id39 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id39.Tree);


                    	// AST REWRITE
                    	// elements:          id, id, id, INCREMENT, id
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
                    	ECHO40=(IToken)Match(input,ECHO,FOLLOW_ECHO_in_stat369);  
                    	stream_ECHO.Add(ECHO40);

                    	char_literal41=(IToken)Match(input,21,FOLLOW_21_in_stat371);  
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
                    			    	ID42=(IToken)Match(input,ID,FOLLOW_ID_in_stat373);  
                    			    	stream_ID.Add(ID42);


                    			    }
                    			    break;

                    			default:
                    			    goto loop6;
                    	    }
                    	} while (true);

                    	loop6:
                    		;	// Stops C# compiler whining that label 'loop6' has no statements

                    	char_literal43=(IToken)Match(input,21,FOLLOW_21_in_stat376);  
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
                    	ECHO44=(IToken)Match(input,ECHO,FOLLOW_ECHO_in_stat385);  
                    	stream_ECHO.Add(ECHO44);

                    	ID45=(IToken)Match(input,ID,FOLLOW_ID_in_stat387);  
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
                    	SAY46=(IToken)Match(input,SAY,FOLLOW_SAY_in_stat396);  
                    	stream_SAY.Add(SAY46);

                    	char_literal47=(IToken)Match(input,21,FOLLOW_21_in_stat398);  
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
                    			    	ID48=(IToken)Match(input,ID,FOLLOW_ID_in_stat400);  
                    			    	stream_ID.Add(ID48);


                    			    }
                    			    break;

                    			default:
                    			    goto loop7;
                    	    }
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	char_literal49=(IToken)Match(input,21,FOLLOW_21_in_stat403);  
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
                    	SAY50=(IToken)Match(input,SAY,FOLLOW_SAY_in_stat412);  
                    	stream_SAY.Add(SAY50);

                    	ID51=(IToken)Match(input,ID,FOLLOW_ID_in_stat414);  
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

            	PushFollow(FOLLOW_innerStat_in_multExpr428);
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
            			    	LINEBREAK53=(IToken)Match(input,LINEBREAK,FOLLOW_LINEBREAK_in_multExpr431); 
            			    	PushFollow(FOLLOW_innerStat_in_multExpr434);
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
                    	ALIAS55=(IToken)Match(input,ALIAS,FOLLOW_ALIAS_in_innerStat446);  
                    	stream_ALIAS.Add(ALIAS55);

                    	ID56=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat448);  
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
                    	        	PushFollow(FOLLOW_innerCommand_in_innerStat450);
                    	        	innerCommand57 = innerCommand();
                    	        	state.followingStackPointer--;

                    	        	stream_innerCommand.Add(innerCommand57.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          ALIAS, ID, innerCommand
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
                    	BIND58=(IToken)Match(input,BIND,FOLLOW_BIND_in_innerStat467);  
                    	stream_BIND.Add(BIND58);

                    	ID59=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat469);  
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
                    	        	PushFollow(FOLLOW_innerCommand_in_innerStat471);
                    	        	innerCommand60 = innerCommand();
                    	        	state.followingStackPointer--;

                    	        	stream_innerCommand.Add(innerCommand60.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          BIND, ID, ID
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

                    	PushFollow(FOLLOW_innerCommand_in_innerStat488);
                    	innerCommand61 = innerCommand();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, innerCommand61.Tree);

                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:61:4: INCREMENT ID ID ID ID
                    {
                    	INCREMENT62=(IToken)Match(input,INCREMENT,FOLLOW_INCREMENT_in_innerStat493);  
                    	stream_INCREMENT.Add(INCREMENT62);

                    	ID63=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat495);  
                    	stream_ID.Add(ID63);

                    	ID64=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat497);  
                    	stream_ID.Add(ID64);

                    	ID65=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat499);  
                    	stream_ID.Add(ID65);

                    	ID66=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat501);  
                    	stream_ID.Add(ID66);



                    	// AST REWRITE
                    	// elements:          ID, INCREMENT, ID, ID, ID
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
                    	        	RCON67=(IToken)Match(input,RCON,FOLLOW_RCON_in_innerStat520);  
                    	        	stream_RCON.Add(RCON67);


                    	        }
                    	        break;

                    	}

                    	EXEC68=(IToken)Match(input,EXEC,FOLLOW_EXEC_in_innerStat523);  
                    	stream_EXEC.Add(EXEC68);

                    	ID69=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat525);  
                    	stream_ID.Add(ID69);



                    	// AST REWRITE
                    	// elements:          ID, EXEC
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
                    	ECHO70=(IToken)Match(input,ECHO,FOLLOW_ECHO_in_innerStat538);  
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
                    			    	ID71=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat540);  
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
                    	SAY72=(IToken)Match(input,SAY,FOLLOW_SAY_in_innerStat550);  
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
                    			    	ID73=(IToken)Match(input,ID,FOLLOW_ID_in_innerStat552);  
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

                    	ID74=(IToken)Match(input,ID,FOLLOW_ID_in_id568); 
                    		ID74_tree = (CommonTree)adaptor.Create(ID74);
                    		adaptor.AddChild(root_0, ID74_tree);


                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:68:4: '\"' ID '\"'
                    {
                    	char_literal75=(IToken)Match(input,21,FOLLOW_21_in_id573);  
                    	stream_21.Add(char_literal75);

                    	ID76=(IToken)Match(input,ID,FOLLOW_ID_in_id575);  
                    	stream_ID.Add(ID76);

                    	char_literal77=(IToken)Match(input,21,FOLLOW_21_in_id577);  
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
                    	        	RCON78=(IToken)Match(input,RCON,FOLLOW_RCON_in_command591);  
                    	        	stream_RCON.Add(RCON78);


                    	        }
                    	        break;

                    	}

                    	ID79=(IToken)Match(input,ID,FOLLOW_ID_in_command594);  
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
                    	        	RCON80=(IToken)Match(input,RCON,FOLLOW_RCON_in_command611);  
                    	        	stream_RCON.Add(RCON80);


                    	        }
                    	        break;

                    	}

                    	ID81=(IToken)Match(input,ID,FOLLOW_ID_in_command614);  
                    	stream_ID.Add(ID81);

                    	PushFollow(FOLLOW_id_in_command616);
                    	id82 = id();
                    	state.followingStackPointer--;

                    	stream_id.Add(id82.Tree);


                    	// AST REWRITE
                    	// elements:          RCON, ID, id
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
                    	        	RCON83=(IToken)Match(input,RCON,FOLLOW_RCON_in_innerCommand641);  
                    	        	stream_RCON.Add(RCON83);


                    	        }
                    	        break;

                    	}

                    	ID84=(IToken)Match(input,ID,FOLLOW_ID_in_innerCommand644);  
                    	stream_ID.Add(ID84);



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
                    	        	RCON85=(IToken)Match(input,RCON,FOLLOW_RCON_in_innerCommand661);  
                    	        	stream_RCON.Add(RCON85);


                    	        }
                    	        break;

                    	}

                    	ID86=(IToken)Match(input,ID,FOLLOW_ID_in_innerCommand664);  
                    	stream_ID.Add(ID86);

                    	ID87=(IToken)Match(input,ID,FOLLOW_ID_in_innerCommand666);  
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
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:78:1: guiRule : META guiFields ( LINEBREAK )* stat -> ^( META guiFields stat ) ;
    public SourceExprParser.guiRule_return guiRule() // throws RecognitionException [1]
    {   
        SourceExprParser.guiRule_return retval = new SourceExprParser.guiRule_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken META88 = null;
        IToken LINEBREAK90 = null;
        SourceExprParser.guiFields_return guiFields89 = default(SourceExprParser.guiFields_return);

        SourceExprParser.stat_return stat91 = default(SourceExprParser.stat_return);


        CommonTree META88_tree=null;
        CommonTree LINEBREAK90_tree=null;
        RewriteRuleTokenStream stream_META = new RewriteRuleTokenStream(adaptor,"token META");
        RewriteRuleTokenStream stream_LINEBREAK = new RewriteRuleTokenStream(adaptor,"token LINEBREAK");
        RewriteRuleSubtreeStream stream_guiFields = new RewriteRuleSubtreeStream(adaptor,"rule guiFields");
        RewriteRuleSubtreeStream stream_stat = new RewriteRuleSubtreeStream(adaptor,"rule stat");
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:79:2: ( META guiFields ( LINEBREAK )* stat -> ^( META guiFields stat ) )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:79:4: META guiFields ( LINEBREAK )* stat
            {
            	META88=(IToken)Match(input,META,FOLLOW_META_in_guiRule690);  
            	stream_META.Add(META88);

            	PushFollow(FOLLOW_guiFields_in_guiRule692);
            	guiFields89 = guiFields();
            	state.followingStackPointer--;

            	stream_guiFields.Add(guiFields89.Tree);
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:79:19: ( LINEBREAK )*
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
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:79:19: LINEBREAK
            			    {
            			    	LINEBREAK90=(IToken)Match(input,LINEBREAK,FOLLOW_LINEBREAK_in_guiRule694);  
            			    	stream_LINEBREAK.Add(LINEBREAK90);


            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements

            	PushFollow(FOLLOW_stat_in_guiRule697);
            	stat91 = stat();
            	state.followingStackPointer--;

            	stream_stat.Add(stat91.Tree);


            	// AST REWRITE
            	// elements:          META, guiFields, stat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (CommonTree)adaptor.GetNilNode();
            	// 80:3: -> ^( META guiFields stat )
            	{
            	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:80:7: ^( META guiFields stat )
            	    {
            	    CommonTree root_1 = (CommonTree)adaptor.GetNilNode();
            	    root_1 = (CommonTree)adaptor.BecomeRoot(stream_META.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_guiFields.NextTree());
            	    adaptor.AddChild(root_1, stream_stat.NextTree());

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
        }
        return retval;
    }
    // $ANTLR end "guiRule"

    protected class guiFields_scope 
    {
        protected internal bool first;
        protected internal int n;
        protected internal string metaType;
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
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:83:1: guiFields : ( guiField )+ ;
    public SourceExprParser.guiFields_return guiFields() // throws RecognitionException [1]
    {   
        guiFields_stack.Push(new guiFields_scope());
        SourceExprParser.guiFields_return retval = new SourceExprParser.guiFields_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SourceExprParser.guiField_return guiField92 = default(SourceExprParser.guiField_return);



         ((guiFields_scope)guiFields_stack.Peek()).first =  true; ((guiFields_scope)guiFields_stack.Peek()).n =  0; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:89:2: ( ( guiField )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:89:4: ( guiField )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:89:4: ( guiField )+
            	int cnt24 = 0;
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == 21) && ((((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))|| (((guiFields_scope)guiFields_stack.Peek()).first))) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:89:5: guiField
            			    {
            			    	PushFollow(FOLLOW_guiField_in_guiFields737);
            			    	guiField92 = guiField();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, guiField92.Tree);
            			    	((guiFields_scope)guiFields_stack.Peek()).n++;

            			    }
            			    break;

            			default:
            			    if ( cnt24 >= 1 ) goto loop24;
            		            EarlyExitException eee24 =
            		                new EarlyExitException(24, input);
            		            throw eee24;
            	    }
            	    cnt24++;
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


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
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:91:1: guiField : ( identifyingMetaElement | {...}? => ( '\"' metaElement '\"' )+ -> ( metaElement )+ );
    public SourceExprParser.guiField_return guiField() // throws RecognitionException [1]
    {   
        SourceExprParser.guiField_return retval = new SourceExprParser.guiField_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal94 = null;
        IToken char_literal96 = null;
        SourceExprParser.identifyingMetaElement_return identifyingMetaElement93 = default(SourceExprParser.identifyingMetaElement_return);

        SourceExprParser.metaElement_return metaElement95 = default(SourceExprParser.metaElement_return);


        CommonTree char_literal94_tree=null;
        CommonTree char_literal96_tree=null;
        RewriteRuleTokenStream stream_21 = new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleSubtreeStream stream_metaElement = new RewriteRuleSubtreeStream(adaptor,"rule metaElement");
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:91:9: ( identifyingMetaElement | {...}? => ( '\"' metaElement '\"' )+ -> ( metaElement )+ )
            int alt26 = 2;
            int LA26_0 = input.LA(1);

            if ( (LA26_0 == 21) && ((((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))|| (((guiFields_scope)guiFields_stack.Peek()).first))) )
            {
                int LA26_1 = input.LA(2);

                if ( (LA26_1 == ID) && ((((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))|| (((guiFields_scope)guiFields_stack.Peek()).first))) )
                {
                    int LA26_2 = input.LA(3);

                    if ( (LA26_2 == 21) && ((((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))|| (((guiFields_scope)guiFields_stack.Peek()).first))) )
                    {
                        int LA26_4 = input.LA(4);

                        if ( ((((guiFields_scope)guiFields_stack.Peek()).first)) )
                        {
                            alt26 = 1;
                        }
                        else if ( (((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))) )
                        {
                            alt26 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d26s4 =
                                new NoViableAltException("", 26, 4, input);

                            throw nvae_d26s4;
                        }
                    }
                    else if ( (LA26_2 == ID) && (((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))) )
                    {
                        alt26 = 2;
                    }
                    else 
                    {
                        NoViableAltException nvae_d26s2 =
                            new NoViableAltException("", 26, 2, input);

                        throw nvae_d26s2;
                    }
                }
                else if ( (LA26_1 == INT) && (((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))) )
                {
                    alt26 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d26s1 =
                        new NoViableAltException("", 26, 1, input);

                    throw nvae_d26s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d26s0 =
                    new NoViableAltException("", 26, 0, input);

                throw nvae_d26s0;
            }
            switch (alt26) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:91:11: identifyingMetaElement
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_identifyingMetaElement_in_guiField749);
                    	identifyingMetaElement93 = identifyingMetaElement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, identifyingMetaElement93.Tree);

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:92:4: {...}? => ( '\"' metaElement '\"' )+
                    {
                    	if ( !(((((guiFields_scope)guiFields_stack.Peek()).first==false && ((guiFields_scope)guiFields_stack.Peek()).n < _script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].NumberOfMetaFields))) ) 
                    	{
                    	    throw new FailedPredicateException(input, "guiField", "($guiFields::first==false && $guiFields::n < _script.SupportedMetaData[$guiFields::metaType].NumberOfMetaFields)");
                    	}
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:92:121: ( '\"' metaElement '\"' )+
                    	int cnt25 = 0;
                    	do 
                    	{
                    	    int alt25 = 2;
                    	    int LA25_0 = input.LA(1);

                    	    if ( (LA25_0 == 21) )
                    	    {
                    	        alt25 = 1;
                    	    }


                    	    switch (alt25) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:92:122: '\"' metaElement '\"'
                    			    {
                    			    	char_literal94=(IToken)Match(input,21,FOLLOW_21_in_guiField757);  
                    			    	stream_21.Add(char_literal94);

                    			    	PushFollow(FOLLOW_metaElement_in_guiField759);
                    			    	metaElement95 = metaElement();
                    			    	state.followingStackPointer--;

                    			    	stream_metaElement.Add(metaElement95.Tree);
                    			    	char_literal96=(IToken)Match(input,21,FOLLOW_21_in_guiField761);  
                    			    	stream_21.Add(char_literal96);


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
                    	// 93:3: -> ( metaElement )+
                    	{
                    	    if ( !(stream_metaElement.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_metaElement.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_0, stream_metaElement.NextTree());

                    	    }
                    	    stream_metaElement.Reset();

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
    // $ANTLR end "guiField"

    public class identifyingMetaElement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "identifyingMetaElement"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:95:1: identifyingMetaElement : ({...}? => '\"' id1= ID '\"' ) {...}? -> ID ;
    public SourceExprParser.identifyingMetaElement_return identifyingMetaElement() // throws RecognitionException [1]
    {   
        SourceExprParser.identifyingMetaElement_return retval = new SourceExprParser.identifyingMetaElement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken id1 = null;
        IToken char_literal97 = null;
        IToken char_literal98 = null;

        CommonTree id1_tree=null;
        CommonTree char_literal97_tree=null;
        CommonTree char_literal98_tree=null;
        RewriteRuleTokenStream stream_21 = new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:96:2: ( ({...}? => '\"' id1= ID '\"' ) {...}? -> ID )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:96:4: ({...}? => '\"' id1= ID '\"' ) {...}?
            {
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:96:4: ({...}? => '\"' id1= ID '\"' )
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:96:5: {...}? => '\"' id1= ID '\"'
            	{
            		if ( !((((guiFields_scope)guiFields_stack.Peek()).first)) ) 
            		{
            		    throw new FailedPredicateException(input, "identifyingMetaElement", "$guiFields::first");
            		}
            		char_literal97=(IToken)Match(input,21,FOLLOW_21_in_identifyingMetaElement784);  
            		stream_21.Add(char_literal97);

            		id1=(IToken)Match(input,ID,FOLLOW_ID_in_identifyingMetaElement788);  
            		stream_ID.Add(id1);

            		char_literal98=(IToken)Match(input,21,FOLLOW_21_in_identifyingMetaElement790);  
            		stream_21.Add(char_literal98);

            		 ((guiFields_scope)guiFields_stack.Peek()).metaType = ((id1 != null) ? id1.Text : null); ((guiFields_scope)guiFields_stack.Peek()).first =  false; 

            	}

            	if ( !((_script.SupportedMetaData[((id1 != null) ? id1.Text : null)].IsAValidField(((guiFields_scope)guiFields_stack.Peek()).n, ((id1 != null) ? id1.Text : null), ((guiFields_scope)guiFields_stack.Peek()).first) )) ) 
            	{
            	    throw new FailedPredicateException(input, "identifyingMetaElement", "_script.SupportedMetaData[$id1.text].IsAValidField($guiFields::n, $id1.text, $guiFields::first) ");
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
            	// 98:3: -> ID
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
    // $ANTLR end "identifyingMetaElement"

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
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:100:1: metaElement : ({...}? => INT -> ^( METAINT INT ) | {...}? => ( ID )+ -> ^( METATEXT ( ID )+ ) );
    public SourceExprParser.metaElement_return metaElement() // throws RecognitionException [1]
    {   
        SourceExprParser.metaElement_return retval = new SourceExprParser.metaElement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken INT99 = null;
        IToken ID100 = null;

        CommonTree INT99_tree=null;
        CommonTree ID100_tree=null;
        RewriteRuleTokenStream stream_INT = new RewriteRuleTokenStream(adaptor,"token INT");
        RewriteRuleTokenStream stream_ID = new RewriteRuleTokenStream(adaptor,"token ID");

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:101:2: ({...}? => INT -> ^( METAINT INT ) | {...}? => ( ID )+ -> ^( METATEXT ( ID )+ ) )
            int alt28 = 2;
            int LA28_0 = input.LA(1);

            if ( (LA28_0 == INT) && ((_script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) )
            {
                alt28 = 1;
            }
            else if ( (LA28_0 == ID) && ((!_script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) )
            {
                alt28 = 2;
            }
            else 
            {
                NoViableAltException nvae_d28s0 =
                    new NoViableAltException("", 28, 0, input);

                throw nvae_d28s0;
            }
            switch (alt28) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:102:3: {...}? => INT
                    {
                    	if ( !((_script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) ) 
                    	{
                    	    throw new FailedPredicateException(input, "metaElement", "_script.SupportedMetaData[$guiFields::metaType].FieldIsInt($guiFields::n)");
                    	}
                    	INT99=(IToken)Match(input,INT,FOLLOW_INT_in_metaElement820);  
                    	stream_INT.Add(INT99);



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
                    	// 103:3: -> ^( METAINT INT )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:103:6: ^( METAINT INT )
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
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:104:4: {...}? => ( ID )+
                    {
                    	if ( !((!_script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType].FieldIsInt(((guiFields_scope)guiFields_stack.Peek()).n))) ) 
                    	{
                    	    throw new FailedPredicateException(input, "metaElement", "!_script.SupportedMetaData[$guiFields::metaType].FieldIsInt($guiFields::n)");
                    	}
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:104:83: ( ID )+
                    	int cnt27 = 0;
                    	do 
                    	{
                    	    int alt27 = 2;
                    	    int LA27_0 = input.LA(1);

                    	    if ( (LA27_0 == ID) )
                    	    {
                    	        alt27 = 1;
                    	    }


                    	    switch (alt27) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:104:83: ID
                    			    {
                    			    	ID100=(IToken)Match(input,ID,FOLLOW_ID_in_metaElement837);  
                    			    	stream_ID.Add(ID100);


                    			    }
                    			    break;

                    			default:
                    			    if ( cnt27 >= 1 ) goto loop27;
                    		            EarlyExitException eee27 =
                    		                new EarlyExitException(27, input);
                    		            throw eee27;
                    	    }
                    	    cnt27++;
                    	} while (true);

                    	loop27:
                    		;	// Stops C# compiler whining that label 'loop27' has no statements



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
                    	// 105:3: -> ^( METATEXT ( ID )+ )
                    	{
                    	    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:105:6: ^( METATEXT ( ID )+ )
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
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:107:2: emptyQuotes : '\"' '\"' ;
    public SourceExprParser.emptyQuotes_return emptyQuotes() // throws RecognitionException [1]
    {   
        SourceExprParser.emptyQuotes_return retval = new SourceExprParser.emptyQuotes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken char_literal101 = null;
        IToken char_literal102 = null;

        CommonTree char_literal101_tree=null;
        CommonTree char_literal102_tree=null;

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:108:3: ( '\"' '\"' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:108:5: '\"' '\"'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	char_literal101=(IToken)Match(input,21,FOLLOW_21_in_emptyQuotes861); 
            		char_literal101_tree = (CommonTree)adaptor.Create(char_literal101);
            		adaptor.AddChild(root_0, char_literal101_tree);

            	char_literal102=(IToken)Match(input,21,FOLLOW_21_in_emptyQuotes862); 
            		char_literal102_tree = (CommonTree)adaptor.Create(char_literal102);
            		adaptor.AddChild(root_0, char_literal102_tree);


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
	private void InitializeCyclicDFAs()
	{
    	this.dfa8 = new DFA8(this);
	}

    const string DFA8_eotS =
        "\x21\uffff";
    const string DFA8_eofS =
        "\x09\uffff\x01\x16\x01\uffff\x01\x1b\x12\uffff\x01\x16\x01\uffff"+
        "\x01\x1b";
    const string DFA8_minS =
        "\x01\x04\x02\x10\x01\x06\x01\x10\x02\uffff\x02\x10\x01\x04\x01"+
        "\x10\x01\x04\x01\x10\x06\uffff\x01\x04\x01\x06\x02\uffff\x01\x15"+
        "\x01\x04\x01\x06\x02\uffff\x01\x15\x01\uffff\x01\x04\x01\uffff\x01"+
        "\x04";
    const string DFA8_maxS =
        "\x01\x10\x02\x15\x01\x10\x01\x15\x02\uffff\x03\x15\x01\x10\x01"+
        "\x15\x01\x10\x06\uffff\x01\x15\x01\x10\x02\uffff\x02\x15\x01\x10"+
        "\x02\uffff\x01\x15\x01\uffff\x01\x15\x01\uffff\x01\x15";
    const string DFA8_acceptS =
        "\x05\uffff\x01\x09\x01\x0a\x06\uffff\x01\x07\x01\x08\x01\x0b\x01"+
        "\x0c\x01\x0d\x01\x0e\x02\uffff\x01\x02\x01\x03\x03\uffff\x01\x05"+
        "\x01\x06\x01\uffff\x01\x01\x01\uffff\x01\x04\x01\uffff";
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
            "\x03\x16\x01\x14\x04\x16\x03\uffff\x01\x16\x01\x15\x04\uffff"+
            "\x01\x13",
            "\x01\x17",
            "\x03\x1b\x01\x19\x04\x1b\x03\uffff\x01\x1b\x01\x1a\x04\uffff"+
            "\x01\x18",
            "\x01\x1c",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x07\x1d\x05\uffff\x01\x1d\x04\uffff\x01\x16",
            "\x01\x16\x09\uffff\x01\x15",
            "",
            "",
            "\x01\x1e",
            "\x07\x1f\x05\uffff\x01\x1f\x04\uffff\x01\x1b",
            "\x01\x1b\x09\uffff\x01\x1a",
            "",
            "",
            "\x01\x20",
            "",
            "\x03\x16\x01\x14\x04\x16\x03\uffff\x01\x16\x01\x15\x04\uffff"+
            "\x01\x13",
            "",
            "\x03\x1b\x01\x19\x04\x1b\x03\uffff\x01\x1b\x01\x1a\x04\uffff"+
            "\x01\x18"
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

 

    public static readonly BitSet FOLLOW_guiRule_in_prog142 = new BitSet(new ulong[]{0x0000000000018FF2UL});
    public static readonly BitSet FOLLOW_stat_in_prog148 = new BitSet(new ulong[]{0x0000000000018FF2UL});
    public static readonly BitSet FOLLOW_LINEBREAK_in_prog154 = new BitSet(new ulong[]{0x0000000000018FF2UL});
    public static readonly BitSet FOLLOW_ALIAS_in_stat170 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat172 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat174 = new BitSet(new ulong[]{0x00000000000107F0UL});
    public static readonly BitSet FOLLOW_multExpr_in_stat176 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_stat193 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat195 = new BitSet(new ulong[]{0x0000000000010080UL});
    public static readonly BitSet FOLLOW_command_in_stat197 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_stat212 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat214 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_emptyQuotes_in_stat216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_stat230 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat232 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat234 = new BitSet(new ulong[]{0x00000000000107F0UL});
    public static readonly BitSet FOLLOW_multExpr_in_stat236 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_stat254 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat256 = new BitSet(new ulong[]{0x0000000000010080UL});
    public static readonly BitSet FOLLOW_command_in_stat258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_stat273 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat275 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_emptyQuotes_in_stat277 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_stat291 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_EXEC_in_stat294 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat296 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat298 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat300 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_stat316 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_EXEC_in_stat319 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat321 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_command_in_stat337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_stat342 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat344 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat346 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat348 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_stat350 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_stat369 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat371 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_ID_in_stat373 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_21_in_stat376 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_stat385 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAY_in_stat396 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_stat398 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_ID_in_stat400 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_21_in_stat403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAY_in_stat412 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_stat414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_innerStat_in_multExpr428 = new BitSet(new ulong[]{0x0000000000008000UL});
    public static readonly BitSet FOLLOW_LINEBREAK_in_multExpr431 = new BitSet(new ulong[]{0x00000000000107F0UL});
    public static readonly BitSet FOLLOW_innerStat_in_multExpr434 = new BitSet(new ulong[]{0x0000000000008002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_innerStat446 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat448 = new BitSet(new ulong[]{0x0000000000010082UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat450 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_innerStat467 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat469 = new BitSet(new ulong[]{0x0000000000010082UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_innerStat493 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat495 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat497 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat499 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat501 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_innerStat520 = new BitSet(new ulong[]{0x0000000000000040UL});
    public static readonly BitSet FOLLOW_EXEC_in_innerStat523 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_innerStat538 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat540 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_SAY_in_innerStat550 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat552 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_ID_in_id568 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_id573 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_id575 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_id577 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_command591 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_command594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_command611 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_command614 = new BitSet(new ulong[]{0x0000000000210000UL});
    public static readonly BitSet FOLLOW_id_in_command616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_innerCommand641 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RCON_in_innerCommand661 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand664 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand666 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_META_in_guiRule690 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_guiFields_in_guiRule692 = new BitSet(new ulong[]{0x00000000000187F0UL});
    public static readonly BitSet FOLLOW_LINEBREAK_in_guiRule694 = new BitSet(new ulong[]{0x00000000000187F0UL});
    public static readonly BitSet FOLLOW_stat_in_guiRule697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_guiField_in_guiFields737 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_identifyingMetaElement_in_guiField749 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_21_in_guiField757 = new BitSet(new ulong[]{0x0000000000030000UL});
    public static readonly BitSet FOLLOW_metaElement_in_guiField759 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_guiField761 = new BitSet(new ulong[]{0x0000000000200002UL});
    public static readonly BitSet FOLLOW_21_in_identifyingMetaElement784 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_identifyingMetaElement788 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_identifyingMetaElement790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INT_in_metaElement820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ID_in_metaElement837 = new BitSet(new ulong[]{0x0000000000010002UL});
    public static readonly BitSet FOLLOW_21_in_emptyQuotes861 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_21_in_emptyQuotes862 = new BitSet(new ulong[]{0x0000000000000002UL});

}
