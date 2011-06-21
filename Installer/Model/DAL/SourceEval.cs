// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g 2011-06-20 22:02:04

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System.Collections.Generic;
	using Installer.Model;
	using System.Diagnostics;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class SourceEval : TreeParser
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
    public const int INT = 17;
    public const int EXEC = 6;
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



        public SourceEval(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SourceEval(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return SourceEval.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g"; }
    }


    	Script _script;
    	MetaData<IMeta> currentMetaData = null;



    // $ANTLR start "prog"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:22:1: prog[Script passedScriptInstance] : ( guiRule | stat )+ ;
    public void prog(Script passedScriptInstance) // throws RecognitionException [1]
    {   
         _script = passedScriptInstance; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:24:2: ( ( guiRule | stat )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:24:5: ( guiRule | stat )+
            {
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:24:5: ( guiRule | stat )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == META) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( ((LA1_0 >= ALIAS && LA1_0 <= EXEC) || (LA1_0 >= INCREMENT && LA1_0 <= SAY) || LA1_0 == COMMAND) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:24:6: guiRule
            			    {
            			    	PushFollow(FOLLOW_guiRule_in_prog66);
            			    	guiRule();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:24:16: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog70);
            			    	stat();
            			    	state.followingStackPointer--;

            			    	currentMetaData = null;

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

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "prog"


    // $ANTLR start "stat"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:27:1: stat : (a= alias | b= bind | e= exec | c= command | increment | ECHO | SAY );
    public void stat() // throws RecognitionException [1]
    {   
        Alias a = default(Alias);

        Bind b = default(Bind);

        Exec e = default(Exec);

        Command c = default(Command);


        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:28:2: (a= alias | b= bind | e= exec | c= command | increment | ECHO | SAY )
            int alt2 = 7;
            switch ( input.LA(1) ) 
            {
            case ALIAS:
            	{
                alt2 = 1;
                }
                break;
            case BIND:
            	{
                alt2 = 2;
                }
                break;
            case EXEC:
            	{
                alt2 = 3;
                }
                break;
            case COMMAND:
            	{
                alt2 = 4;
                }
                break;
            case INCREMENT:
            	{
                alt2 = 5;
                }
                break;
            case ECHO:
            	{
                alt2 = 6;
                }
                break;
            case SAY:
            	{
                alt2 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:28:4: a= alias
                    {
                    	PushFollow(FOLLOW_alias_in_stat87);
                    	a = alias();
                    	state.followingStackPointer--;

                    	if(a != null) {_script.Content.Add(a);}

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:29:4: b= bind
                    {
                    	PushFollow(FOLLOW_bind_in_stat96);
                    	b = bind();
                    	state.followingStackPointer--;

                    	if(b != null) {_script.Content.Add(b);}

                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:30:4: e= exec
                    {
                    	PushFollow(FOLLOW_exec_in_stat105);
                    	e = exec();
                    	state.followingStackPointer--;

                    	if(e != null) {_script.Content.Add(e);}

                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:31:4: c= command
                    {
                    	PushFollow(FOLLOW_command_in_stat115);
                    	c = command();
                    	state.followingStackPointer--;

                    	if(c !=null) {_script.Content.Add(c);}

                    }
                    break;
                case 5 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:32:4: increment
                    {
                    	PushFollow(FOLLOW_increment_in_stat122);
                    	increment();
                    	state.followingStackPointer--;


                    }
                    break;
                case 6 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:33:4: ECHO
                    {
                    	Match(input,ECHO,FOLLOW_ECHO_in_stat127); 

                    }
                    break;
                case 7 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:34:4: SAY
                    {
                    	Match(input,SAY,FOLLOW_SAY_in_stat132); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "stat"


    // $ANTLR start "alias"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:38:1: alias returns [Alias alias] : ( ^( ALIAS ID (id= innerStat )+ ) | sA= simpleAlias );
    public Alias alias() // throws RecognitionException [1]
    {   
        Alias alias = default(Alias);

        CommonTree ID1 = null;
        IStatement id = default(IStatement);

        Alias sA = default(Alias);


         List<IStatement> innerList = new List<IStatement>(); 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:41:2: ( ^( ALIAS ID (id= innerStat )+ ) | sA= simpleAlias )
            int alt4 = 2;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:41:4: ^( ALIAS ID (id= innerStat )+ )
                    {
                    	Match(input,ALIAS,FOLLOW_ALIAS_in_alias157); 

                    	Match(input, Token.DOWN, null); 
                    	ID1=(CommonTree)Match(input,ID,FOLLOW_ID_in_alias159); 
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:41:16: (id= innerStat )+
                    	int cnt3 = 0;
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= ALIAS && LA3_0 <= EXEC) || (LA3_0 >= INCREMENT && LA3_0 <= SAY) || LA3_0 == COMMAND) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:41:17: id= innerStat
                    			    {
                    			    	PushFollow(FOLLOW_innerStat_in_alias165);
                    			    	id = innerStat();
                    			    	state.followingStackPointer--;

                    			    	if(id != null) {innerList.Add(id);}

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt3 >= 1 ) goto loop3;
                    		            EarlyExitException eee3 =
                    		                new EarlyExitException(3, input);
                    		            throw eee3;
                    	    }
                    	    cnt3++;
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements


                    	Match(input, Token.UP, null); 
                    	alias = new Alias(((ID1 != null) ? ID1.Text : null), innerList , StatementType.Alias, currentMetaData); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:43:4: sA= simpleAlias
                    {
                    	PushFollow(FOLLOW_simpleAlias_in_alias184);
                    	sA = simpleAlias();
                    	state.followingStackPointer--;

                    	alias = sA;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return alias;
    }
    // $ANTLR end "alias"


    // $ANTLR start "bind"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:46:1: bind returns [Bind bind] : ( ^( BIND ID (id= innerStat )+ ) | sB= simpleBind );
    public Bind bind() // throws RecognitionException [1]
    {   
        Bind bind = default(Bind);

        CommonTree ID2 = null;
        IStatement id = default(IStatement);

        Bind sB = default(Bind);


         List<IStatement> innerList = new List<IStatement>(); 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:49:2: ( ^( BIND ID (id= innerStat )+ ) | sB= simpleBind )
            int alt6 = 2;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:49:4: ^( BIND ID (id= innerStat )+ )
                    {
                    	Match(input,BIND,FOLLOW_BIND_in_bind209); 

                    	Match(input, Token.DOWN, null); 
                    	ID2=(CommonTree)Match(input,ID,FOLLOW_ID_in_bind211); 
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:49:14: (id= innerStat )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= ALIAS && LA5_0 <= EXEC) || (LA5_0 >= INCREMENT && LA5_0 <= SAY) || LA5_0 == COMMAND) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:49:16: id= innerStat
                    			    {
                    			    	PushFollow(FOLLOW_innerStat_in_bind217);
                    			    	id = innerStat();
                    			    	state.followingStackPointer--;

                    			    	if(id != null) {innerList.Add(id);}

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements


                    	Match(input, Token.UP, null); 
                    	 bind = new Bind(((ID2 != null) ? ID2.Text : null), innerList, StatementType.Alias, currentMetaData); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:51:4: sB= simpleBind
                    {
                    	PushFollow(FOLLOW_simpleBind_in_bind235);
                    	sB = simpleBind();
                    	state.followingStackPointer--;

                    	bind = sB; 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return bind;
    }
    // $ANTLR end "bind"


    // $ANTLR start "innerStat"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:54:1: innerStat returns [IStatement innerStat] : (sA= simpleAlias | sB= simpleBind | c= command | increment | e= exec | ECHO | SAY );
    public IStatement innerStat() // throws RecognitionException [1]
    {   
        IStatement innerStat = default(IStatement);

        Alias sA = default(Alias);

        Bind sB = default(Bind);

        Command c = default(Command);

        Exec e = default(Exec);


        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:55:2: (sA= simpleAlias | sB= simpleBind | c= command | increment | e= exec | ECHO | SAY )
            int alt7 = 7;
            switch ( input.LA(1) ) 
            {
            case ALIAS:
            	{
                alt7 = 1;
                }
                break;
            case BIND:
            	{
                alt7 = 2;
                }
                break;
            case COMMAND:
            	{
                alt7 = 3;
                }
                break;
            case INCREMENT:
            	{
                alt7 = 4;
                }
                break;
            case EXEC:
            	{
                alt7 = 5;
                }
                break;
            case ECHO:
            	{
                alt7 = 6;
                }
                break;
            case SAY:
            	{
                alt7 = 7;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            }

            switch (alt7) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:55:4: sA= simpleAlias
                    {
                    	PushFollow(FOLLOW_simpleAlias_in_innerStat255);
                    	sA = simpleAlias();
                    	state.followingStackPointer--;

                    	 innerStat = sA; 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:56:4: sB= simpleBind
                    {
                    	PushFollow(FOLLOW_simpleBind_in_innerStat264);
                    	sB = simpleBind();
                    	state.followingStackPointer--;

                    	 innerStat = sB; 

                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:57:4: c= command
                    {
                    	PushFollow(FOLLOW_command_in_innerStat273);
                    	c = command();
                    	state.followingStackPointer--;

                    	 innerStat = c; 

                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:58:4: increment
                    {
                    	PushFollow(FOLLOW_increment_in_innerStat280);
                    	increment();
                    	state.followingStackPointer--;

                    	 innerStat = null; 

                    }
                    break;
                case 5 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:59:4: e= exec
                    {
                    	PushFollow(FOLLOW_exec_in_innerStat289);
                    	e = exec();
                    	state.followingStackPointer--;

                    	 innerStat = e; 

                    }
                    break;
                case 6 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:60:4: ECHO
                    {
                    	Match(input,ECHO,FOLLOW_ECHO_in_innerStat296); 

                    }
                    break;
                case 7 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:61:4: SAY
                    {
                    	Match(input,SAY,FOLLOW_SAY_in_innerStat301); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return innerStat;
    }
    // $ANTLR end "innerStat"


    // $ANTLR start "simpleAlias"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:64:1: simpleAlias returns [Alias simpleAlias] : ( ^( ALIAS i1= ID ) | ^( ALIAS i1= ID c= command ) );
    public Alias simpleAlias() // throws RecognitionException [1]
    {   
        Alias simpleAlias = default(Alias);

        CommonTree i1 = null;
        Command c = default(Command);


         string id1 = null; List<IStatement> statList = new List<IStatement>(); 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:68:2: ( ^( ALIAS i1= ID ) | ^( ALIAS i1= ID c= command ) )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == ALIAS) )
            {
                int LA8_1 = input.LA(2);

                if ( (LA8_1 == DOWN) )
                {
                    int LA8_2 = input.LA(3);

                    if ( (LA8_2 == ID) )
                    {
                        int LA8_3 = input.LA(4);

                        if ( (LA8_3 == UP) )
                        {
                            alt8 = 1;
                        }
                        else if ( (LA8_3 == COMMAND) )
                        {
                            alt8 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d8s3 =
                                new NoViableAltException("", 8, 3, input);

                            throw nvae_d8s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d8s2 =
                            new NoViableAltException("", 8, 2, input);

                        throw nvae_d8s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d8s1 =
                        new NoViableAltException("", 8, 1, input);

                    throw nvae_d8s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:68:4: ^( ALIAS i1= ID )
                    {
                    	Match(input,ALIAS,FOLLOW_ALIAS_in_simpleAlias330); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_simpleAlias334); 

                    	Match(input, Token.UP, null); 
                    	 id1 = ((i1 != null) ? i1.Text : null); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:69:4: ^( ALIAS i1= ID c= command )
                    {
                    	Match(input,ALIAS,FOLLOW_ALIAS_in_simpleAlias343); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_simpleAlias347); 
                    	PushFollow(FOLLOW_command_in_simpleAlias351);
                    	c = command();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 id1 = ((i1 != null) ? i1.Text : null); statList.Add(c); 

                    }
                    break;

            }
             simpleAlias = new Alias(id1, statList, StatementType.Alias, currentMetaData); 
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return simpleAlias;
    }
    // $ANTLR end "simpleAlias"


    // $ANTLR start "simpleBind"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:73:1: simpleBind returns [Bind simpleBind] : ( ^( BIND i1= ID ) | ^( BIND i1= ID c= command ) );
    public Bind simpleBind() // throws RecognitionException [1]
    {   
        Bind simpleBind = default(Bind);

        CommonTree i1 = null;
        Command c = default(Command);


         string id1 = null; List<IStatement> statList = new List<IStatement>(); 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:77:2: ( ^( BIND i1= ID ) | ^( BIND i1= ID c= command ) )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == BIND) )
            {
                int LA9_1 = input.LA(2);

                if ( (LA9_1 == DOWN) )
                {
                    int LA9_2 = input.LA(3);

                    if ( (LA9_2 == ID) )
                    {
                        int LA9_3 = input.LA(4);

                        if ( (LA9_3 == UP) )
                        {
                            alt9 = 1;
                        }
                        else if ( (LA9_3 == COMMAND) )
                        {
                            alt9 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d9s3 =
                                new NoViableAltException("", 9, 3, input);

                            throw nvae_d9s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d9s2 =
                            new NoViableAltException("", 9, 2, input);

                        throw nvae_d9s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d9s1 =
                        new NoViableAltException("", 9, 1, input);

                    throw nvae_d9s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:77:4: ^( BIND i1= ID )
                    {
                    	Match(input,BIND,FOLLOW_BIND_in_simpleBind383); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_simpleBind387); 

                    	Match(input, Token.UP, null); 
                    	 id1 = ((i1 != null) ? i1.Text : null); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:78:4: ^( BIND i1= ID c= command )
                    {
                    	Match(input,BIND,FOLLOW_BIND_in_simpleBind396); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_simpleBind400); 
                    	PushFollow(FOLLOW_command_in_simpleBind404);
                    	c = command();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 id1 = ((i1 != null) ? i1.Text : null); statList.Add(c); 

                    }
                    break;

            }
             simpleBind = new Bind(id1, statList, StatementType.Bind, currentMetaData); 
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return simpleBind;
    }
    // $ANTLR end "simpleBind"


    // $ANTLR start "increment"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:81:1: increment : ^( INCREMENT ID ID ID ID ) ;
    public void increment() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:82:2: ( ^( INCREMENT ID ID ID ID ) )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:82:4: ^( INCREMENT ID ID ID ID )
            {
            	Match(input,INCREMENT,FOLLOW_INCREMENT_in_increment419); 

            	Match(input, Token.DOWN, null); 
            	Match(input,ID,FOLLOW_ID_in_increment421); 
            	Match(input,ID,FOLLOW_ID_in_increment423); 
            	Match(input,ID,FOLLOW_ID_in_increment425); 
            	Match(input,ID,FOLLOW_ID_in_increment427); 

            	Match(input, Token.UP, null); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "increment"


    // $ANTLR start "exec"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:86:1: exec returns [Exec exec] : ( ^( EXEC i1= ID ) | ^( EXEC i1= ID RCON ) );
    public Exec exec() // throws RecognitionException [1]
    {   
        Exec exec = default(Exec);

        CommonTree i1 = null;

         string id1 = null;  bool rcon=false; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:89:2: ( ^( EXEC i1= ID ) | ^( EXEC i1= ID RCON ) )
            int alt10 = 2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0 == EXEC) )
            {
                int LA10_1 = input.LA(2);

                if ( (LA10_1 == DOWN) )
                {
                    int LA10_2 = input.LA(3);

                    if ( (LA10_2 == ID) )
                    {
                        int LA10_3 = input.LA(4);

                        if ( (LA10_3 == UP) )
                        {
                            alt10 = 1;
                        }
                        else if ( (LA10_3 == RCON) )
                        {
                            alt10 = 2;
                        }
                        else 
                        {
                            NoViableAltException nvae_d10s3 =
                                new NoViableAltException("", 10, 3, input);

                            throw nvae_d10s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d10s2 =
                            new NoViableAltException("", 10, 2, input);

                        throw nvae_d10s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d10s1 =
                        new NoViableAltException("", 10, 1, input);

                    throw nvae_d10s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d10s0 =
                    new NoViableAltException("", 10, 0, input);

                throw nvae_d10s0;
            }
            switch (alt10) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:89:4: ^( EXEC i1= ID )
                    {
                    	Match(input,EXEC,FOLLOW_EXEC_in_exec456); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_exec460); 

                    	Match(input, Token.UP, null); 
                    	id1=((i1 != null) ? i1.Text : null);

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:90:4: ^( EXEC i1= ID RCON )
                    {
                    	Match(input,EXEC,FOLLOW_EXEC_in_exec469); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_exec473); 
                    	Match(input,RCON,FOLLOW_RCON_in_exec475); 

                    	Match(input, Token.UP, null); 
                    	id1=((i1 != null) ? i1.Text : null); rcon=true;

                    }
                    break;

            }
             exec = new Exec(id1, StatementType.Exec, currentMetaData, rcon); 
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return exec;
    }
    // $ANTLR end "exec"


    // $ANTLR start "command"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:93:1: command returns [Command command] : ( ^( COMMAND ID ) | ^( COMMAND i1= ID i2= ID ) | ^( COMMAND i1= ID i2= ID RCON ) );
    public Command command() // throws RecognitionException [1]
    {   
        Command command = default(Command);

        CommonTree i1 = null;
        CommonTree i2 = null;
        CommonTree ID3 = null;

         string id1 = null; string id2 = null;  bool rcon=false; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:97:2: ( ^( COMMAND ID ) | ^( COMMAND i1= ID i2= ID ) | ^( COMMAND i1= ID i2= ID RCON ) )
            int alt11 = 3;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == COMMAND) )
            {
                int LA11_1 = input.LA(2);

                if ( (LA11_1 == DOWN) )
                {
                    int LA11_2 = input.LA(3);

                    if ( (LA11_2 == ID) )
                    {
                        int LA11_3 = input.LA(4);

                        if ( (LA11_3 == UP) )
                        {
                            alt11 = 1;
                        }
                        else if ( (LA11_3 == ID) )
                        {
                            int LA11_5 = input.LA(5);

                            if ( (LA11_5 == UP) )
                            {
                                alt11 = 2;
                            }
                            else if ( (LA11_5 == RCON) )
                            {
                                alt11 = 3;
                            }
                            else 
                            {
                                NoViableAltException nvae_d11s5 =
                                    new NoViableAltException("", 11, 5, input);

                                throw nvae_d11s5;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d11s3 =
                                new NoViableAltException("", 11, 3, input);

                            throw nvae_d11s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d11s2 =
                            new NoViableAltException("", 11, 2, input);

                        throw nvae_d11s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d11s1 =
                        new NoViableAltException("", 11, 1, input);

                    throw nvae_d11s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:97:4: ^( COMMAND ID )
                    {
                    	Match(input,COMMAND,FOLLOW_COMMAND_in_command506); 

                    	Match(input, Token.DOWN, null); 
                    	ID3=(CommonTree)Match(input,ID,FOLLOW_ID_in_command508); 

                    	Match(input, Token.UP, null); 
                    	 id1 = ((ID3 != null) ? ID3.Text : null); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:98:4: ^( COMMAND i1= ID i2= ID )
                    {
                    	Match(input,COMMAND,FOLLOW_COMMAND_in_command517); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_command521); 
                    	i2=(CommonTree)Match(input,ID,FOLLOW_ID_in_command525); 

                    	Match(input, Token.UP, null); 
                    	 id1 = ((i1 != null) ? i1.Text : null); id2=((i2 != null) ? i2.Text : null); 

                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:99:4: ^( COMMAND i1= ID i2= ID RCON )
                    {
                    	Match(input,COMMAND,FOLLOW_COMMAND_in_command534); 

                    	Match(input, Token.DOWN, null); 
                    	i1=(CommonTree)Match(input,ID,FOLLOW_ID_in_command538); 
                    	i2=(CommonTree)Match(input,ID,FOLLOW_ID_in_command542); 
                    	Match(input,RCON,FOLLOW_RCON_in_command544); 

                    	Match(input, Token.UP, null); 
                    	 id1 = ((i1 != null) ? i1.Text : null); id2=((i2 != null) ? i2.Text : null); rcon=true; 

                    }
                    break;

            }
             command = new Command(id1, id2, StatementType.Command, currentMetaData, rcon); 
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return command;
    }
    // $ANTLR end "command"


    // $ANTLR start "guiRule"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:102:1: guiRule : ^( META guiFields stat ) ;
    public void guiRule() // throws RecognitionException [1]
    {   
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:103:2: ( ^( META guiFields stat ) )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:103:4: ^( META guiFields stat )
            {
            	Match(input,META,FOLLOW_META_in_guiRule559); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_guiFields_in_guiRule561);
            	guiFields();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_stat_in_guiRule563);
            	stat();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "guiRule"

    protected class guiFields_scope 
    {
        protected internal bool first;
        protected internal int n;
        protected internal string metaType;
    }
    protected Stack guiFields_stack = new Stack();


    // $ANTLR start "guiFields"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:106:1: guiFields : ( guiField )+ ;
    public void guiFields() // throws RecognitionException [1]
    {   
        guiFields_stack.Push(new guiFields_scope());
         ((guiFields_scope)guiFields_stack.Peek()).first =  true; ((guiFields_scope)guiFields_stack.Peek()).n =  0; 
        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:110:2: ( ( guiField )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:110:4: ( guiField )+
            {
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:110:4: ( guiField )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == ID) && ((((guiFields_scope)guiFields_stack.Peek()).first)) )
            	    {
            	        alt12 = 1;
            	    }
            	    else if ( ((LA12_0 >= METAINT && LA12_0 <= METATEXT)) && ((((guiFields_scope)guiFields_stack.Peek()).first==false)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:110:5: guiField
            			    {
            			    	PushFollow(FOLLOW_guiField_in_guiFields589);
            			    	guiField();
            			    	state.followingStackPointer--;

            			    	((guiFields_scope)guiFields_stack.Peek()).n++;

            			    }
            			    break;

            			default:
            			    if ( cnt12 >= 1 ) goto loop12;
            		            EarlyExitException eee12 =
            		                new EarlyExitException(12, input);
            		            throw eee12;
            	    }
            	    cnt12++;
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            guiFields_stack.Pop();
        }
        return ;
    }
    // $ANTLR end "guiFields"


    // $ANTLR start "guiField"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:112:1: guiField : ({...}? =>id1= ID | {...}? => ( metaElement )+ );
    public void guiField() // throws RecognitionException [1]
    {   
        CommonTree id1 = null;

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:113:2: ({...}? =>id1= ID | {...}? => ( metaElement )+ )
            int alt14 = 2;
            int LA14_0 = input.LA(1);

            if ( (LA14_0 == ID) && ((((guiFields_scope)guiFields_stack.Peek()).first)) )
            {
                alt14 = 1;
            }
            else if ( ((LA14_0 >= METAINT && LA14_0 <= METATEXT)) && ((((guiFields_scope)guiFields_stack.Peek()).first==false)) )
            {
                alt14 = 2;
            }
            else 
            {
                NoViableAltException nvae_d14s0 =
                    new NoViableAltException("", 14, 0, input);

                throw nvae_d14s0;
            }
            switch (alt14) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:113:4: {...}? =>id1= ID
                    {
                    	if ( !((((guiFields_scope)guiFields_stack.Peek()).first)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "guiField", "$guiFields::first");
                    	}
                    	id1=(CommonTree)Match(input,ID,FOLLOW_ID_in_guiField611); 
                    	((guiFields_scope)guiFields_stack.Peek()).metaType = ((id1 != null) ? id1.Text : null); 
                    				((guiFields_scope)guiFields_stack.Peek()).first =  false;
                    				currentMetaData = new MetaData<IMeta>(_script.SupportedMetaData[((guiFields_scope)guiFields_stack.Peek()).metaType]);
                    				currentMetaData.MetaInfo.AddMetaField(((guiFields_scope)guiFields_stack.Peek()).n, ((id1 != null) ? id1.Text : null)); 
                    				

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:120:4: {...}? => ( metaElement )+
                    {
                    	if ( !((((guiFields_scope)guiFields_stack.Peek()).first==false)) ) 
                    	{
                    	    throw new FailedPredicateException(input, "guiField", "$guiFields::first==false");
                    	}
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:120:33: ( metaElement )+
                    	int cnt13 = 0;
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( (LA13_0 == METAINT) )
                    	    {
                    	        alt13 = 1;
                    	    }
                    	    else if ( (LA13_0 == METATEXT) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:120:34: metaElement
                    			    {
                    			    	PushFollow(FOLLOW_metaElement_in_guiField624);
                    			    	metaElement();
                    			    	state.followingStackPointer--;

                    			    	((guiFields_scope)guiFields_stack.Peek()).n++;

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt13 >= 1 ) goto loop13;
                    		            EarlyExitException eee13 =
                    		                new EarlyExitException(13, input);
                    		            throw eee13;
                    	    }
                    	    cnt13++;
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "guiField"


    // $ANTLR start "metaElement"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:123:1: metaElement : ( ^( METAINT int1= INT ) | ^( METATEXT (id1= ID )+ ) );
    public void metaElement() // throws RecognitionException [1]
    {   
        CommonTree int1 = null;
        CommonTree id1 = null;

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:124:2: ( ^( METAINT int1= INT ) | ^( METATEXT (id1= ID )+ ) )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == METAINT) )
            {
                alt16 = 1;
            }
            else if ( (LA16_0 == METATEXT) )
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
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:124:4: ^( METAINT int1= INT )
                    {
                    	Match(input,METAINT,FOLLOW_METAINT_in_metaElement640); 

                    	Match(input, Token.DOWN, null); 
                    	int1=(CommonTree)Match(input,INT,FOLLOW_INT_in_metaElement644); 

                    	Match(input, Token.UP, null); 
                    	currentMetaData.MetaInfo.AddMetaField(((guiFields_scope)guiFields_stack.Peek()).n, (int1!=null?int.Parse(int1.Text):0)); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:125:4: ^( METATEXT (id1= ID )+ )
                    {
                    	string metaText = String.Empty;
                    	Match(input,METATEXT,FOLLOW_METATEXT_in_metaElement657); 

                    	Match(input, Token.DOWN, null); 
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:126:14: (id1= ID )+
                    	int cnt15 = 0;
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( (LA15_0 == ID) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceEval.g:126:15: id1= ID
                    			    {
                    			    	id1=(CommonTree)Match(input,ID,FOLLOW_ID_in_metaElement662); 
                    			    	metaText+=" " + id1;

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt15 >= 1 ) goto loop15;
                    		            EarlyExitException eee15 =
                    		                new EarlyExitException(15, input);
                    		            throw eee15;
                    	    }
                    	    cnt15++;
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements


                    	Match(input, Token.UP, null); 
                    	currentMetaData.MetaInfo.AddMetaField(((guiFields_scope)guiFields_stack.Peek()).n, metaText); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "metaElement"

    // Delegated rules


   	protected DFA4 dfa4;
   	protected DFA6 dfa6;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
    	this.dfa6 = new DFA6(this);
	}

    const string DFA4_eotS =
        "\x0f\uffff";
    const string DFA4_eofS =
        "\x0f\uffff";
    const string DFA4_minS =
        "\x01\x04\x01\x02\x01\x10\x01\x03\x01\uffff\x01\x02\x01\uffff\x01"+
        "\x10\x03\x03\x01\uffff\x03\x03";
    const string DFA4_maxS =
        "\x01\x04\x01\x02\x01\x10\x01\x0c\x01\uffff\x01\x02\x01\uffff\x02"+
        "\x10\x01\x0c\x01\x07\x01\uffff\x01\x0c\x01\x03\x01\x0c";
    const string DFA4_acceptS =
        "\x04\uffff\x01\x02\x01\uffff\x01\x01\x04\uffff\x01\x01\x03\uffff";
    const string DFA4_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01",
            "\x01\x02",
            "\x01\x03",
            "\x01\x04\x03\x06\x01\uffff\x03\x06\x01\uffff\x01\x05",
            "",
            "\x01\x07",
            "",
            "\x01\x08",
            "\x01\x09\x0c\uffff\x01\x0a",
            "\x01\x0b\x01\x06\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0b",
            "\x01\x0c\x03\uffff\x01\x0d",
            "",
            "\x01\x0b\x01\x06\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0b",
            "\x01\x0e",
            "\x01\x0b\x01\x06\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0b"
    };

    static readonly short[] DFA4_eot = DFA.UnpackEncodedString(DFA4_eotS);
    static readonly short[] DFA4_eof = DFA.UnpackEncodedString(DFA4_eofS);
    static readonly char[] DFA4_min = DFA.UnpackEncodedStringToUnsignedChars(DFA4_minS);
    static readonly char[] DFA4_max = DFA.UnpackEncodedStringToUnsignedChars(DFA4_maxS);
    static readonly short[] DFA4_accept = DFA.UnpackEncodedString(DFA4_acceptS);
    static readonly short[] DFA4_special = DFA.UnpackEncodedString(DFA4_specialS);
    static readonly short[][] DFA4_transition = DFA.UnpackEncodedStringArray(DFA4_transitionS);

    protected class DFA4 : DFA
    {
        public DFA4(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 4;
            this.eot = DFA4_eot;
            this.eof = DFA4_eof;
            this.min = DFA4_min;
            this.max = DFA4_max;
            this.accept = DFA4_accept;
            this.special = DFA4_special;
            this.transition = DFA4_transition;

        }

        override public string Description
        {
            get { return "38:1: alias returns [Alias alias] : ( ^( ALIAS ID (id= innerStat )+ ) | sA= simpleAlias );"; }
        }

    }

    const string DFA6_eotS =
        "\x0f\uffff";
    const string DFA6_eofS =
        "\x0f\uffff";
    const string DFA6_minS =
        "\x01\x05\x01\x02\x01\x10\x01\x03\x02\uffff\x01\x02\x01\x10\x03"+
        "\x03\x01\uffff\x03\x03";
    const string DFA6_maxS =
        "\x01\x05\x01\x02\x01\x10\x01\x0c\x02\uffff\x01\x02\x02\x10\x01"+
        "\x0c\x01\x07\x01\uffff\x01\x0c\x01\x03\x01\x0c";
    const string DFA6_acceptS =
        "\x04\uffff\x01\x02\x01\x01\x05\uffff\x01\x01\x03\uffff";
    const string DFA6_specialS =
        "\x0f\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x01",
            "\x01\x02",
            "\x01\x03",
            "\x01\x04\x03\x05\x01\uffff\x03\x05\x01\uffff\x01\x06",
            "",
            "",
            "\x01\x07",
            "\x01\x08",
            "\x01\x09\x0c\uffff\x01\x0a",
            "\x01\x0b\x01\x05\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0b",
            "\x01\x0c\x03\uffff\x01\x0d",
            "",
            "\x01\x0b\x01\x05\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0b",
            "\x01\x0e",
            "\x01\x0b\x01\x05\x02\x0b\x01\uffff\x03\x0b\x01\uffff\x01\x0b"
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "46:1: bind returns [Bind bind] : ( ^( BIND ID (id= innerStat )+ ) | sB= simpleBind );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_guiRule_in_prog66 = new BitSet(new ulong[]{0x0000000000001F72UL});
    public static readonly BitSet FOLLOW_stat_in_prog70 = new BitSet(new ulong[]{0x0000000000001F72UL});
    public static readonly BitSet FOLLOW_alias_in_stat87 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bind_in_stat96 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exec_in_stat105 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_command_in_stat115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_increment_in_stat122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_stat127 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAY_in_stat132 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_alias157 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_alias159 = new BitSet(new ulong[]{0x0000000000001770UL});
    public static readonly BitSet FOLLOW_innerStat_in_alias165 = new BitSet(new ulong[]{0x0000000000001778UL});
    public static readonly BitSet FOLLOW_simpleAlias_in_alias184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIND_in_bind209 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_bind211 = new BitSet(new ulong[]{0x0000000000001770UL});
    public static readonly BitSet FOLLOW_innerStat_in_bind217 = new BitSet(new ulong[]{0x0000000000001778UL});
    public static readonly BitSet FOLLOW_simpleBind_in_bind235 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleAlias_in_innerStat255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_simpleBind_in_innerStat264 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_command_in_innerStat273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_increment_in_innerStat280 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exec_in_innerStat289 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ECHO_in_innerStat296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SAY_in_innerStat301 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ALIAS_in_simpleAlias330 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_simpleAlias334 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ALIAS_in_simpleAlias343 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_simpleAlias347 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_command_in_simpleAlias351 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BIND_in_simpleBind383 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_simpleBind387 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BIND_in_simpleBind396 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_simpleBind400 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_command_in_simpleBind404 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_increment419 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_increment421 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_increment423 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_increment425 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_increment427 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXEC_in_exec456 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_exec460 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXEC_in_exec469 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_exec473 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RCON_in_exec475 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_COMMAND_in_command506 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_command508 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_COMMAND_in_command517 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_command521 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_command525 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_COMMAND_in_command534 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_command538 = new BitSet(new ulong[]{0x0000000000010000UL});
    public static readonly BitSet FOLLOW_ID_in_command542 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_RCON_in_command544 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_META_in_guiRule559 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_guiFields_in_guiRule561 = new BitSet(new ulong[]{0x0000000000001F78UL});
    public static readonly BitSet FOLLOW_stat_in_guiRule563 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_guiField_in_guiFields589 = new BitSet(new ulong[]{0x0000000000016002UL});
    public static readonly BitSet FOLLOW_ID_in_guiField611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_metaElement_in_guiField624 = new BitSet(new ulong[]{0x0000000000016002UL});
    public static readonly BitSet FOLLOW_METAINT_in_metaElement640 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_INT_in_metaElement644 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_METATEXT_in_metaElement657 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_metaElement662 = new BitSet(new ulong[]{0x0000000000010008UL});

}
