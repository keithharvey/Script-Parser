// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g 2011-06-23 01:54:01

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class SourceExprLexer : Lexer {
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

    public SourceExprLexer() 
    {
		InitializeCyclicDFAs();
    }
    public SourceExprLexer(ICharStream input)
		: this(input, null) {
    }
    public SourceExprLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g";} 
    }

    // $ANTLR start "ALIAS"
    public void mALIAS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ALIAS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:7:7: ( 'alias' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:7:9: 'alias'
            {
            	Match("alias"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ALIAS"

    // $ANTLR start "BIND"
    public void mBIND() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BIND;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:8:6: ( 'bind' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:8:8: 'bind'
            {
            	Match("bind"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BIND"

    // $ANTLR start "EXEC"
    public void mEXEC() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EXEC;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:9:6: ( 'exec' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:9:8: 'exec'
            {
            	Match("exec"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EXEC"

    // $ANTLR start "RCON"
    public void mRCON() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = RCON;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:10:6: ( 'rcon' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:10:8: 'rcon'
            {
            	Match("rcon"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "RCON"

    // $ANTLR start "INCREMENT"
    public void mINCREMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INCREMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:11:11: ( 'incrementvar' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:11:13: 'incrementvar'
            {
            	Match("incrementvar"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INCREMENT"

    // $ANTLR start "ECHO"
    public void mECHO() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ECHO;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:12:6: ( 'echo' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:12:8: 'echo'
            {
            	Match("echo"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ECHO"

    // $ANTLR start "SAY"
    public void mSAY() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SAY;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:13:5: ( 'say' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:13:7: 'say'
            {
            	Match("say"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SAY"

    // $ANTLR start "META"
    public void mMETA() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = META;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:14:6: ( '//#' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:14:8: '//#'
            {
            	Match("//#"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "META"

    // $ANTLR start "T__21"
    public void mT__21() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__21;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:15:7: ( '\"' )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:15:9: '\"'
            {
            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "LINEBREAK"
    public void mLINEBREAK() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LINEBREAK;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:118:2: ( ';' | '\\r\\n' | '\\r' | '\\n' )
            int alt1 = 4;
            switch ( input.LA(1) ) 
            {
            case ';':
            	{
                alt1 = 1;
                }
                break;
            case '\r':
            	{
                int LA1_2 = input.LA(2);

                if ( (LA1_2 == '\n') )
                {
                    alt1 = 2;
                }
                else 
                {
                    alt1 = 3;}
                }
                break;
            case '\n':
            	{
                alt1 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            }

            switch (alt1) 
            {
                case 1 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:118:4: ';'
                    {
                    	Match(';'); 

                    }
                    break;
                case 2 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:119:4: '\\r\\n'
                    {
                    	Match("\r\n"); 


                    }
                    break;
                case 3 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:120:4: '\\r'
                    {
                    	Match('\r'); 

                    }
                    break;
                case 4 :
                    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:121:4: '\\n'
                    {
                    	Match('\n'); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "LINEBREAK"

    // $ANTLR start "INT"
    public void mINT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = INT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:123:5: ( ( options {greedy=false; } : '0' .. '9' ) )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:123:7: ( options {greedy=false; } : '0' .. '9' )
            {
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:123:7: ( options {greedy=false; } : '0' .. '9' )
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:123:36: '0' .. '9'
            	{
            		MatchRange('0','9'); 

            	}


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "INT"

    // $ANTLR start "ID"
    public void mID() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ID;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:126:5: ( ( CHARACTER )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:126:8: ( CHARACTER )+
            {
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:126:8: ( CHARACTER )+
            	int cnt2 = 0;
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= '\u0000' && LA2_0 <= '\b') || LA2_0 == '\u000B' || (LA2_0 >= '\u000E' && LA2_0 <= '\u001F') || LA2_0 == '!' || (LA2_0 >= '#' && LA2_0 <= ':') || (LA2_0 >= '<' && LA2_0 <= '\uFFFF')) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:126:8: CHARACTER
            			    {
            			    	mCHARACTER(); 

            			    }
            			    break;

            			default:
            			    if ( cnt2 >= 1 ) goto loop2;
            		            EarlyExitException eee2 =
            		                new EarlyExitException(2, input);
            		            throw eee2;
            	    }
            	    cnt2++;
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "CHARACTER"
    public void mCHARACTER() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:128:20: (~ ( '\"' | ';' | '\\r' | '\\n' | '\\r\\n' | ' ' | '\\t' | '\\u000C' ) )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:128:22: ~ ( '\"' | ';' | '\\r' | '\\n' | '\\r\\n' | ' ' | '\\t' | '\\u000C' )
            {
            	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\b') || input.LA(1) == '\u000B' || (input.LA(1) >= '\u000E' && input.LA(1) <= '\u001F') || input.LA(1) == '!' || (input.LA(1) >= '#' && input.LA(1) <= ':') || (input.LA(1) >= '<' && input.LA(1) <= '\uFFFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "CHARACTER"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:130:3: ( ( ' ' | '\\t' | '\\u000C' )+ )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:130:5: ( ' ' | '\\t' | '\\u000C' )+
            {
            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:130:5: ( ' ' | '\\t' | '\\u000C' )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == '\t' || LA3_0 == '\f' || LA3_0 == ' ') )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:
            			    {
            			    	if ( input.LA(1) == '\t' || input.LA(1) == '\f' || input.LA(1) == ' ' ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


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

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "SLINE_COMMENT"
    public void mSLINE_COMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SLINE_COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:132:15: ( '//' ~ '#' (~ ( '\\r' | '\\n' ) )* )
            // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:132:17: '//' ~ '#' (~ ( '\\r' | '\\n' ) )*
            {
            	Match("//"); 

            	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\"') || (input.LA(1) >= '$' && input.LA(1) <= '\uFFFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	// D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:132:27: (~ ( '\\r' | '\\n' ) )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( ((LA4_0 >= '\u0000' && LA4_0 <= '\t') || (LA4_0 >= '\u000B' && LA4_0 <= '\f') || (LA4_0 >= '\u000E' && LA4_0 <= '\uFFFF')) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:132:28: ~ ( '\\r' | '\\n' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements

            	 _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "SLINE_COMMENT"

    override public void mTokens() // throws RecognitionException 
    {
        // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:8: ( ALIAS | BIND | EXEC | RCON | INCREMENT | ECHO | SAY | META | T__21 | LINEBREAK | INT | ID | WS | SLINE_COMMENT )
        int alt5 = 14;
        alt5 = dfa5.Predict(input);
        switch (alt5) 
        {
            case 1 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:10: ALIAS
                {
                	mALIAS(); 

                }
                break;
            case 2 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:16: BIND
                {
                	mBIND(); 

                }
                break;
            case 3 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:21: EXEC
                {
                	mEXEC(); 

                }
                break;
            case 4 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:26: RCON
                {
                	mRCON(); 

                }
                break;
            case 5 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:31: INCREMENT
                {
                	mINCREMENT(); 

                }
                break;
            case 6 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:41: ECHO
                {
                	mECHO(); 

                }
                break;
            case 7 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:46: SAY
                {
                	mSAY(); 

                }
                break;
            case 8 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:50: META
                {
                	mMETA(); 

                }
                break;
            case 9 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:55: T__21
                {
                	mT__21(); 

                }
                break;
            case 10 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:61: LINEBREAK
                {
                	mLINEBREAK(); 

                }
                break;
            case 11 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:71: INT
                {
                	mINT(); 

                }
                break;
            case 12 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:75: ID
                {
                	mID(); 

                }
                break;
            case 13 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:78: WS
                {
                	mWS(); 

                }
                break;
            case 14 :
                // D:\\Documents\\Visual Studio 2010\\Projects\\Installer\\Installer\\Model\\DAL\\SourceExpr.g:1:81: SLINE_COMMENT
                {
                	mSLINE_COMMENT(); 

                }
                break;

        }

    }


    protected DFA5 dfa5;
	private void InitializeCyclicDFAs()
	{
	    this.dfa5 = new DFA5(this);
	    this.dfa5.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA5_SpecialStateTransition);
	}

    const string DFA5_eotS =
        "\x01\uffff\x07\x0b\x02\uffff\x01\x15\x02\uffff\x08\x0b\x01\uffff"+
        "\x06\x0b\x01\x26\x01\x27\x01\x0b\x01\uffff\x01\x0b\x01\x2a\x01\x2b"+
        "\x01\x2c\x01\x2d\x01\x0b\x02\uffff\x01\x0b\x01\x2f\x04\uffff\x01"+
        "\x0b\x01\uffff\x06\x0b\x01\x37\x01\uffff";
    const string DFA5_eofS =
        "\x38\uffff";
    const string DFA5_minS =
        "\x01\x00\x01\x6c\x01\x69\x02\x63\x01\x6e\x01\x61\x01\x2f\x02\uffff"+
        "\x01\x00\x02\uffff\x01\x69\x01\x6e\x01\x65\x01\x68\x01\x6f\x01\x63"+
        "\x01\x79\x01\x00\x01\uffff\x01\x61\x01\x64\x01\x63\x01\x6f\x01\x6e"+
        "\x01\x72\x03\x00\x01\uffff\x01\x73\x04\x00\x01\x65\x02\uffff\x02"+
        "\x00\x04\uffff\x01\x6d\x01\uffff\x01\x65\x01\x6e\x01\x74\x01\x76"+
        "\x01\x61\x01\x72\x01\x00\x01\uffff";
    const string DFA5_maxS =
        "\x01\uffff\x01\x6c\x01\x69\x01\x78\x01\x63\x01\x6e\x01\x61\x01"+
        "\x2f\x02\uffff\x01\uffff\x02\uffff\x01\x69\x01\x6e\x01\x65\x01\x68"+
        "\x01\x6f\x01\x63\x01\x79\x01\uffff\x01\uffff\x01\x61\x01\x64\x01"+
        "\x63\x01\x6f\x01\x6e\x01\x72\x03\uffff\x01\uffff\x01\x73\x04\uffff"+
        "\x01\x65\x02\uffff\x02\uffff\x04\uffff\x01\x6d\x01\uffff\x01\x65"+
        "\x01\x6e\x01\x74\x01\x76\x01\x61\x01\x72\x01\uffff\x01\uffff";
    const string DFA5_acceptS =
        "\x08\uffff\x01\x09\x01\x0a\x01\uffff\x01\x0c\x01\x0d\x08\uffff"+
        "\x01\x0b\x09\uffff\x01\x0e\x06\uffff\x01\x07\x01\x08\x02\uffff\x01"+
        "\x02\x01\x03\x01\x06\x01\x04\x01\uffff\x01\x01\x07\uffff\x01\x05";
    const string DFA5_specialS =
        "\x01\x08\x09\uffff\x01\x0c\x09\uffff\x01\x06\x07\uffff\x01\x04"+
        "\x01\x03\x01\x0a\x02\uffff\x01\x02\x01\x0b\x01\x05\x01\x09\x03\uffff"+
        "\x01\x01\x01\x00\x0c\uffff\x01\x07\x01\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x09\x0b\x01\x0c\x01\x09\x01\x0b\x01\x0c\x01\x09\x12\x0b\x01"+
            "\x0c\x01\x0b\x01\x08\x0c\x0b\x01\x07\x0a\x0a\x01\x0b\x01\x09"+
            "\x25\x0b\x01\x01\x01\x02\x02\x0b\x01\x03\x03\x0b\x01\x05\x08"+
            "\x0b\x01\x04\x01\x06\uff8c\x0b",
            "\x01\x0d",
            "\x01\x0e",
            "\x01\x10\x14\uffff\x01\x0f",
            "\x01\x11",
            "\x01\x12",
            "\x01\x13",
            "\x01\x14",
            "",
            "",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "",
            "",
            "\x01\x16",
            "\x01\x17",
            "\x01\x18",
            "\x01\x19",
            "\x01\x1a",
            "\x01\x1b",
            "\x01\x1c",
            "\x09\x1e\x02\x1f\x01\x1e\x02\x1f\x12\x1e\x01\x1f\x01\x1e\x01"+
            "\x1f\x01\x1d\x17\x1e\x01\x1f\uffc4\x1e",
            "",
            "\x01\x20",
            "\x01\x21",
            "\x01\x22",
            "\x01\x23",
            "\x01\x24",
            "\x01\x25",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "\x09\x28\x01\x1f\x01\uffff\x01\x28\x01\x1f\x01\uffff\x12\x28"+
            "\x01\x1f\x01\x28\x01\x1f\x18\x28\x01\x1f\uffc4\x28",
            "",
            "\x01\x29",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "\x01\x2e",
            "",
            "",
            "\x09\x28\x01\x1f\x01\uffff\x01\x28\x01\x1f\x01\uffff\x12\x28"+
            "\x01\x1f\x01\x28\x01\x1f\x18\x28\x01\x1f\uffc4\x28",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            "",
            "",
            "",
            "",
            "\x01\x30",
            "",
            "\x01\x31",
            "\x01\x32",
            "\x01\x33",
            "\x01\x34",
            "\x01\x35",
            "\x01\x36",
            "\x09\x0b\x02\uffff\x01\x0b\x02\uffff\x12\x0b\x01\uffff\x01"+
            "\x0b\x01\uffff\x18\x0b\x01\uffff\uffc4\x0b",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( ALIAS | BIND | EXEC | RCON | INCREMENT | ECHO | SAY | META | T__21 | LINEBREAK | INT | ID | WS | SLINE_COMMENT );"; }
        }

    }


    protected internal int DFA5_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            IIntStream input = _input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA5_41 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_41 >= '\u0000' && LA5_41 <= '\b') || LA5_41 == '\u000B' || (LA5_41 >= '\u000E' && LA5_41 <= '\u001F') || LA5_41 == '!' || (LA5_41 >= '#' && LA5_41 <= ':') || (LA5_41 >= '<' && LA5_41 <= '\uFFFF')) ) { s = 11; }

                   	else s = 47;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA5_40 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_40 >= '\u0000' && LA5_40 <= '\b') || LA5_40 == '\u000B' || (LA5_40 >= '\u000E' && LA5_40 <= '\u001F') || LA5_40 == '!' || (LA5_40 >= '#' && LA5_40 <= ':') || (LA5_40 >= '<' && LA5_40 <= '\uFFFF')) ) { s = 40; }

                   	else if ( (LA5_40 == '\t' || LA5_40 == '\f' || LA5_40 == ' ' || LA5_40 == '\"' || LA5_40 == ';') ) { s = 31; }

                   	else s = 11;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA5_33 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_33 >= '\u0000' && LA5_33 <= '\b') || LA5_33 == '\u000B' || (LA5_33 >= '\u000E' && LA5_33 <= '\u001F') || LA5_33 == '!' || (LA5_33 >= '#' && LA5_33 <= ':') || (LA5_33 >= '<' && LA5_33 <= '\uFFFF')) ) { s = 11; }

                   	else s = 42;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA5_29 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_29 >= '\u0000' && LA5_29 <= '\b') || LA5_29 == '\u000B' || (LA5_29 >= '\u000E' && LA5_29 <= '\u001F') || LA5_29 == '!' || (LA5_29 >= '#' && LA5_29 <= ':') || (LA5_29 >= '<' && LA5_29 <= '\uFFFF')) ) { s = 11; }

                   	else s = 39;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA5_28 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_28 >= '\u0000' && LA5_28 <= '\b') || LA5_28 == '\u000B' || (LA5_28 >= '\u000E' && LA5_28 <= '\u001F') || LA5_28 == '!' || (LA5_28 >= '#' && LA5_28 <= ':') || (LA5_28 >= '<' && LA5_28 <= '\uFFFF')) ) { s = 11; }

                   	else s = 38;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA5_35 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_35 >= '\u0000' && LA5_35 <= '\b') || LA5_35 == '\u000B' || (LA5_35 >= '\u000E' && LA5_35 <= '\u001F') || LA5_35 == '!' || (LA5_35 >= '#' && LA5_35 <= ':') || (LA5_35 >= '<' && LA5_35 <= '\uFFFF')) ) { s = 11; }

                   	else s = 44;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA5_20 = input.LA(1);

                   	s = -1;
                   	if ( (LA5_20 == '#') ) { s = 29; }

                   	else if ( ((LA5_20 >= '\u0000' && LA5_20 <= '\b') || LA5_20 == '\u000B' || (LA5_20 >= '\u000E' && LA5_20 <= '\u001F') || LA5_20 == '!' || (LA5_20 >= '$' && LA5_20 <= ':') || (LA5_20 >= '<' && LA5_20 <= '\uFFFF')) ) { s = 30; }

                   	else if ( ((LA5_20 >= '\t' && LA5_20 <= '\n') || (LA5_20 >= '\f' && LA5_20 <= '\r') || LA5_20 == ' ' || LA5_20 == '\"' || LA5_20 == ';') ) { s = 31; }

                   	else s = 11;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA5_54 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_54 >= '\u0000' && LA5_54 <= '\b') || LA5_54 == '\u000B' || (LA5_54 >= '\u000E' && LA5_54 <= '\u001F') || LA5_54 == '!' || (LA5_54 >= '#' && LA5_54 <= ':') || (LA5_54 >= '<' && LA5_54 <= '\uFFFF')) ) { s = 11; }

                   	else s = 55;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA5_0 = input.LA(1);

                   	s = -1;
                   	if ( (LA5_0 == 'a') ) { s = 1; }

                   	else if ( (LA5_0 == 'b') ) { s = 2; }

                   	else if ( (LA5_0 == 'e') ) { s = 3; }

                   	else if ( (LA5_0 == 'r') ) { s = 4; }

                   	else if ( (LA5_0 == 'i') ) { s = 5; }

                   	else if ( (LA5_0 == 's') ) { s = 6; }

                   	else if ( (LA5_0 == '/') ) { s = 7; }

                   	else if ( (LA5_0 == '\"') ) { s = 8; }

                   	else if ( (LA5_0 == '\n' || LA5_0 == '\r' || LA5_0 == ';') ) { s = 9; }

                   	else if ( ((LA5_0 >= '0' && LA5_0 <= '9')) ) { s = 10; }

                   	else if ( ((LA5_0 >= '\u0000' && LA5_0 <= '\b') || LA5_0 == '\u000B' || (LA5_0 >= '\u000E' && LA5_0 <= '\u001F') || LA5_0 == '!' || (LA5_0 >= '#' && LA5_0 <= '.') || LA5_0 == ':' || (LA5_0 >= '<' && LA5_0 <= '`') || (LA5_0 >= 'c' && LA5_0 <= 'd') || (LA5_0 >= 'f' && LA5_0 <= 'h') || (LA5_0 >= 'j' && LA5_0 <= 'q') || (LA5_0 >= 't' && LA5_0 <= '\uFFFF')) ) { s = 11; }

                   	else if ( (LA5_0 == '\t' || LA5_0 == '\f' || LA5_0 == ' ') ) { s = 12; }

                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA5_36 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_36 >= '\u0000' && LA5_36 <= '\b') || LA5_36 == '\u000B' || (LA5_36 >= '\u000E' && LA5_36 <= '\u001F') || LA5_36 == '!' || (LA5_36 >= '#' && LA5_36 <= ':') || (LA5_36 >= '<' && LA5_36 <= '\uFFFF')) ) { s = 11; }

                   	else s = 45;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA5_30 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_30 >= '\u0000' && LA5_30 <= '\b') || LA5_30 == '\u000B' || (LA5_30 >= '\u000E' && LA5_30 <= '\u001F') || LA5_30 == '!' || (LA5_30 >= '#' && LA5_30 <= ':') || (LA5_30 >= '<' && LA5_30 <= '\uFFFF')) ) { s = 40; }

                   	else if ( (LA5_30 == '\t' || LA5_30 == '\f' || LA5_30 == ' ' || LA5_30 == '\"' || LA5_30 == ';') ) { s = 31; }

                   	else s = 11;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA5_34 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_34 >= '\u0000' && LA5_34 <= '\b') || LA5_34 == '\u000B' || (LA5_34 >= '\u000E' && LA5_34 <= '\u001F') || LA5_34 == '!' || (LA5_34 >= '#' && LA5_34 <= ':') || (LA5_34 >= '<' && LA5_34 <= '\uFFFF')) ) { s = 11; }

                   	else s = 43;

                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA5_10 = input.LA(1);

                   	s = -1;
                   	if ( ((LA5_10 >= '\u0000' && LA5_10 <= '\b') || LA5_10 == '\u000B' || (LA5_10 >= '\u000E' && LA5_10 <= '\u001F') || LA5_10 == '!' || (LA5_10 >= '#' && LA5_10 <= ':') || (LA5_10 >= '<' && LA5_10 <= '\uFFFF')) ) { s = 11; }

                   	else s = 21;

                   	if ( s >= 0 ) return s;
                   	break;
        }
        NoViableAltException nvae5 =
            new NoViableAltException(dfa.Description, 5, _s, input);
        dfa.Error(nvae5);
        throw nvae5;
    }
 
    
}
