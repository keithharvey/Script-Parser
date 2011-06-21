// $ANTLR 3.1.2 C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g 2009-06-27 14:36:58

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class SourceMetaExprLexer extends Lexer {
    public static final int SCRIPTNAME=17;
    public static final int T__28=28;
    public static final int KEY=20;
    public static final int ICON=24;
    public static final int WHITESPACE=13;
    public static final int EXEC=7;
    public static final int ID=16;
    public static final int EOF=-1;
    public static final int SEMI=15;
    public static final int META=8;
    public static final int SCRIPTINFO=12;
    public static final int CHARACTER=27;
    public static final int COMMAND=10;
    public static final int TYPE=11;
    public static final int ALTNAME=23;
    public static final int NAME=18;
    public static final int WS=26;
    public static final int DESCRIPTION=22;
    public static final int NEWLINE=14;
    public static final int BIND=5;
    public static final int SL_COMMENT=25;
    public static final int ALIAS=4;
    public static final int SUBKEY=21;
    public static final int TOGGLE=19;
    public static final int METADATA=9;
    public static final int RCON=6;

    // delegates
    // delegators

    public SourceMetaExprLexer() {;} 
    public SourceMetaExprLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public SourceMetaExprLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g"; }

    // $ANTLR start "ALIAS"
    public final void mALIAS() throws RecognitionException {
        try {
            int _type = ALIAS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:3:7: ( 'alias' )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:3:9: 'alias'
            {
            match("alias"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ALIAS"

    // $ANTLR start "BIND"
    public final void mBIND() throws RecognitionException {
        try {
            int _type = BIND;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:4:6: ( 'bind' )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:4:8: 'bind'
            {
            match("bind"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BIND"

    // $ANTLR start "RCON"
    public final void mRCON() throws RecognitionException {
        try {
            int _type = RCON;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:5:6: ( 'rcon' )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:5:8: 'rcon'
            {
            match("rcon"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "RCON"

    // $ANTLR start "EXEC"
    public final void mEXEC() throws RecognitionException {
        try {
            int _type = EXEC;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:6:6: ( 'exec' )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:6:8: 'exec'
            {
            match("exec"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "EXEC"

    // $ANTLR start "META"
    public final void mMETA() throws RecognitionException {
        try {
            int _type = META;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:7:6: ( '///' )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:7:8: '///'
            {
            match("///"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "META"

    // $ANTLR start "T__28"
    public final void mT__28() throws RecognitionException {
        try {
            int _type = T__28;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:8:7: ( '\"' )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:8:9: '\"'
            {
            match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "SEMI"
    public final void mSEMI() throws RecognitionException {
        try {
            int _type = SEMI;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:82:6: ( ';' )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:82:8: ';'
            {
            match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SEMI"

    // $ANTLR start "NEWLINE"
    public final void mNEWLINE() throws RecognitionException {
        try {
            int _type = NEWLINE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:85:2: ( '\\r\\n' | '\\r' | '\\n' )
            int alt1=3;
            int LA1_0 = input.LA(1);

            if ( (LA1_0=='\r') ) {
                int LA1_1 = input.LA(2);

                if ( (LA1_1=='\n') ) {
                    alt1=1;
                }
                else {
                    alt1=2;}
            }
            else if ( (LA1_0=='\n') ) {
                alt1=3;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 1, 0, input);

                throw nvae;
            }
            switch (alt1) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:85:4: '\\r\\n'
                    {
                    match("\r\n"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:86:4: '\\r'
                    {
                    match('\r'); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:87:4: '\\n'
                    {
                    match('\n'); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "NEWLINE"

    // $ANTLR start "NAME"
    public final void mNAME() throws RecognitionException {
        try {
            int _type = NAME;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:89:6: ( META ( ' ' )* ( 'name:' | 'name' ) | META ( ' ' )* ( 'prefix:' | 'prefix' ) )
            int alt6=2;
            alt6 = dfa6.predict(input);
            switch (alt6) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:89:8: META ( ' ' )* ( 'name:' | 'name' )
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:89:13: ( ' ' )*
                    loop2:
                    do {
                        int alt2=2;
                        int LA2_0 = input.LA(1);

                        if ( (LA2_0==' ') ) {
                            alt2=1;
                        }


                        switch (alt2) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:89:13: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop2;
                        }
                    } while (true);

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:89:18: ( 'name:' | 'name' )
                    int alt3=2;
                    int LA3_0 = input.LA(1);

                    if ( (LA3_0=='n') ) {
                        int LA3_1 = input.LA(2);

                        if ( (LA3_1=='a') ) {
                            int LA3_2 = input.LA(3);

                            if ( (LA3_2=='m') ) {
                                int LA3_3 = input.LA(4);

                                if ( (LA3_3=='e') ) {
                                    int LA3_4 = input.LA(5);

                                    if ( (LA3_4==':') ) {
                                        alt3=1;
                                    }
                                    else {
                                        alt3=2;}
                                }
                                else {
                                    NoViableAltException nvae =
                                        new NoViableAltException("", 3, 3, input);

                                    throw nvae;
                                }
                            }
                            else {
                                NoViableAltException nvae =
                                    new NoViableAltException("", 3, 2, input);

                                throw nvae;
                            }
                        }
                        else {
                            NoViableAltException nvae =
                                new NoViableAltException("", 3, 1, input);

                            throw nvae;
                        }
                    }
                    else {
                        NoViableAltException nvae =
                            new NoViableAltException("", 3, 0, input);

                        throw nvae;
                    }
                    switch (alt3) {
                        case 1 :
                            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:89:19: 'name:'
                            {
                            match("name:"); 


                            }
                            break;
                        case 2 :
                            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:89:29: 'name'
                            {
                            match("name"); 


                            }
                            break;

                    }


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:90:4: META ( ' ' )* ( 'prefix:' | 'prefix' )
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:90:9: ( ' ' )*
                    loop4:
                    do {
                        int alt4=2;
                        int LA4_0 = input.LA(1);

                        if ( (LA4_0==' ') ) {
                            alt4=1;
                        }


                        switch (alt4) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:90:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop4;
                        }
                    } while (true);

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:90:14: ( 'prefix:' | 'prefix' )
                    int alt5=2;
                    int LA5_0 = input.LA(1);

                    if ( (LA5_0=='p') ) {
                        int LA5_1 = input.LA(2);

                        if ( (LA5_1=='r') ) {
                            int LA5_2 = input.LA(3);

                            if ( (LA5_2=='e') ) {
                                int LA5_3 = input.LA(4);

                                if ( (LA5_3=='f') ) {
                                    int LA5_4 = input.LA(5);

                                    if ( (LA5_4=='i') ) {
                                        int LA5_5 = input.LA(6);

                                        if ( (LA5_5=='x') ) {
                                            int LA5_6 = input.LA(7);

                                            if ( (LA5_6==':') ) {
                                                alt5=1;
                                            }
                                            else {
                                                alt5=2;}
                                        }
                                        else {
                                            NoViableAltException nvae =
                                                new NoViableAltException("", 5, 5, input);

                                            throw nvae;
                                        }
                                    }
                                    else {
                                        NoViableAltException nvae =
                                            new NoViableAltException("", 5, 4, input);

                                        throw nvae;
                                    }
                                }
                                else {
                                    NoViableAltException nvae =
                                        new NoViableAltException("", 5, 3, input);

                                    throw nvae;
                                }
                            }
                            else {
                                NoViableAltException nvae =
                                    new NoViableAltException("", 5, 2, input);

                                throw nvae;
                            }
                        }
                        else {
                            NoViableAltException nvae =
                                new NoViableAltException("", 5, 1, input);

                            throw nvae;
                        }
                    }
                    else {
                        NoViableAltException nvae =
                            new NoViableAltException("", 5, 0, input);

                        throw nvae;
                    }
                    switch (alt5) {
                        case 1 :
                            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:90:15: 'prefix:'
                            {
                            match("prefix:"); 


                            }
                            break;
                        case 2 :
                            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:90:27: 'prefix'
                            {
                            match("prefix"); 


                            }
                            break;

                    }


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "NAME"

    // $ANTLR start "DESCRIPTION"
    public final void mDESCRIPTION() throws RecognitionException {
        try {
            int _type = DESCRIPTION;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:93:2: ( META ( ' ' )* 'description' | META ( ' ' )* 'description:' )
            int alt9=2;
            alt9 = dfa9.predict(input);
            switch (alt9) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:93:4: META ( ' ' )* 'description'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:93:9: ( ' ' )*
                    loop7:
                    do {
                        int alt7=2;
                        int LA7_0 = input.LA(1);

                        if ( (LA7_0==' ') ) {
                            alt7=1;
                        }


                        switch (alt7) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:93:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop7;
                        }
                    } while (true);

                    match("description"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:94:4: META ( ' ' )* 'description:'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:94:9: ( ' ' )*
                    loop8:
                    do {
                        int alt8=2;
                        int LA8_0 = input.LA(1);

                        if ( (LA8_0==' ') ) {
                            alt8=1;
                        }


                        switch (alt8) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:94:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop8;
                        }
                    } while (true);

                    match("description:"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "DESCRIPTION"

    // $ANTLR start "SCRIPTNAME"
    public final void mSCRIPTNAME() throws RecognitionException {
        try {
            int _type = SCRIPTNAME;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:97:2: ( META ( ' ' )* 'script name' | META ( ' ' )* 'script name:' )
            int alt12=2;
            alt12 = dfa12.predict(input);
            switch (alt12) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:97:4: META ( ' ' )* 'script name'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:97:9: ( ' ' )*
                    loop10:
                    do {
                        int alt10=2;
                        int LA10_0 = input.LA(1);

                        if ( (LA10_0==' ') ) {
                            alt10=1;
                        }


                        switch (alt10) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:97:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop10;
                        }
                    } while (true);

                    match("script name"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:98:4: META ( ' ' )* 'script name:'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:98:9: ( ' ' )*
                    loop11:
                    do {
                        int alt11=2;
                        int LA11_0 = input.LA(1);

                        if ( (LA11_0==' ') ) {
                            alt11=1;
                        }


                        switch (alt11) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:98:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop11;
                        }
                    } while (true);

                    match("script name:"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SCRIPTNAME"

    // $ANTLR start "ALTNAME"
    public final void mALTNAME() throws RecognitionException {
        try {
            int _type = ALTNAME;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:100:9: ( META ( ' ' )* 'alt name' | META ( ' ' )* 'alt name:' )
            int alt15=2;
            alt15 = dfa15.predict(input);
            switch (alt15) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:100:11: META ( ' ' )* 'alt name'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:100:16: ( ' ' )*
                    loop13:
                    do {
                        int alt13=2;
                        int LA13_0 = input.LA(1);

                        if ( (LA13_0==' ') ) {
                            alt13=1;
                        }


                        switch (alt13) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:100:16: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop13;
                        }
                    } while (true);

                    match("alt name"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:101:4: META ( ' ' )* 'alt name:'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:101:9: ( ' ' )*
                    loop14:
                    do {
                        int alt14=2;
                        int LA14_0 = input.LA(1);

                        if ( (LA14_0==' ') ) {
                            alt14=1;
                        }


                        switch (alt14) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:101:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop14;
                        }
                    } while (true);

                    match("alt name:"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ALTNAME"

    // $ANTLR start "ICON"
    public final void mICON() throws RecognitionException {
        try {
            int _type = ICON;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:103:6: ( META ( ' ' )* 'icon' | META ( ' ' )* 'icon:' )
            int alt18=2;
            alt18 = dfa18.predict(input);
            switch (alt18) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:103:8: META ( ' ' )* 'icon'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:103:13: ( ' ' )*
                    loop16:
                    do {
                        int alt16=2;
                        int LA16_0 = input.LA(1);

                        if ( (LA16_0==' ') ) {
                            alt16=1;
                        }


                        switch (alt16) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:103:13: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop16;
                        }
                    } while (true);

                    match("icon"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:104:4: META ( ' ' )* 'icon:'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:104:9: ( ' ' )*
                    loop17:
                    do {
                        int alt17=2;
                        int LA17_0 = input.LA(1);

                        if ( (LA17_0==' ') ) {
                            alt17=1;
                        }


                        switch (alt17) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:104:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop17;
                        }
                    } while (true);

                    match("icon:"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ICON"

    // $ANTLR start "TOGGLE"
    public final void mTOGGLE() throws RecognitionException {
        try {
            int _type = TOGGLE;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:106:9: ( META ( ' ' )* 'type' ( ' ' )* 'toggle' | META ( ' ' )* 'type:' ( ' ' )* 'toggle' )
            int alt23=2;
            alt23 = dfa23.predict(input);
            switch (alt23) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:106:11: META ( ' ' )* 'type' ( ' ' )* 'toggle'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:106:16: ( ' ' )*
                    loop19:
                    do {
                        int alt19=2;
                        int LA19_0 = input.LA(1);

                        if ( (LA19_0==' ') ) {
                            alt19=1;
                        }


                        switch (alt19) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:106:16: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop19;
                        }
                    } while (true);

                    match("type"); 

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:106:28: ( ' ' )*
                    loop20:
                    do {
                        int alt20=2;
                        int LA20_0 = input.LA(1);

                        if ( (LA20_0==' ') ) {
                            alt20=1;
                        }


                        switch (alt20) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:106:28: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop20;
                        }
                    } while (true);

                    match("toggle"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:107:4: META ( ' ' )* 'type:' ( ' ' )* 'toggle'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:107:9: ( ' ' )*
                    loop21:
                    do {
                        int alt21=2;
                        int LA21_0 = input.LA(1);

                        if ( (LA21_0==' ') ) {
                            alt21=1;
                        }


                        switch (alt21) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:107:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop21;
                        }
                    } while (true);

                    match("type:"); 

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:107:22: ( ' ' )*
                    loop22:
                    do {
                        int alt22=2;
                        int LA22_0 = input.LA(1);

                        if ( (LA22_0==' ') ) {
                            alt22=1;
                        }


                        switch (alt22) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:107:22: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop22;
                        }
                    } while (true);

                    match("toggle"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "TOGGLE"

    // $ANTLR start "KEY"
    public final void mKEY() throws RecognitionException {
        try {
            int _type = KEY;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:109:6: ( META ( ' ' )* 'type' ( ' ' )* 'key' | META ( ' ' )* 'type:' ( ' ' )* 'key' )
            int alt28=2;
            alt28 = dfa28.predict(input);
            switch (alt28) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:109:8: META ( ' ' )* 'type' ( ' ' )* 'key'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:109:13: ( ' ' )*
                    loop24:
                    do {
                        int alt24=2;
                        int LA24_0 = input.LA(1);

                        if ( (LA24_0==' ') ) {
                            alt24=1;
                        }


                        switch (alt24) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:109:13: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop24;
                        }
                    } while (true);

                    match("type"); 

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:109:25: ( ' ' )*
                    loop25:
                    do {
                        int alt25=2;
                        int LA25_0 = input.LA(1);

                        if ( (LA25_0==' ') ) {
                            alt25=1;
                        }


                        switch (alt25) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:109:25: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop25;
                        }
                    } while (true);

                    match("key"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:110:4: META ( ' ' )* 'type:' ( ' ' )* 'key'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:110:9: ( ' ' )*
                    loop26:
                    do {
                        int alt26=2;
                        int LA26_0 = input.LA(1);

                        if ( (LA26_0==' ') ) {
                            alt26=1;
                        }


                        switch (alt26) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:110:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop26;
                        }
                    } while (true);

                    match("type:"); 

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:110:22: ( ' ' )*
                    loop27:
                    do {
                        int alt27=2;
                        int LA27_0 = input.LA(1);

                        if ( (LA27_0==' ') ) {
                            alt27=1;
                        }


                        switch (alt27) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:110:22: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop27;
                        }
                    } while (true);

                    match("key"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "KEY"

    // $ANTLR start "SUBKEY"
    public final void mSUBKEY() throws RecognitionException {
        try {
            int _type = SUBKEY;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:112:9: ( META ( ' ' )* 'type' ( ' ' )* 'subkey' | META ( ' ' )* 'type:' ( ' ' )* 'subkey' )
            int alt33=2;
            alt33 = dfa33.predict(input);
            switch (alt33) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:112:11: META ( ' ' )* 'type' ( ' ' )* 'subkey'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:112:16: ( ' ' )*
                    loop29:
                    do {
                        int alt29=2;
                        int LA29_0 = input.LA(1);

                        if ( (LA29_0==' ') ) {
                            alt29=1;
                        }


                        switch (alt29) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:112:16: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop29;
                        }
                    } while (true);

                    match("type"); 

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:112:28: ( ' ' )*
                    loop30:
                    do {
                        int alt30=2;
                        int LA30_0 = input.LA(1);

                        if ( (LA30_0==' ') ) {
                            alt30=1;
                        }


                        switch (alt30) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:112:28: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop30;
                        }
                    } while (true);

                    match("subkey"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:113:4: META ( ' ' )* 'type:' ( ' ' )* 'subkey'
                    {
                    mMETA(); 
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:113:9: ( ' ' )*
                    loop31:
                    do {
                        int alt31=2;
                        int LA31_0 = input.LA(1);

                        if ( (LA31_0==' ') ) {
                            alt31=1;
                        }


                        switch (alt31) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:113:9: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop31;
                        }
                    } while (true);

                    match("type:"); 

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:113:22: ( ' ' )*
                    loop32:
                    do {
                        int alt32=2;
                        int LA32_0 = input.LA(1);

                        if ( (LA32_0==' ') ) {
                            alt32=1;
                        }


                        switch (alt32) {
                    	case 1 :
                    	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:113:22: ' '
                    	    {
                    	    match(' '); 

                    	    }
                    	    break;

                    	default :
                    	    break loop32;
                        }
                    } while (true);

                    match("subkey"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SUBKEY"

    // $ANTLR start "SL_COMMENT"
    public final void mSL_COMMENT() throws RecognitionException {
        try {
            int _type = SL_COMMENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:116:2: ( '//' ~ ( '/' | '\\r' | '\\n' ) . (~ ( '\\r' | '\\n' ) )* )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:116:4: '//' ~ ( '/' | '\\r' | '\\n' ) . (~ ( '\\r' | '\\n' ) )*
            {
            match("//"); 

            if ( (input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='.')||(input.LA(1)>='0' && input.LA(1)<='\uFFFF') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            matchAny(); 
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:116:31: (~ ( '\\r' | '\\n' ) )*
            loop34:
            do {
                int alt34=2;
                int LA34_0 = input.LA(1);

                if ( ((LA34_0>='\u0000' && LA34_0<='\t')||(LA34_0>='\u000B' && LA34_0<='\f')||(LA34_0>='\u000E' && LA34_0<='\uFFFF')) ) {
                    alt34=1;
                }


                switch (alt34) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:116:32: ~ ( '\\r' | '\\n' )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop34;
                }
            } while (true);

             _channel=HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SL_COMMENT"

    // $ANTLR start "WS"
    public final void mWS() throws RecognitionException {
        try {
            int _type = WS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:119:4: ( ( ' ' | '\\t' | '\\u000C' )+ )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:119:6: ( ' ' | '\\t' | '\\u000C' )+
            {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:119:6: ( ' ' | '\\t' | '\\u000C' )+
            int cnt35=0;
            loop35:
            do {
                int alt35=2;
                int LA35_0 = input.LA(1);

                if ( (LA35_0=='\t'||LA35_0=='\f'||LA35_0==' ') ) {
                    alt35=1;
                }


                switch (alt35) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:
            	    {
            	    if ( input.LA(1)=='\t'||input.LA(1)=='\f'||input.LA(1)==' ' ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    if ( cnt35 >= 1 ) break loop35;
                        EarlyExitException eee =
                            new EarlyExitException(35, input);
                        throw eee;
                }
                cnt35++;
            } while (true);

             _channel = HIDDEN; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "ID"
    public final void mID() throws RecognitionException {
        try {
            int _type = ID;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:121:4: ( ( CHARACTER )+ )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:121:6: ( CHARACTER )+
            {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:121:6: ( CHARACTER )+
            int cnt36=0;
            loop36:
            do {
                int alt36=2;
                int LA36_0 = input.LA(1);

                if ( ((LA36_0>='\u0000' && LA36_0<='\b')||LA36_0=='\u000B'||(LA36_0>='\u000E' && LA36_0<='\u001F')||LA36_0=='!'||(LA36_0>='#' && LA36_0<=':')||(LA36_0>='<' && LA36_0<='\uFFFF')) ) {
                    alt36=1;
                }


                switch (alt36) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:121:6: CHARACTER
            	    {
            	    mCHARACTER(); 

            	    }
            	    break;

            	default :
            	    if ( cnt36 >= 1 ) break loop36;
                        EarlyExitException eee =
                            new EarlyExitException(36, input);
                        throw eee;
                }
                cnt36++;
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ID"

    // $ANTLR start "CHARACTER"
    public final void mCHARACTER() throws RecognitionException {
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:122:20: (~ ( '\"' | ';' | '\\r' | '\\n' | '\\r\\n' | ' ' | '\\t' | '\\u000C' ) )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:122:22: ~ ( '\"' | ';' | '\\r' | '\\n' | '\\r\\n' | ' ' | '\\t' | '\\u000C' )
            {
            if ( (input.LA(1)>='\u0000' && input.LA(1)<='\b')||input.LA(1)=='\u000B'||(input.LA(1)>='\u000E' && input.LA(1)<='\u001F')||input.LA(1)=='!'||(input.LA(1)>='#' && input.LA(1)<=':')||(input.LA(1)>='<' && input.LA(1)<='\uFFFF') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}


            }

        }
        finally {
        }
    }
    // $ANTLR end "CHARACTER"

    public void mTokens() throws RecognitionException {
        // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:8: ( ALIAS | BIND | RCON | EXEC | META | T__28 | SEMI | NEWLINE | NAME | DESCRIPTION | SCRIPTNAME | ALTNAME | ICON | TOGGLE | KEY | SUBKEY | SL_COMMENT | WS | ID )
        int alt37=19;
        alt37 = dfa37.predict(input);
        switch (alt37) {
            case 1 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:10: ALIAS
                {
                mALIAS(); 

                }
                break;
            case 2 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:16: BIND
                {
                mBIND(); 

                }
                break;
            case 3 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:21: RCON
                {
                mRCON(); 

                }
                break;
            case 4 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:26: EXEC
                {
                mEXEC(); 

                }
                break;
            case 5 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:31: META
                {
                mMETA(); 

                }
                break;
            case 6 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:36: T__28
                {
                mT__28(); 

                }
                break;
            case 7 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:42: SEMI
                {
                mSEMI(); 

                }
                break;
            case 8 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:47: NEWLINE
                {
                mNEWLINE(); 

                }
                break;
            case 9 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:55: NAME
                {
                mNAME(); 

                }
                break;
            case 10 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:60: DESCRIPTION
                {
                mDESCRIPTION(); 

                }
                break;
            case 11 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:72: SCRIPTNAME
                {
                mSCRIPTNAME(); 

                }
                break;
            case 12 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:83: ALTNAME
                {
                mALTNAME(); 

                }
                break;
            case 13 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:91: ICON
                {
                mICON(); 

                }
                break;
            case 14 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:96: TOGGLE
                {
                mTOGGLE(); 

                }
                break;
            case 15 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:103: KEY
                {
                mKEY(); 

                }
                break;
            case 16 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:107: SUBKEY
                {
                mSUBKEY(); 

                }
                break;
            case 17 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:114: SL_COMMENT
                {
                mSL_COMMENT(); 

                }
                break;
            case 18 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:125: WS
                {
                mWS(); 

                }
                break;
            case 19 :
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:1:128: ID
                {
                mID(); 

                }
                break;

        }

    }


    protected DFA6 dfa6 = new DFA6(this);
    protected DFA9 dfa9 = new DFA9(this);
    protected DFA12 dfa12 = new DFA12(this);
    protected DFA15 dfa15 = new DFA15(this);
    protected DFA18 dfa18 = new DFA18(this);
    protected DFA23 dfa23 = new DFA23(this);
    protected DFA28 dfa28 = new DFA28(this);
    protected DFA33 dfa33 = new DFA33(this);
    protected DFA37 dfa37 = new DFA37(this);
    static final String DFA6_eotS =
        "\7\uffff";
    static final String DFA6_eofS =
        "\7\uffff";
    static final String DFA6_minS =
        "\3\57\2\40\2\uffff";
    static final String DFA6_maxS =
        "\3\57\2\160\2\uffff";
    static final String DFA6_acceptS =
        "\5\uffff\1\1\1\2";
    static final String DFA6_specialS =
        "\7\uffff}>";
    static final String[] DFA6_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\115\uffff\1\5\1\uffff\1\6",
            "\1\4\115\uffff\1\5\1\uffff\1\6",
            "",
            ""
    };

    static final short[] DFA6_eot = DFA.unpackEncodedString(DFA6_eotS);
    static final short[] DFA6_eof = DFA.unpackEncodedString(DFA6_eofS);
    static final char[] DFA6_min = DFA.unpackEncodedStringToUnsignedChars(DFA6_minS);
    static final char[] DFA6_max = DFA.unpackEncodedStringToUnsignedChars(DFA6_maxS);
    static final short[] DFA6_accept = DFA.unpackEncodedString(DFA6_acceptS);
    static final short[] DFA6_special = DFA.unpackEncodedString(DFA6_specialS);
    static final short[][] DFA6_transition;

    static {
        int numStates = DFA6_transitionS.length;
        DFA6_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA6_transition[i] = DFA.unpackEncodedString(DFA6_transitionS[i]);
        }
    }

    class DFA6 extends DFA {

        public DFA6(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "89:1: NAME : ( META ( ' ' )* ( 'name:' | 'name' ) | META ( ' ' )* ( 'prefix:' | 'prefix' ) );";
        }
    }
    static final String DFA9_eotS =
        "\17\uffff\1\21\2\uffff";
    static final String DFA9_eofS =
        "\22\uffff";
    static final String DFA9_minS =
        "\3\57\2\40\1\145\1\163\1\143\1\162\1\151\1\160\1\164\1\151\1\157"+
        "\1\156\1\72\2\uffff";
    static final String DFA9_maxS =
        "\3\57\2\144\1\145\1\163\1\143\1\162\1\151\1\160\1\164\1\151\1\157"+
        "\1\156\1\72\2\uffff";
    static final String DFA9_acceptS =
        "\20\uffff\1\2\1\1";
    static final String DFA9_specialS =
        "\22\uffff}>";
    static final String[] DFA9_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\103\uffff\1\5",
            "\1\4\103\uffff\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\11",
            "\1\12",
            "\1\13",
            "\1\14",
            "\1\15",
            "\1\16",
            "\1\17",
            "\1\20",
            "",
            ""
    };

    static final short[] DFA9_eot = DFA.unpackEncodedString(DFA9_eotS);
    static final short[] DFA9_eof = DFA.unpackEncodedString(DFA9_eofS);
    static final char[] DFA9_min = DFA.unpackEncodedStringToUnsignedChars(DFA9_minS);
    static final char[] DFA9_max = DFA.unpackEncodedStringToUnsignedChars(DFA9_maxS);
    static final short[] DFA9_accept = DFA.unpackEncodedString(DFA9_acceptS);
    static final short[] DFA9_special = DFA.unpackEncodedString(DFA9_specialS);
    static final short[][] DFA9_transition;

    static {
        int numStates = DFA9_transitionS.length;
        DFA9_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA9_transition[i] = DFA.unpackEncodedString(DFA9_transitionS[i]);
        }
    }

    class DFA9 extends DFA {

        public DFA9(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 9;
            this.eot = DFA9_eot;
            this.eof = DFA9_eof;
            this.min = DFA9_min;
            this.max = DFA9_max;
            this.accept = DFA9_accept;
            this.special = DFA9_special;
            this.transition = DFA9_transition;
        }
        public String getDescription() {
            return "92:1: DESCRIPTION : ( META ( ' ' )* 'description' | META ( ' ' )* 'description:' );";
        }
    }
    static final String DFA12_eotS =
        "\17\uffff\1\21\2\uffff";
    static final String DFA12_eofS =
        "\22\uffff";
    static final String DFA12_minS =
        "\3\57\2\40\1\143\1\162\1\151\1\160\1\164\1\40\1\156\1\141\1\155"+
        "\1\145\1\72\2\uffff";
    static final String DFA12_maxS =
        "\3\57\2\163\1\143\1\162\1\151\1\160\1\164\1\40\1\156\1\141\1\155"+
        "\1\145\1\72\2\uffff";
    static final String DFA12_acceptS =
        "\20\uffff\1\2\1\1";
    static final String DFA12_specialS =
        "\22\uffff}>";
    static final String[] DFA12_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\122\uffff\1\5",
            "\1\4\122\uffff\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\11",
            "\1\12",
            "\1\13",
            "\1\14",
            "\1\15",
            "\1\16",
            "\1\17",
            "\1\20",
            "",
            ""
    };

    static final short[] DFA12_eot = DFA.unpackEncodedString(DFA12_eotS);
    static final short[] DFA12_eof = DFA.unpackEncodedString(DFA12_eofS);
    static final char[] DFA12_min = DFA.unpackEncodedStringToUnsignedChars(DFA12_minS);
    static final char[] DFA12_max = DFA.unpackEncodedStringToUnsignedChars(DFA12_maxS);
    static final short[] DFA12_accept = DFA.unpackEncodedString(DFA12_acceptS);
    static final short[] DFA12_special = DFA.unpackEncodedString(DFA12_specialS);
    static final short[][] DFA12_transition;

    static {
        int numStates = DFA12_transitionS.length;
        DFA12_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA12_transition[i] = DFA.unpackEncodedString(DFA12_transitionS[i]);
        }
    }

    class DFA12 extends DFA {

        public DFA12(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;
        }
        public String getDescription() {
            return "96:1: SCRIPTNAME : ( META ( ' ' )* 'script name' | META ( ' ' )* 'script name:' );";
        }
    }
    static final String DFA15_eotS =
        "\14\uffff\1\16\2\uffff";
    static final String DFA15_eofS =
        "\17\uffff";
    static final String DFA15_minS =
        "\3\57\2\40\1\154\1\164\1\40\1\156\1\141\1\155\1\145\1\72\2\uffff";
    static final String DFA15_maxS =
        "\3\57\2\141\1\154\1\164\1\40\1\156\1\141\1\155\1\145\1\72\2\uffff";
    static final String DFA15_acceptS =
        "\15\uffff\1\2\1\1";
    static final String DFA15_specialS =
        "\17\uffff}>";
    static final String[] DFA15_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\100\uffff\1\5",
            "\1\4\100\uffff\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\11",
            "\1\12",
            "\1\13",
            "\1\14",
            "\1\15",
            "",
            ""
    };

    static final short[] DFA15_eot = DFA.unpackEncodedString(DFA15_eotS);
    static final short[] DFA15_eof = DFA.unpackEncodedString(DFA15_eofS);
    static final char[] DFA15_min = DFA.unpackEncodedStringToUnsignedChars(DFA15_minS);
    static final char[] DFA15_max = DFA.unpackEncodedStringToUnsignedChars(DFA15_maxS);
    static final short[] DFA15_accept = DFA.unpackEncodedString(DFA15_acceptS);
    static final short[] DFA15_special = DFA.unpackEncodedString(DFA15_specialS);
    static final short[][] DFA15_transition;

    static {
        int numStates = DFA15_transitionS.length;
        DFA15_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA15_transition[i] = DFA.unpackEncodedString(DFA15_transitionS[i]);
        }
    }

    class DFA15 extends DFA {

        public DFA15(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 15;
            this.eot = DFA15_eot;
            this.eof = DFA15_eof;
            this.min = DFA15_min;
            this.max = DFA15_max;
            this.accept = DFA15_accept;
            this.special = DFA15_special;
            this.transition = DFA15_transition;
        }
        public String getDescription() {
            return "100:1: ALTNAME : ( META ( ' ' )* 'alt name' | META ( ' ' )* 'alt name:' );";
        }
    }
    static final String DFA18_eotS =
        "\10\uffff\1\12\2\uffff";
    static final String DFA18_eofS =
        "\13\uffff";
    static final String DFA18_minS =
        "\3\57\2\40\1\143\1\157\1\156\1\72\2\uffff";
    static final String DFA18_maxS =
        "\3\57\2\151\1\143\1\157\1\156\1\72\2\uffff";
    static final String DFA18_acceptS =
        "\11\uffff\1\2\1\1";
    static final String DFA18_specialS =
        "\13\uffff}>";
    static final String[] DFA18_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\110\uffff\1\5",
            "\1\4\110\uffff\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\11",
            "",
            ""
    };

    static final short[] DFA18_eot = DFA.unpackEncodedString(DFA18_eotS);
    static final short[] DFA18_eof = DFA.unpackEncodedString(DFA18_eofS);
    static final char[] DFA18_min = DFA.unpackEncodedStringToUnsignedChars(DFA18_minS);
    static final char[] DFA18_max = DFA.unpackEncodedStringToUnsignedChars(DFA18_maxS);
    static final short[] DFA18_accept = DFA.unpackEncodedString(DFA18_acceptS);
    static final short[] DFA18_special = DFA.unpackEncodedString(DFA18_specialS);
    static final short[][] DFA18_transition;

    static {
        int numStates = DFA18_transitionS.length;
        DFA18_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA18_transition[i] = DFA.unpackEncodedString(DFA18_transitionS[i]);
        }
    }

    class DFA18 extends DFA {

        public DFA18(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;
        }
        public String getDescription() {
            return "103:1: ICON : ( META ( ' ' )* 'icon' | META ( ' ' )* 'icon:' );";
        }
    }
    static final String DFA23_eotS =
        "\13\uffff";
    static final String DFA23_eofS =
        "\13\uffff";
    static final String DFA23_minS =
        "\3\57\2\40\1\171\1\160\1\145\1\40\2\uffff";
    static final String DFA23_maxS =
        "\3\57\2\164\1\171\1\160\1\145\1\164\2\uffff";
    static final String DFA23_acceptS =
        "\11\uffff\1\2\1\1";
    static final String DFA23_specialS =
        "\13\uffff}>";
    static final String[] DFA23_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\123\uffff\1\5",
            "\1\4\123\uffff\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\12\31\uffff\1\11\71\uffff\1\12",
            "",
            ""
    };

    static final short[] DFA23_eot = DFA.unpackEncodedString(DFA23_eotS);
    static final short[] DFA23_eof = DFA.unpackEncodedString(DFA23_eofS);
    static final char[] DFA23_min = DFA.unpackEncodedStringToUnsignedChars(DFA23_minS);
    static final char[] DFA23_max = DFA.unpackEncodedStringToUnsignedChars(DFA23_maxS);
    static final short[] DFA23_accept = DFA.unpackEncodedString(DFA23_acceptS);
    static final short[] DFA23_special = DFA.unpackEncodedString(DFA23_specialS);
    static final short[][] DFA23_transition;

    static {
        int numStates = DFA23_transitionS.length;
        DFA23_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA23_transition[i] = DFA.unpackEncodedString(DFA23_transitionS[i]);
        }
    }

    class DFA23 extends DFA {

        public DFA23(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;
        }
        public String getDescription() {
            return "106:1: TOGGLE : ( META ( ' ' )* 'type' ( ' ' )* 'toggle' | META ( ' ' )* 'type:' ( ' ' )* 'toggle' );";
        }
    }
    static final String DFA28_eotS =
        "\13\uffff";
    static final String DFA28_eofS =
        "\13\uffff";
    static final String DFA28_minS =
        "\3\57\2\40\1\171\1\160\1\145\1\40\2\uffff";
    static final String DFA28_maxS =
        "\3\57\2\164\1\171\1\160\1\145\1\153\2\uffff";
    static final String DFA28_acceptS =
        "\11\uffff\1\2\1\1";
    static final String DFA28_specialS =
        "\13\uffff}>";
    static final String[] DFA28_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\123\uffff\1\5",
            "\1\4\123\uffff\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\12\31\uffff\1\11\60\uffff\1\12",
            "",
            ""
    };

    static final short[] DFA28_eot = DFA.unpackEncodedString(DFA28_eotS);
    static final short[] DFA28_eof = DFA.unpackEncodedString(DFA28_eofS);
    static final char[] DFA28_min = DFA.unpackEncodedStringToUnsignedChars(DFA28_minS);
    static final char[] DFA28_max = DFA.unpackEncodedStringToUnsignedChars(DFA28_maxS);
    static final short[] DFA28_accept = DFA.unpackEncodedString(DFA28_acceptS);
    static final short[] DFA28_special = DFA.unpackEncodedString(DFA28_specialS);
    static final short[][] DFA28_transition;

    static {
        int numStates = DFA28_transitionS.length;
        DFA28_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA28_transition[i] = DFA.unpackEncodedString(DFA28_transitionS[i]);
        }
    }

    class DFA28 extends DFA {

        public DFA28(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 28;
            this.eot = DFA28_eot;
            this.eof = DFA28_eof;
            this.min = DFA28_min;
            this.max = DFA28_max;
            this.accept = DFA28_accept;
            this.special = DFA28_special;
            this.transition = DFA28_transition;
        }
        public String getDescription() {
            return "109:1: KEY : ( META ( ' ' )* 'type' ( ' ' )* 'key' | META ( ' ' )* 'type:' ( ' ' )* 'key' );";
        }
    }
    static final String DFA33_eotS =
        "\13\uffff";
    static final String DFA33_eofS =
        "\13\uffff";
    static final String DFA33_minS =
        "\3\57\2\40\1\171\1\160\1\145\1\40\2\uffff";
    static final String DFA33_maxS =
        "\3\57\2\164\1\171\1\160\1\145\1\163\2\uffff";
    static final String DFA33_acceptS =
        "\11\uffff\1\2\1\1";
    static final String DFA33_specialS =
        "\13\uffff}>";
    static final String[] DFA33_transitionS = {
            "\1\1",
            "\1\2",
            "\1\3",
            "\1\4\123\uffff\1\5",
            "\1\4\123\uffff\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\12\31\uffff\1\11\70\uffff\1\12",
            "",
            ""
    };

    static final short[] DFA33_eot = DFA.unpackEncodedString(DFA33_eotS);
    static final short[] DFA33_eof = DFA.unpackEncodedString(DFA33_eofS);
    static final char[] DFA33_min = DFA.unpackEncodedStringToUnsignedChars(DFA33_minS);
    static final char[] DFA33_max = DFA.unpackEncodedStringToUnsignedChars(DFA33_maxS);
    static final short[] DFA33_accept = DFA.unpackEncodedString(DFA33_acceptS);
    static final short[] DFA33_special = DFA.unpackEncodedString(DFA33_specialS);
    static final short[][] DFA33_transition;

    static {
        int numStates = DFA33_transitionS.length;
        DFA33_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA33_transition[i] = DFA.unpackEncodedString(DFA33_transitionS[i]);
        }
    }

    class DFA33 extends DFA {

        public DFA33(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 33;
            this.eot = DFA33_eot;
            this.eof = DFA33_eof;
            this.min = DFA33_min;
            this.max = DFA33_max;
            this.accept = DFA33_accept;
            this.special = DFA33_special;
            this.transition = DFA33_transition;
        }
        public String getDescription() {
            return "112:1: SUBKEY : ( META ( ' ' )* 'type' ( ' ' )* 'subkey' | META ( ' ' )* 'type:' ( ' ' )* 'subkey' );";
        }
    }
    static final String DFA37_eotS =
        "\1\uffff\5\12\5\uffff\11\12\1\33\1\12\1\uffff\1\12\1\46\1\47\1"+
        "\50\2\uffff\7\12\1\26\1\67\11\uffff\7\12\1\26\2\uffff\7\12\1\uffff"+
        "\1\53\1\12\1\52\3\12\1\uffff\1\53\1\12\1\uffff\3\12\1\52\3\12\5"+
        "\uffff\6\12\1\52\6\12\1\124\1\12\1\52\3\12\1\124\12\12\1\123\1\125"+
        "\1\12\1\123\1\125\2\56";
    static final String DFA37_eofS =
        "\174\uffff";
    static final String DFA37_minS =
        "\1\0\1\154\1\151\1\143\1\170\1\57\5\uffff\1\151\1\156\1\157\1\145"+
        "\1\0\1\141\1\144\1\156\1\143\2\0\1\uffff\1\163\3\0\1\uffff\1\40"+
        "\1\143\1\171\1\141\1\154\1\162\1\143\1\145\2\0\6\uffff\1\171\2\uffff"+
        "\1\157\1\160\1\155\1\164\1\145\1\162\1\163\1\0\1\uffff\1\160\1\156"+
        "\2\145\1\40\1\146\1\151\1\143\1\145\1\0\1\40\1\0\1\151\1\160\1\162"+
        "\1\40\1\0\2\40\1\165\1\145\1\157\1\0\1\170\1\164\1\151\1\40\3\uffff"+
        "\1\40\1\165\1\157\1\145\1\142\1\171\1\147\1\0\1\40\1\160\1\142\1"+
        "\147\1\171\1\153\1\0\1\147\1\0\1\164\1\153\1\147\1\0\1\145\1\154"+
        "\1\151\1\145\1\154\1\171\1\145\1\157\1\171\1\145\2\0\1\156\4\0";
    static final String DFA37_maxS =
        "\1\uffff\1\154\1\151\1\143\1\170\1\57\5\uffff\1\151\1\156\1\157"+
        "\1\145\1\uffff\1\141\1\144\1\156\1\143\2\uffff\1\uffff\1\163\3\uffff"+
        "\1\uffff\1\164\1\143\1\171\1\141\1\154\1\162\1\143\1\145\2\uffff"+
        "\6\uffff\1\171\2\uffff\1\157\1\160\1\155\1\164\1\145\1\162\1\163"+
        "\1\uffff\1\uffff\1\160\1\156\2\145\1\40\1\146\1\151\1\143\1\145"+
        "\1\uffff\1\164\1\uffff\1\151\1\160\1\162\1\164\1\uffff\2\164\1\165"+
        "\1\145\1\157\1\uffff\1\170\1\164\1\151\1\164\3\uffff\1\164\1\165"+
        "\1\157\1\145\1\142\1\171\1\147\1\uffff\1\40\1\160\1\142\1\147\1"+
        "\171\1\153\1\uffff\1\147\1\uffff\1\164\1\153\1\147\1\uffff\1\145"+
        "\1\154\1\151\1\145\1\154\1\171\1\145\1\157\1\171\1\145\2\uffff\1"+
        "\156\4\uffff";
    static final String DFA37_acceptS =
        "\6\uffff\1\6\1\7\1\10\1\22\1\23\13\uffff\1\21\4\uffff\1\5\12\uffff"+
        "\1\2\1\3\1\4\1\13\1\11\1\15\1\uffff\1\14\1\12\10\uffff\1\1\33\uffff"+
        "\1\20\1\17\1\16\46\uffff";
    static final String DFA37_specialS =
        "\1\5\16\uffff\1\27\4\uffff\1\16\1\11\2\uffff\1\26\1\22\1\23\11"+
        "\uffff\1\4\1\21\20\uffff\1\6\12\uffff\1\20\1\uffff\1\3\4\uffff\1"+
        "\15\5\uffff\1\17\16\uffff\1\12\6\uffff\1\10\1\uffff\1\25\3\uffff"+
        "\1\14\12\uffff\1\24\1\2\1\uffff\1\1\1\0\1\7\1\13}>";
    static final String[] DFA37_transitionS = {
            "\11\12\1\11\1\10\1\12\1\11\1\10\22\12\1\11\1\12\1\6\14\12\1"+
            "\5\13\12\1\7\45\12\1\1\1\2\2\12\1\4\14\12\1\3\uff8d\12",
            "\1\13",
            "\1\14",
            "\1\15",
            "\1\16",
            "\1\17",
            "",
            "",
            "",
            "",
            "",
            "\1\20",
            "\1\21",
            "\1\22",
            "\1\23",
            "\11\25\1\26\1\uffff\1\25\1\26\1\uffff\22\25\1\26\1\25\1\26"+
            "\14\25\1\24\13\25\1\26\uffc4\25",
            "\1\27",
            "\1\30",
            "\1\31",
            "\1\32",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\34\1\12\1\uffff\30\12"+
            "\1\uffff\45\12\1\40\2\12\1\43\4\12\1\35\4\12\1\37\1\12\1\41"+
            "\2\12\1\42\1\36\uff8b\12",
            "\11\44\2\26\1\44\2\26\22\44\1\26\1\44\1\26\30\44\1\26\uffc4"+
            "\44",
            "",
            "\1\45",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "",
            "\1\34\100\uffff\1\55\2\uffff\1\56\4\uffff\1\53\4\uffff\1\52"+
            "\1\uffff\1\52\2\uffff\1\51\1\54",
            "\1\57",
            "\1\60",
            "\1\61",
            "\1\62",
            "\1\63",
            "\1\64",
            "\1\65",
            "\11\66\2\uffff\1\66\2\uffff\22\66\1\uffff\1\66\1\uffff\30"+
            "\66\1\uffff\uffc4\66",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\70",
            "",
            "",
            "\1\71",
            "\1\72",
            "\1\73",
            "\1\74",
            "\1\75",
            "\1\76",
            "\1\77",
            "\11\66\2\uffff\1\66\2\uffff\22\66\1\uffff\1\66\1\uffff\30"+
            "\66\1\uffff\uffc4\66",
            "",
            "\1\100",
            "\1\101",
            "\1\102",
            "\1\103",
            "\1\55",
            "\1\104",
            "\1\105",
            "\1\106",
            "\1\107",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\27"+
            "\12\1\110\1\uffff\uffc4\12",
            "\1\112\31\uffff\1\111\60\uffff\1\114\7\uffff\1\113\1\115",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\27"+
            "\12\1\116\1\uffff\uffc4\12",
            "\1\117",
            "\1\120",
            "\1\121",
            "\1\112\31\uffff\1\122\60\uffff\1\124\7\uffff\1\123\1\125",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\1\126\112\uffff\1\131\7\uffff\1\127\1\130",
            "\1\112\112\uffff\1\124\7\uffff\1\123\1\125",
            "\1\132",
            "\1\133",
            "\1\134",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\1\135",
            "\1\136",
            "\1\137",
            "\1\126\112\uffff\1\124\7\uffff\1\123\1\125",
            "",
            "",
            "",
            "\1\126\112\uffff\1\124\7\uffff\1\123\1\125",
            "\1\140",
            "\1\141",
            "\1\142",
            "\1\143",
            "\1\144",
            "\1\145",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\27"+
            "\12\1\146\1\uffff\uffc4\12",
            "\1\51",
            "\1\147",
            "\1\150",
            "\1\151",
            "\1\152",
            "\1\153",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\1\154",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\1\155",
            "\1\156",
            "\1\157",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\1\160",
            "\1\161",
            "\1\162",
            "\1\163",
            "\1\164",
            "\1\165",
            "\1\166",
            "\1\167",
            "\1\170",
            "\1\171",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\1\172",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\27"+
            "\12\1\173\1\uffff\uffc4\12",
            "\11\12\2\uffff\1\12\2\uffff\22\12\1\uffff\1\12\1\uffff\30"+
            "\12\1\uffff\uffc4\12"
    };

    static final short[] DFA37_eot = DFA.unpackEncodedString(DFA37_eotS);
    static final short[] DFA37_eof = DFA.unpackEncodedString(DFA37_eofS);
    static final char[] DFA37_min = DFA.unpackEncodedStringToUnsignedChars(DFA37_minS);
    static final char[] DFA37_max = DFA.unpackEncodedStringToUnsignedChars(DFA37_maxS);
    static final short[] DFA37_accept = DFA.unpackEncodedString(DFA37_acceptS);
    static final short[] DFA37_special = DFA.unpackEncodedString(DFA37_specialS);
    static final short[][] DFA37_transition;

    static {
        int numStates = DFA37_transitionS.length;
        DFA37_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA37_transition[i] = DFA.unpackEncodedString(DFA37_transitionS[i]);
        }
    }

    class DFA37 extends DFA {

        public DFA37(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 37;
            this.eot = DFA37_eot;
            this.eof = DFA37_eof;
            this.min = DFA37_min;
            this.max = DFA37_max;
            this.accept = DFA37_accept;
            this.special = DFA37_special;
            this.transition = DFA37_transition;
        }
        public String getDescription() {
            return "1:1: Tokens : ( ALIAS | BIND | RCON | EXEC | META | T__28 | SEMI | NEWLINE | NAME | DESCRIPTION | SCRIPTNAME | ALTNAME | ICON | TOGGLE | KEY | SUBKEY | SL_COMMENT | WS | ID );";
        }
        public int specialStateTransition(int s, IntStream _input) throws NoViableAltException {
            IntStream input = _input;
        	int _s = s;
            switch ( s ) {
                    case 0 : 
                        int LA37_121 = input.LA(1);

                        s = -1;
                        if ( ((LA37_121>='\u0000' && LA37_121<='\b')||LA37_121=='\u000B'||(LA37_121>='\u000E' && LA37_121<='\u001F')||LA37_121=='!'||(LA37_121>='#' && LA37_121<=':')||(LA37_121>='<' && LA37_121<='\uFFFF')) ) {s = 10;}

                        else s = 85;

                        if ( s>=0 ) return s;
                        break;
                    case 1 : 
                        int LA37_120 = input.LA(1);

                        s = -1;
                        if ( ((LA37_120>='\u0000' && LA37_120<='\b')||LA37_120=='\u000B'||(LA37_120>='\u000E' && LA37_120<='\u001F')||LA37_120=='!'||(LA37_120>='#' && LA37_120<=':')||(LA37_120>='<' && LA37_120<='\uFFFF')) ) {s = 10;}

                        else s = 83;

                        if ( s>=0 ) return s;
                        break;
                    case 2 : 
                        int LA37_118 = input.LA(1);

                        s = -1;
                        if ( ((LA37_118>='\u0000' && LA37_118<='\b')||LA37_118=='\u000B'||(LA37_118>='\u000E' && LA37_118<='\u001F')||LA37_118=='!'||(LA37_118>='#' && LA37_118<=':')||(LA37_118>='<' && LA37_118<='\uFFFF')) ) {s = 10;}

                        else s = 85;

                        if ( s>=0 ) return s;
                        break;
                    case 3 : 
                        int LA37_67 = input.LA(1);

                        s = -1;
                        if ( (LA37_67==':') ) {s = 78;}

                        else if ( ((LA37_67>='\u0000' && LA37_67<='\b')||LA37_67=='\u000B'||(LA37_67>='\u000E' && LA37_67<='\u001F')||LA37_67=='!'||(LA37_67>='#' && LA37_67<='9')||(LA37_67>='<' && LA37_67<='\uFFFF')) ) {s = 10;}

                        else s = 42;

                        if ( s>=0 ) return s;
                        break;
                    case 4 : 
                        int LA37_36 = input.LA(1);

                        s = -1;
                        if ( ((LA37_36>='\u0000' && LA37_36<='\b')||LA37_36=='\u000B'||(LA37_36>='\u000E' && LA37_36<='\u001F')||LA37_36=='!'||(LA37_36>='#' && LA37_36<=':')||(LA37_36>='<' && LA37_36<='\uFFFF')) ) {s = 54;}

                        else s = 22;

                        if ( s>=0 ) return s;
                        break;
                    case 5 : 
                        int LA37_0 = input.LA(1);

                        s = -1;
                        if ( (LA37_0=='a') ) {s = 1;}

                        else if ( (LA37_0=='b') ) {s = 2;}

                        else if ( (LA37_0=='r') ) {s = 3;}

                        else if ( (LA37_0=='e') ) {s = 4;}

                        else if ( (LA37_0=='/') ) {s = 5;}

                        else if ( (LA37_0=='\"') ) {s = 6;}

                        else if ( (LA37_0==';') ) {s = 7;}

                        else if ( (LA37_0=='\n'||LA37_0=='\r') ) {s = 8;}

                        else if ( (LA37_0=='\t'||LA37_0=='\f'||LA37_0==' ') ) {s = 9;}

                        else if ( ((LA37_0>='\u0000' && LA37_0<='\b')||LA37_0=='\u000B'||(LA37_0>='\u000E' && LA37_0<='\u001F')||LA37_0=='!'||(LA37_0>='#' && LA37_0<='.')||(LA37_0>='0' && LA37_0<=':')||(LA37_0>='<' && LA37_0<='`')||(LA37_0>='c' && LA37_0<='d')||(LA37_0>='f' && LA37_0<='q')||(LA37_0>='s' && LA37_0<='\uFFFF')) ) {s = 10;}

                        if ( s>=0 ) return s;
                        break;
                    case 6 : 
                        int LA37_54 = input.LA(1);

                        s = -1;
                        if ( ((LA37_54>='\u0000' && LA37_54<='\b')||LA37_54=='\u000B'||(LA37_54>='\u000E' && LA37_54<='\u001F')||LA37_54=='!'||(LA37_54>='#' && LA37_54<=':')||(LA37_54>='<' && LA37_54<='\uFFFF')) ) {s = 54;}

                        else s = 22;

                        if ( s>=0 ) return s;
                        break;
                    case 7 : 
                        int LA37_122 = input.LA(1);

                        s = -1;
                        if ( (LA37_122==':') ) {s = 123;}

                        else if ( ((LA37_122>='\u0000' && LA37_122<='\b')||LA37_122=='\u000B'||(LA37_122>='\u000E' && LA37_122<='\u001F')||LA37_122=='!'||(LA37_122>='#' && LA37_122<='9')||(LA37_122>='<' && LA37_122<='\uFFFF')) ) {s = 10;}

                        else s = 46;

                        if ( s>=0 ) return s;
                        break;
                    case 8 : 
                        int LA37_100 = input.LA(1);

                        s = -1;
                        if ( ((LA37_100>='\u0000' && LA37_100<='\b')||LA37_100=='\u000B'||(LA37_100>='\u000E' && LA37_100<='\u001F')||LA37_100=='!'||(LA37_100>='#' && LA37_100<=':')||(LA37_100>='<' && LA37_100<='\uFFFF')) ) {s = 10;}

                        else s = 84;

                        if ( s>=0 ) return s;
                        break;
                    case 9 : 
                        int LA37_21 = input.LA(1);

                        s = -1;
                        if ( ((LA37_21>='\u0000' && LA37_21<='\b')||LA37_21=='\u000B'||(LA37_21>='\u000E' && LA37_21<='\u001F')||LA37_21=='!'||(LA37_21>='#' && LA37_21<=':')||(LA37_21>='<' && LA37_21<='\uFFFF')) ) {s = 36;}

                        else if ( ((LA37_21>='\t' && LA37_21<='\n')||(LA37_21>='\f' && LA37_21<='\r')||LA37_21==' '||LA37_21=='\"'||LA37_21==';') ) {s = 22;}

                        else s = 10;

                        if ( s>=0 ) return s;
                        break;
                    case 10 : 
                        int LA37_93 = input.LA(1);

                        s = -1;
                        if ( (LA37_93==':') ) {s = 102;}

                        else if ( ((LA37_93>='\u0000' && LA37_93<='\b')||LA37_93=='\u000B'||(LA37_93>='\u000E' && LA37_93<='\u001F')||LA37_93=='!'||(LA37_93>='#' && LA37_93<='9')||(LA37_93>='<' && LA37_93<='\uFFFF')) ) {s = 10;}

                        else s = 42;

                        if ( s>=0 ) return s;
                        break;
                    case 11 : 
                        int LA37_123 = input.LA(1);

                        s = -1;
                        if ( ((LA37_123>='\u0000' && LA37_123<='\b')||LA37_123=='\u000B'||(LA37_123>='\u000E' && LA37_123<='\u001F')||LA37_123=='!'||(LA37_123>='#' && LA37_123<=':')||(LA37_123>='<' && LA37_123<='\uFFFF')) ) {s = 10;}

                        else s = 46;

                        if ( s>=0 ) return s;
                        break;
                    case 12 : 
                        int LA37_106 = input.LA(1);

                        s = -1;
                        if ( ((LA37_106>='\u0000' && LA37_106<='\b')||LA37_106=='\u000B'||(LA37_106>='\u000E' && LA37_106<='\u001F')||LA37_106=='!'||(LA37_106>='#' && LA37_106<=':')||(LA37_106>='<' && LA37_106<='\uFFFF')) ) {s = 10;}

                        else s = 84;

                        if ( s>=0 ) return s;
                        break;
                    case 13 : 
                        int LA37_72 = input.LA(1);

                        s = -1;
                        if ( ((LA37_72>='\u0000' && LA37_72<='\b')||LA37_72=='\u000B'||(LA37_72>='\u000E' && LA37_72<='\u001F')||LA37_72=='!'||(LA37_72>='#' && LA37_72<=':')||(LA37_72>='<' && LA37_72<='\uFFFF')) ) {s = 10;}

                        else s = 43;

                        if ( s>=0 ) return s;
                        break;
                    case 14 : 
                        int LA37_20 = input.LA(1);

                        s = -1;
                        if ( (LA37_20==' ') ) {s = 28;}

                        else if ( (LA37_20=='i') ) {s = 29;}

                        else if ( (LA37_20=='t') ) {s = 30;}

                        else if ( (LA37_20=='n') ) {s = 31;}

                        else if ( (LA37_20=='a') ) {s = 32;}

                        else if ( (LA37_20=='p') ) {s = 33;}

                        else if ( (LA37_20=='s') ) {s = 34;}

                        else if ( (LA37_20=='d') ) {s = 35;}

                        else if ( ((LA37_20>='\u0000' && LA37_20<='\b')||LA37_20=='\u000B'||(LA37_20>='\u000E' && LA37_20<='\u001F')||LA37_20=='!'||(LA37_20>='#' && LA37_20<=':')||(LA37_20>='<' && LA37_20<='`')||(LA37_20>='b' && LA37_20<='c')||(LA37_20>='e' && LA37_20<='h')||(LA37_20>='j' && LA37_20<='m')||LA37_20=='o'||(LA37_20>='q' && LA37_20<='r')||(LA37_20>='u' && LA37_20<='\uFFFF')) ) {s = 10;}

                        else s = 27;

                        if ( s>=0 ) return s;
                        break;
                    case 15 : 
                        int LA37_78 = input.LA(1);

                        s = -1;
                        if ( ((LA37_78>='\u0000' && LA37_78<='\b')||LA37_78=='\u000B'||(LA37_78>='\u000E' && LA37_78<='\u001F')||LA37_78=='!'||(LA37_78>='#' && LA37_78<=':')||(LA37_78>='<' && LA37_78<='\uFFFF')) ) {s = 10;}

                        else s = 42;

                        if ( s>=0 ) return s;
                        break;
                    case 16 : 
                        int LA37_65 = input.LA(1);

                        s = -1;
                        if ( (LA37_65==':') ) {s = 72;}

                        else if ( ((LA37_65>='\u0000' && LA37_65<='\b')||LA37_65=='\u000B'||(LA37_65>='\u000E' && LA37_65<='\u001F')||LA37_65=='!'||(LA37_65>='#' && LA37_65<='9')||(LA37_65>='<' && LA37_65<='\uFFFF')) ) {s = 10;}

                        else s = 43;

                        if ( s>=0 ) return s;
                        break;
                    case 17 : 
                        int LA37_37 = input.LA(1);

                        s = -1;
                        if ( ((LA37_37>='\u0000' && LA37_37<='\b')||LA37_37=='\u000B'||(LA37_37>='\u000E' && LA37_37<='\u001F')||LA37_37=='!'||(LA37_37>='#' && LA37_37<=':')||(LA37_37>='<' && LA37_37<='\uFFFF')) ) {s = 10;}

                        else s = 55;

                        if ( s>=0 ) return s;
                        break;
                    case 18 : 
                        int LA37_25 = input.LA(1);

                        s = -1;
                        if ( ((LA37_25>='\u0000' && LA37_25<='\b')||LA37_25=='\u000B'||(LA37_25>='\u000E' && LA37_25<='\u001F')||LA37_25=='!'||(LA37_25>='#' && LA37_25<=':')||(LA37_25>='<' && LA37_25<='\uFFFF')) ) {s = 10;}

                        else s = 39;

                        if ( s>=0 ) return s;
                        break;
                    case 19 : 
                        int LA37_26 = input.LA(1);

                        s = -1;
                        if ( ((LA37_26>='\u0000' && LA37_26<='\b')||LA37_26=='\u000B'||(LA37_26>='\u000E' && LA37_26<='\u001F')||LA37_26=='!'||(LA37_26>='#' && LA37_26<=':')||(LA37_26>='<' && LA37_26<='\uFFFF')) ) {s = 10;}

                        else s = 40;

                        if ( s>=0 ) return s;
                        break;
                    case 20 : 
                        int LA37_117 = input.LA(1);

                        s = -1;
                        if ( ((LA37_117>='\u0000' && LA37_117<='\b')||LA37_117=='\u000B'||(LA37_117>='\u000E' && LA37_117<='\u001F')||LA37_117=='!'||(LA37_117>='#' && LA37_117<=':')||(LA37_117>='<' && LA37_117<='\uFFFF')) ) {s = 10;}

                        else s = 83;

                        if ( s>=0 ) return s;
                        break;
                    case 21 : 
                        int LA37_102 = input.LA(1);

                        s = -1;
                        if ( ((LA37_102>='\u0000' && LA37_102<='\b')||LA37_102=='\u000B'||(LA37_102>='\u000E' && LA37_102<='\u001F')||LA37_102=='!'||(LA37_102>='#' && LA37_102<=':')||(LA37_102>='<' && LA37_102<='\uFFFF')) ) {s = 10;}

                        else s = 42;

                        if ( s>=0 ) return s;
                        break;
                    case 22 : 
                        int LA37_24 = input.LA(1);

                        s = -1;
                        if ( ((LA37_24>='\u0000' && LA37_24<='\b')||LA37_24=='\u000B'||(LA37_24>='\u000E' && LA37_24<='\u001F')||LA37_24=='!'||(LA37_24>='#' && LA37_24<=':')||(LA37_24>='<' && LA37_24<='\uFFFF')) ) {s = 10;}

                        else s = 38;

                        if ( s>=0 ) return s;
                        break;
                    case 23 : 
                        int LA37_15 = input.LA(1);

                        s = -1;
                        if ( (LA37_15=='/') ) {s = 20;}

                        else if ( ((LA37_15>='\u0000' && LA37_15<='\b')||LA37_15=='\u000B'||(LA37_15>='\u000E' && LA37_15<='\u001F')||LA37_15=='!'||(LA37_15>='#' && LA37_15<='.')||(LA37_15>='0' && LA37_15<=':')||(LA37_15>='<' && LA37_15<='\uFFFF')) ) {s = 21;}

                        else if ( (LA37_15=='\t'||LA37_15=='\f'||LA37_15==' '||LA37_15=='\"'||LA37_15==';') ) {s = 22;}

                        else s = 10;

                        if ( s>=0 ) return s;
                        break;
            }
            NoViableAltException nvae =
                new NoViableAltException(getDescription(), 37, _s, input);
            error(nvae);
            throw nvae;
        }
    }
 

}