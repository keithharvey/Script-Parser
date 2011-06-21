// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g 2011-06-13 07:46:01

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


using Antlr.StringTemplate;
using Antlr.StringTemplate.Language;
using Hashtable = System.Collections.Hashtable;
public partial class SourceRewrite : TreeParser
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
		"ECHO", 
		"RCON", 
		"INCREMENT", 
		"COMMAND", 
		"METADATA", 
		"LINEBREAK", 
		"SAY", 
		"ID", 
		"SL_COMMENT", 
		"WS", 
		"CHARACTER", 
		"'\"'", 
		"';'", 
		"'\n'", 
		"'\r'"
    };

    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int EXEC = 6;
    public const int ID = 14;
    public const int EOF = -1;
    public const int SAY = 13;
    public const int CHARACTER = 17;
    public const int COMMAND = 10;
    public const int T__19 = 19;
    public const int INCREMENT = 9;
    public const int ECHO = 7;
    public const int WS = 16;
    public const int T__18 = 18;
    public const int BIND = 5;
    public const int SL_COMMENT = 15;
    public const int ALIAS = 4;
    public const int METADATA = 11;
    public const int LINEBREAK = 12;
    public const int RCON = 8;

    // delegates
    // delegators



        public SourceRewrite(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SourceRewrite(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected StringTemplateGroup templateLib =
      new StringTemplateGroup("SourceRewriteTemplates", typeof(AngleBracketTemplateLexer));

    public StringTemplateGroup TemplateLib
    {
     	get { return this.templateLib; }
     	set { this.templateLib = value; }
    }

    /// <summary> Allows convenient multi-value initialization:
    ///  "new STAttrMap().Add(...).Add(...)"
    /// </summary>
    protected class STAttrMap : Hashtable
    {
      public STAttrMap Add(string attrName, object value) 
      {
        base.Add(attrName, value);
        return this;
      }
      public STAttrMap Add(string attrName, int value) 
      {
        base.Add(attrName, value);
        return this;
      }
    }

    override public string[] TokenNames {
		get { return SourceRewrite.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g"; }
    }


    	Script _script = new Script("Temporary");
    	Command _commandReplacement;
    	
    	bool _defaultReached = false;


    public class prog_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "prog"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:23:1: prog[Script script] : ( stat )+ ;
    public SourceRewrite.prog_return prog(Script script) // throws RecognitionException [1]
    {   
        SourceRewrite.prog_return retval = new SourceRewrite.prog_return();
        retval.Start = input.LT(1);


        	_script = script;
        	/*foreach(ToggleAlias toggleAlias in _script.ToggleAliases)
        	{
        		toggleAlias.ResetNumberOfDefaultChecks();
        	}*/

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:32:2: ( ( stat )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:32:5: ( stat )+
            {
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:32:5: ( stat )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= ALIAS && LA1_0 <= EXEC) || (LA1_0 >= INCREMENT && LA1_0 <= COMMAND)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:32:5: stat
            			    {
            			    	PushFollow(FOLLOW_stat_in_prog69);
            			    	stat();
            			    	state.followingStackPointer--;


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
        return retval;
    }
    // $ANTLR end "prog"

    public class stat_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "stat"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:34:1: stat : ( ^( ALIAS ID ( innerStat )* ) | ^( EXEC ID ) | ^( BIND ID ( innerStat )* ) | ^( INCREMENT ID ID ID ID ) | ^( COMMAND ID ID ) | ^( COMMAND ID ) -> {_defaultReached}? template(id=_commandReplacement.Name) \"<id>\" -> template(same=$ID.text) \"<same>\");
    public SourceRewrite.stat_return stat() // throws RecognitionException [1]
    {   
        SourceRewrite.stat_return retval = new SourceRewrite.stat_return();
        retval.Start = input.LT(1);

        CommonTree ID1 = null;


        	_defaultReached = false;
        	_commandReplacement = null;

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:40:2: ( ^( ALIAS ID ( innerStat )* ) | ^( EXEC ID ) | ^( BIND ID ( innerStat )* ) | ^( INCREMENT ID ID ID ID ) | ^( COMMAND ID ID ) | ^( COMMAND ID ) -> {_defaultReached}? template(id=_commandReplacement.Name) \"<id>\" -> template(same=$ID.text) \"<same>\")
            int alt4 = 6;
            alt4 = dfa4.Predict(input);
            switch (alt4) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:40:4: ^( ALIAS ID ( innerStat )* )
                    {
                    	Match(input,ALIAS,FOLLOW_ALIAS_in_stat86); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_stat88); 
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:40:15: ( innerStat )*
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= ALIAS && LA2_0 <= EXEC) || (LA2_0 >= INCREMENT && LA2_0 <= COMMAND)) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:40:15: innerStat
                    			    {
                    			    	PushFollow(FOLLOW_innerStat_in_stat90);
                    			    	innerStat();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    goto loop2;
                    	    }
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:41:4: ^( EXEC ID )
                    {
                    	Match(input,EXEC,FOLLOW_EXEC_in_stat98); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_stat100); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:42:4: ^( BIND ID ( innerStat )* )
                    {
                    	Match(input,BIND,FOLLOW_BIND_in_stat107); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_stat109); 
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:42:14: ( innerStat )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= ALIAS && LA3_0 <= EXEC) || (LA3_0 >= INCREMENT && LA3_0 <= COMMAND)) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:42:14: innerStat
                    			    {
                    			    	PushFollow(FOLLOW_innerStat_in_stat111);
                    			    	innerStat();
                    			    	state.followingStackPointer--;


                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:43:4: ^( INCREMENT ID ID ID ID )
                    {
                    	Match(input,INCREMENT,FOLLOW_INCREMENT_in_stat120); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_stat122); 
                    	Match(input,ID,FOLLOW_ID_in_stat124); 
                    	Match(input,ID,FOLLOW_ID_in_stat126); 
                    	Match(input,ID,FOLLOW_ID_in_stat128); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 5 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:44:4: ^( COMMAND ID ID )
                    {
                    	Match(input,COMMAND,FOLLOW_COMMAND_in_stat135); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_stat137); 
                    	Match(input,ID,FOLLOW_ID_in_stat139); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 6 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:45:4: ^( COMMAND ID )
                    {
                    	Match(input,COMMAND,FOLLOW_COMMAND_in_stat146); 

                    	Match(input, Token.DOWN, null); 
                    	ID1=(CommonTree)Match(input,ID,FOLLOW_ID_in_stat148); 

                    	Match(input, Token.UP, null); 

                    				/*Command tempCommand = new Command(((ID1 != null) ? ID1.Text : null));
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
                    			


                    	// TEMPLATE REWRITE
                    	// 62:3: -> {_defaultReached}? template(id=_commandReplacement.Name) \"<id>\"
                    	
                    	((TokenRewriteStream)input.TokenStream).Replace(
                    	  input.TreeAdaptor.GetTokenStartIndex(retval.Start),
                    	  input.TreeAdaptor.GetTokenStopIndex(retval.Start),
                    	  retval.ST);
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
        return retval;
    }
    // $ANTLR end "stat"

    public class innerStat_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "innerStat"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:67:1: innerStat : ( ^( ALIAS ID ( innerCommand )? ) | ^( EXEC ID ) | ^( BIND ID ( innerStat )? ) | ^( INCREMENT ID ID ID ID ) | innerCommand );
    public SourceRewrite.innerStat_return innerStat() // throws RecognitionException [1]
    {   
        SourceRewrite.innerStat_return retval = new SourceRewrite.innerStat_return();
        retval.Start = input.LT(1);

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:68:2: ( ^( ALIAS ID ( innerCommand )? ) | ^( EXEC ID ) | ^( BIND ID ( innerStat )? ) | ^( INCREMENT ID ID ID ID ) | innerCommand )
            int alt7 = 5;
            switch ( input.LA(1) ) 
            {
            case ALIAS:
            	{
                alt7 = 1;
                }
                break;
            case EXEC:
            	{
                alt7 = 2;
                }
                break;
            case BIND:
            	{
                alt7 = 3;
                }
                break;
            case INCREMENT:
            	{
                alt7 = 4;
                }
                break;
            case COMMAND:
            	{
                alt7 = 5;
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
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:68:4: ^( ALIAS ID ( innerCommand )? )
                    {
                    	Match(input,ALIAS,FOLLOW_ALIAS_in_innerStat195); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_innerStat197); 
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:68:15: ( innerCommand )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == COMMAND) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:68:15: innerCommand
                    	        {
                    	        	PushFollow(FOLLOW_innerCommand_in_innerStat199);
                    	        	innerCommand();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:69:4: ^( EXEC ID )
                    {
                    	Match(input,EXEC,FOLLOW_EXEC_in_innerStat207); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_innerStat209); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:70:4: ^( BIND ID ( innerStat )? )
                    {
                    	Match(input,BIND,FOLLOW_BIND_in_innerStat216); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_innerStat218); 
                    	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:70:14: ( innerStat )?
                    	int alt6 = 2;
                    	int LA6_0 = input.LA(1);

                    	if ( ((LA6_0 >= ALIAS && LA6_0 <= EXEC) || (LA6_0 >= INCREMENT && LA6_0 <= COMMAND)) )
                    	{
                    	    alt6 = 1;
                    	}
                    	switch (alt6) 
                    	{
                    	    case 1 :
                    	        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:70:14: innerStat
                    	        {
                    	        	PushFollow(FOLLOW_innerStat_in_innerStat220);
                    	        	innerStat();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:71:4: ^( INCREMENT ID ID ID ID )
                    {
                    	Match(input,INCREMENT,FOLLOW_INCREMENT_in_innerStat228); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_innerStat230); 
                    	Match(input,ID,FOLLOW_ID_in_innerStat232); 
                    	Match(input,ID,FOLLOW_ID_in_innerStat234); 
                    	Match(input,ID,FOLLOW_ID_in_innerStat236); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 5 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:72:4: innerCommand
                    {
                    	PushFollow(FOLLOW_innerCommand_in_innerStat242);
                    	innerCommand();
                    	state.followingStackPointer--;


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
        return retval;
    }
    // $ANTLR end "innerStat"

    public class innerCommand_return : TreeRuleReturnScope
    {
        private StringTemplate st;
        public StringTemplate ST    { get { return st; } set { st = value; } }
        public override object Template 		{ get { return st; } }
        public override string ToString() 		{ return (st == null) ? null : st.ToString(); }
    };

    // $ANTLR start "innerCommand"
    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:74:1: innerCommand : ( ^( COMMAND ID ) | ^( COMMAND ID ID ) );
    public SourceRewrite.innerCommand_return innerCommand() // throws RecognitionException [1]
    {   
        SourceRewrite.innerCommand_return retval = new SourceRewrite.innerCommand_return();
        retval.Start = input.LT(1);

        try 
    	{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:75:2: ( ^( COMMAND ID ) | ^( COMMAND ID ID ) )
            int alt8 = 2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == COMMAND) )
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
                        else if ( (LA8_3 == ID) )
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
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:75:4: ^( COMMAND ID )
                    {
                    	Match(input,COMMAND,FOLLOW_COMMAND_in_innerCommand252); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_innerCommand254); 

                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceRewrite.g:76:4: ^( COMMAND ID ID )
                    {
                    	Match(input,COMMAND,FOLLOW_COMMAND_in_innerCommand261); 

                    	Match(input, Token.DOWN, null); 
                    	Match(input,ID,FOLLOW_ID_in_innerCommand263); 
                    	Match(input,ID,FOLLOW_ID_in_innerCommand265); 

                    	Match(input, Token.UP, null); 

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
        return retval;
    }
    // $ANTLR end "innerCommand"

    // Delegated rules


   	protected DFA4 dfa4;
	private void InitializeCyclicDFAs()
	{
    	this.dfa4 = new DFA4(this);
	}

    const string DFA4_eotS =
        "\x0a\uffff";
    const string DFA4_eofS =
        "\x0a\uffff";
    const string DFA4_minS =
        "\x01\x04\x04\uffff\x01\x02\x01\x0e\x01\x03\x02\uffff";
    const string DFA4_maxS =
        "\x01\x0a\x04\uffff\x01\x02\x02\x0e\x02\uffff";
    const string DFA4_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x03\uffff\x01\x05\x01"+
        "\x06";
    const string DFA4_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA4_transitionS = {
            "\x01\x01\x01\x03\x01\x02\x02\uffff\x01\x04\x01\x05",
            "",
            "",
            "",
            "",
            "\x01\x06",
            "\x01\x07",
            "\x01\x09\x0a\uffff\x01\x08",
            "",
            ""
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
            get { return "34:1: stat : ( ^( ALIAS ID ( innerStat )* ) | ^( EXEC ID ) | ^( BIND ID ( innerStat )* ) | ^( INCREMENT ID ID ID ID ) | ^( COMMAND ID ID ) | ^( COMMAND ID ) -> {_defaultReached}? template(id=_commandReplacement.Name) \"<id>\" -> template(same=$ID.text) \"<same>\");"; }
        }

    }

 

    public static readonly BitSet FOLLOW_stat_in_prog69 = new BitSet(new ulong[]{0x0000000000000672UL});
    public static readonly BitSet FOLLOW_ALIAS_in_stat86 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat88 = new BitSet(new ulong[]{0x0000000000000678UL});
    public static readonly BitSet FOLLOW_innerStat_in_stat90 = new BitSet(new ulong[]{0x0000000000000678UL});
    public static readonly BitSet FOLLOW_EXEC_in_stat98 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat100 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BIND_in_stat107 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat109 = new BitSet(new ulong[]{0x0000000000000678UL});
    public static readonly BitSet FOLLOW_innerStat_in_stat111 = new BitSet(new ulong[]{0x0000000000000678UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_stat120 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat122 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_stat124 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_stat126 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_stat128 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_COMMAND_in_stat135 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat137 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_stat139 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_COMMAND_in_stat146 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_stat148 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ALIAS_in_innerStat195 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat197 = new BitSet(new ulong[]{0x0000000000000678UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat199 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXEC_in_innerStat207 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat209 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BIND_in_innerStat216 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat218 = new BitSet(new ulong[]{0x0000000000000678UL});
    public static readonly BitSet FOLLOW_innerStat_in_innerStat220 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INCREMENT_in_innerStat228 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat230 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat232 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat234 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_innerStat236 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_innerCommand_in_innerStat242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMMAND_in_innerCommand252 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand254 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_COMMAND_in_innerCommand261 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand263 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_ID_in_innerCommand265 = new BitSet(new ulong[]{0x0000000000000008UL});

}
