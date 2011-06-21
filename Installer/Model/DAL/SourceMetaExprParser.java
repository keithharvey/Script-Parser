// $ANTLR 3.1.2 C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g 2009-06-27 14:36:58

	using System.Diagnostics;


import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;


import org.antlr.runtime.tree.*;

public class SourceMetaExprParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "ALIAS", "BIND", "RCON", "EXEC", "META", "METADATA", "COMMAND", "TYPE", "SCRIPTINFO", "WHITESPACE", "NEWLINE", "SEMI", "ID", "SCRIPTNAME", "NAME", "TOGGLE", "KEY", "SUBKEY", "DESCRIPTION", "ALTNAME", "ICON", "SL_COMMENT", "WS", "CHARACTER", "'\"'"
    };
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


        public SourceMetaExprParser(TokenStream input) {
            this(input, new RecognizerSharedState());
        }
        public SourceMetaExprParser(TokenStream input, RecognizerSharedState state) {
            super(input, state);
             
        }
        
    protected TreeAdaptor adaptor = new CommonTreeAdaptor();

    public void setTreeAdaptor(TreeAdaptor adaptor) {
        this.adaptor = adaptor;
    }
    public TreeAdaptor getTreeAdaptor() {
        return adaptor;
    }

    public String[] getTokenNames() { return SourceMetaExprParser.tokenNames; }
    public String getGrammarFileName() { return "C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g"; }


    public static class prog_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "prog"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:25:1: prog : ( metaDecl | whiteSpace | NEWLINE )+ ;
    public final SourceMetaExprParser.prog_return prog() throws RecognitionException {
        SourceMetaExprParser.prog_return retval = new SourceMetaExprParser.prog_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token NEWLINE3=null;
        SourceMetaExprParser.metaDecl_return metaDecl1 = null;

        SourceMetaExprParser.whiteSpace_return whiteSpace2 = null;


        CommonTree NEWLINE3_tree=null;

        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:25:6: ( ( metaDecl | whiteSpace | NEWLINE )+ )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:25:9: ( metaDecl | whiteSpace | NEWLINE )+
            {
            root_0 = (CommonTree)adaptor.nil();

            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:25:9: ( metaDecl | whiteSpace | NEWLINE )+
            int cnt1=0;
            loop1:
            do {
                int alt1=4;
                switch ( input.LA(1) ) {
                case SCRIPTNAME:
                case NAME:
                case TOGGLE:
                case KEY:
                case SUBKEY:
                case DESCRIPTION:
                case ALTNAME:
                case ICON:
                    {
                    alt1=1;
                    }
                    break;
                case ALIAS:
                case BIND:
                case RCON:
                case EXEC:
                case ID:
                case 28:
                    {
                    alt1=2;
                    }
                    break;
                case NEWLINE:
                    {
                    alt1=3;
                    }
                    break;

                }

                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:25:11: metaDecl
            	    {
            	    pushFollow(FOLLOW_metaDecl_in_prog102);
            	    metaDecl1=metaDecl();

            	    state._fsp--;

            	    adaptor.addChild(root_0, metaDecl1.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:25:77: whiteSpace
            	    {
            	    pushFollow(FOLLOW_whiteSpace_in_prog108);
            	    whiteSpace2=whiteSpace();

            	    state._fsp--;

            	    adaptor.addChild(root_0, whiteSpace2.getTree());

            	    }
            	    break;
            	case 3 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:25:90: NEWLINE
            	    {
            	    NEWLINE3=(Token)match(input,NEWLINE,FOLLOW_NEWLINE_in_prog112); 

            	    }
            	    break;

            	default :
            	    if ( cnt1 >= 1 ) break loop1;
                        EarlyExitException eee =
                            new EarlyExitException(1, input);
                        throw eee;
                }
                cnt1++;
            } while (true);


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "prog"

    public static class metaDecl_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "metaDecl"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:27:1: metaDecl : ( overallScriptInfo | explicitMetaData | metaData NEWLINE ALIAS id unNeededLineEnding -> ^( ALIAS id metaData ) | metaData NEWLINE ( RCON )? id unNeededLineEnding -> ^( COMMAND id metaData ) );
    public final SourceMetaExprParser.metaDecl_return metaDecl() throws RecognitionException {
        SourceMetaExprParser.metaDecl_return retval = new SourceMetaExprParser.metaDecl_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token NEWLINE7=null;
        Token ALIAS8=null;
        Token NEWLINE12=null;
        Token RCON13=null;
        SourceMetaExprParser.overallScriptInfo_return overallScriptInfo4 = null;

        SourceMetaExprParser.explicitMetaData_return explicitMetaData5 = null;

        SourceMetaExprParser.metaData_return metaData6 = null;

        SourceMetaExprParser.id_return id9 = null;

        SourceMetaExprParser.unNeededLineEnding_return unNeededLineEnding10 = null;

        SourceMetaExprParser.metaData_return metaData11 = null;

        SourceMetaExprParser.id_return id14 = null;

        SourceMetaExprParser.unNeededLineEnding_return unNeededLineEnding15 = null;


        CommonTree NEWLINE7_tree=null;
        CommonTree ALIAS8_tree=null;
        CommonTree NEWLINE12_tree=null;
        CommonTree RCON13_tree=null;
        RewriteRuleTokenStream stream_NEWLINE=new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleTokenStream stream_RCON=new RewriteRuleTokenStream(adaptor,"token RCON");
        RewriteRuleTokenStream stream_ALIAS=new RewriteRuleTokenStream(adaptor,"token ALIAS");
        RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
        RewriteRuleSubtreeStream stream_unNeededLineEnding=new RewriteRuleSubtreeStream(adaptor,"rule unNeededLineEnding");
        RewriteRuleSubtreeStream stream_metaData=new RewriteRuleSubtreeStream(adaptor,"rule metaData");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:27:9: ( overallScriptInfo | explicitMetaData | metaData NEWLINE ALIAS id unNeededLineEnding -> ^( ALIAS id metaData ) | metaData NEWLINE ( RCON )? id unNeededLineEnding -> ^( COMMAND id metaData ) )
            int alt3=4;
            alt3 = dfa3.predict(input);
            switch (alt3) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:27:11: overallScriptInfo
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    pushFollow(FOLLOW_overallScriptInfo_in_metaDecl124);
                    overallScriptInfo4=overallScriptInfo();

                    state._fsp--;

                    adaptor.addChild(root_0, overallScriptInfo4.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:28:4: explicitMetaData
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    pushFollow(FOLLOW_explicitMetaData_in_metaDecl129);
                    explicitMetaData5=explicitMetaData();

                    state._fsp--;

                    adaptor.addChild(root_0, explicitMetaData5.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:29:4: metaData NEWLINE ALIAS id unNeededLineEnding
                    {
                    pushFollow(FOLLOW_metaData_in_metaDecl135);
                    metaData6=metaData();

                    state._fsp--;

                    stream_metaData.add(metaData6.getTree());
                    NEWLINE7=(Token)match(input,NEWLINE,FOLLOW_NEWLINE_in_metaDecl137);  
                    stream_NEWLINE.add(NEWLINE7);

                    ALIAS8=(Token)match(input,ALIAS,FOLLOW_ALIAS_in_metaDecl139);  
                    stream_ALIAS.add(ALIAS8);

                    pushFollow(FOLLOW_id_in_metaDecl141);
                    id9=id();

                    state._fsp--;

                    stream_id.add(id9.getTree());
                    pushFollow(FOLLOW_unNeededLineEnding_in_metaDecl143);
                    unNeededLineEnding10=unNeededLineEnding();

                    state._fsp--;

                    stream_unNeededLineEnding.add(unNeededLineEnding10.getTree());


                    // AST REWRITE
                    // elements: id, ALIAS, metaData
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 29:49: -> ^( ALIAS id metaData )
                    {
                        // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:29:52: ^( ALIAS id metaData )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        root_1 = (CommonTree)adaptor.becomeRoot(stream_ALIAS.nextNode(), root_1);

                        adaptor.addChild(root_1, stream_id.nextTree());
                        adaptor.addChild(root_1, stream_metaData.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:30:4: metaData NEWLINE ( RCON )? id unNeededLineEnding
                    {
                    pushFollow(FOLLOW_metaData_in_metaDecl158);
                    metaData11=metaData();

                    state._fsp--;

                    stream_metaData.add(metaData11.getTree());
                    NEWLINE12=(Token)match(input,NEWLINE,FOLLOW_NEWLINE_in_metaDecl160);  
                    stream_NEWLINE.add(NEWLINE12);

                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:30:21: ( RCON )?
                    int alt2=2;
                    int LA2_0 = input.LA(1);

                    if ( (LA2_0==RCON) ) {
                        alt2=1;
                    }
                    switch (alt2) {
                        case 1 :
                            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:30:21: RCON
                            {
                            RCON13=(Token)match(input,RCON,FOLLOW_RCON_in_metaDecl162);  
                            stream_RCON.add(RCON13);


                            }
                            break;

                    }

                    pushFollow(FOLLOW_id_in_metaDecl165);
                    id14=id();

                    state._fsp--;

                    stream_id.add(id14.getTree());
                    pushFollow(FOLLOW_unNeededLineEnding_in_metaDecl167);
                    unNeededLineEnding15=unNeededLineEnding();

                    state._fsp--;

                    stream_unNeededLineEnding.add(unNeededLineEnding15.getTree());


                    // AST REWRITE
                    // elements: metaData, id
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 30:49: -> ^( COMMAND id metaData )
                    {
                        // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:30:52: ^( COMMAND id metaData )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(COMMAND, "COMMAND"), root_1);

                        adaptor.addChild(root_1, stream_id.nextTree());
                        adaptor.addChild(root_1, stream_metaData.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "metaDecl"

    public static class whiteSpace_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "whiteSpace"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:32:1: whiteSpace : ( ALIAS id unNeededLineEnding -> WHITESPACE | ( RCON )? id unNeededLineEnding -> WHITESPACE | BIND id unNeededLineEnding -> WHITESPACE | ( RCON )? EXEC id unNeededLineEnding -> WHITESPACE );
    public final SourceMetaExprParser.whiteSpace_return whiteSpace() throws RecognitionException {
        SourceMetaExprParser.whiteSpace_return retval = new SourceMetaExprParser.whiteSpace_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token ALIAS16=null;
        Token RCON19=null;
        Token BIND22=null;
        Token RCON25=null;
        Token EXEC26=null;
        SourceMetaExprParser.id_return id17 = null;

        SourceMetaExprParser.unNeededLineEnding_return unNeededLineEnding18 = null;

        SourceMetaExprParser.id_return id20 = null;

        SourceMetaExprParser.unNeededLineEnding_return unNeededLineEnding21 = null;

        SourceMetaExprParser.id_return id23 = null;

        SourceMetaExprParser.unNeededLineEnding_return unNeededLineEnding24 = null;

        SourceMetaExprParser.id_return id27 = null;

        SourceMetaExprParser.unNeededLineEnding_return unNeededLineEnding28 = null;


        CommonTree ALIAS16_tree=null;
        CommonTree RCON19_tree=null;
        CommonTree BIND22_tree=null;
        CommonTree RCON25_tree=null;
        CommonTree EXEC26_tree=null;
        RewriteRuleTokenStream stream_EXEC=new RewriteRuleTokenStream(adaptor,"token EXEC");
        RewriteRuleTokenStream stream_BIND=new RewriteRuleTokenStream(adaptor,"token BIND");
        RewriteRuleTokenStream stream_RCON=new RewriteRuleTokenStream(adaptor,"token RCON");
        RewriteRuleTokenStream stream_ALIAS=new RewriteRuleTokenStream(adaptor,"token ALIAS");
        RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
        RewriteRuleSubtreeStream stream_unNeededLineEnding=new RewriteRuleSubtreeStream(adaptor,"rule unNeededLineEnding");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:33:2: ( ALIAS id unNeededLineEnding -> WHITESPACE | ( RCON )? id unNeededLineEnding -> WHITESPACE | BIND id unNeededLineEnding -> WHITESPACE | ( RCON )? EXEC id unNeededLineEnding -> WHITESPACE )
            int alt6=4;
            switch ( input.LA(1) ) {
            case ALIAS:
                {
                alt6=1;
                }
                break;
            case RCON:
                {
                int LA6_2 = input.LA(2);

                if ( (LA6_2==EXEC) ) {
                    alt6=4;
                }
                else if ( (LA6_2==ID||LA6_2==28) ) {
                    alt6=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 6, 2, input);

                    throw nvae;
                }
                }
                break;
            case ID:
            case 28:
                {
                alt6=2;
                }
                break;
            case BIND:
                {
                alt6=3;
                }
                break;
            case EXEC:
                {
                alt6=4;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 6, 0, input);

                throw nvae;
            }

            switch (alt6) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:33:4: ALIAS id unNeededLineEnding
                    {
                    ALIAS16=(Token)match(input,ALIAS,FOLLOW_ALIAS_in_whiteSpace187);  
                    stream_ALIAS.add(ALIAS16);

                    pushFollow(FOLLOW_id_in_whiteSpace189);
                    id17=id();

                    state._fsp--;

                    stream_id.add(id17.getTree());
                    pushFollow(FOLLOW_unNeededLineEnding_in_whiteSpace191);
                    unNeededLineEnding18=unNeededLineEnding();

                    state._fsp--;

                    stream_unNeededLineEnding.add(unNeededLineEnding18.getTree());


                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 33:32: -> WHITESPACE
                    {
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(WHITESPACE, "WHITESPACE"));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:34:4: ( RCON )? id unNeededLineEnding
                    {
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:34:4: ( RCON )?
                    int alt4=2;
                    int LA4_0 = input.LA(1);

                    if ( (LA4_0==RCON) ) {
                        alt4=1;
                    }
                    switch (alt4) {
                        case 1 :
                            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:34:4: RCON
                            {
                            RCON19=(Token)match(input,RCON,FOLLOW_RCON_in_whiteSpace201);  
                            stream_RCON.add(RCON19);


                            }
                            break;

                    }

                    pushFollow(FOLLOW_id_in_whiteSpace204);
                    id20=id();

                    state._fsp--;

                    stream_id.add(id20.getTree());
                    pushFollow(FOLLOW_unNeededLineEnding_in_whiteSpace206);
                    unNeededLineEnding21=unNeededLineEnding();

                    state._fsp--;

                    stream_unNeededLineEnding.add(unNeededLineEnding21.getTree());


                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 34:32: -> WHITESPACE
                    {
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(WHITESPACE, "WHITESPACE"));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 3 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:35:4: BIND id unNeededLineEnding
                    {
                    BIND22=(Token)match(input,BIND,FOLLOW_BIND_in_whiteSpace216);  
                    stream_BIND.add(BIND22);

                    pushFollow(FOLLOW_id_in_whiteSpace218);
                    id23=id();

                    state._fsp--;

                    stream_id.add(id23.getTree());
                    pushFollow(FOLLOW_unNeededLineEnding_in_whiteSpace220);
                    unNeededLineEnding24=unNeededLineEnding();

                    state._fsp--;

                    stream_unNeededLineEnding.add(unNeededLineEnding24.getTree());


                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 35:31: -> WHITESPACE
                    {
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(WHITESPACE, "WHITESPACE"));

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 4 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:36:4: ( RCON )? EXEC id unNeededLineEnding
                    {
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:36:4: ( RCON )?
                    int alt5=2;
                    int LA5_0 = input.LA(1);

                    if ( (LA5_0==RCON) ) {
                        alt5=1;
                    }
                    switch (alt5) {
                        case 1 :
                            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:36:4: RCON
                            {
                            RCON25=(Token)match(input,RCON,FOLLOW_RCON_in_whiteSpace229);  
                            stream_RCON.add(RCON25);


                            }
                            break;

                    }

                    EXEC26=(Token)match(input,EXEC,FOLLOW_EXEC_in_whiteSpace232);  
                    stream_EXEC.add(EXEC26);

                    pushFollow(FOLLOW_id_in_whiteSpace234);
                    id27=id();

                    state._fsp--;

                    stream_id.add(id27.getTree());
                    pushFollow(FOLLOW_unNeededLineEnding_in_whiteSpace236);
                    unNeededLineEnding28=unNeededLineEnding();

                    state._fsp--;

                    stream_unNeededLineEnding.add(unNeededLineEnding28.getTree());


                    // AST REWRITE
                    // elements: 
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 36:37: -> WHITESPACE
                    {
                        adaptor.addChild(root_0, (CommonTree)adaptor.create(WHITESPACE, "WHITESPACE"));

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "whiteSpace"

    public static class unNeededLineEnding_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unNeededLineEnding"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:38:1: unNeededLineEnding : ( '\"' | SEMI | RCON | EXEC | BIND | ID | ALIAS )* ( NEWLINE | EOF ) ;
    public final SourceMetaExprParser.unNeededLineEnding_return unNeededLineEnding() throws RecognitionException {
        SourceMetaExprParser.unNeededLineEnding_return retval = new SourceMetaExprParser.unNeededLineEnding_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token set29=null;
        Token set30=null;

        CommonTree set29_tree=null;
        CommonTree set30_tree=null;

        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:39:2: ( ( '\"' | SEMI | RCON | EXEC | BIND | ID | ALIAS )* ( NEWLINE | EOF ) )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:39:4: ( '\"' | SEMI | RCON | EXEC | BIND | ID | ALIAS )* ( NEWLINE | EOF )
            {
            root_0 = (CommonTree)adaptor.nil();

            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:39:4: ( '\"' | SEMI | RCON | EXEC | BIND | ID | ALIAS )*
            loop7:
            do {
                int alt7=2;
                int LA7_0 = input.LA(1);

                if ( ((LA7_0>=ALIAS && LA7_0<=EXEC)||(LA7_0>=SEMI && LA7_0<=ID)||LA7_0==28) ) {
                    alt7=1;
                }


                switch (alt7) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:
            	    {
            	    set29=(Token)input.LT(1);
            	    if ( (input.LA(1)>=ALIAS && input.LA(1)<=EXEC)||(input.LA(1)>=SEMI && input.LA(1)<=ID)||input.LA(1)==28 ) {
            	        input.consume();
            	        adaptor.addChild(root_0, (CommonTree)adaptor.create(set29));
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        throw mse;
            	    }


            	    }
            	    break;

            	default :
            	    break loop7;
                }
            } while (true);

            set30=(Token)input.LT(1);
            if ( input.LA(1)==EOF||input.LA(1)==NEWLINE ) {
                input.consume();
                adaptor.addChild(root_0, (CommonTree)adaptor.create(set30));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "unNeededLineEnding"

    public static class overallScriptInfo_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "overallScriptInfo"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:42:1: overallScriptInfo : ( overallNameStat linebreak descStat linebreak -> ^( SCRIPTINFO overallNameStat descStat ) | overallNameStat linebreak -> ^( SCRIPTINFO overallNameStat ) );
    public final SourceMetaExprParser.overallScriptInfo_return overallScriptInfo() throws RecognitionException {
        SourceMetaExprParser.overallScriptInfo_return retval = new SourceMetaExprParser.overallScriptInfo_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        SourceMetaExprParser.overallNameStat_return overallNameStat31 = null;

        SourceMetaExprParser.linebreak_return linebreak32 = null;

        SourceMetaExprParser.descStat_return descStat33 = null;

        SourceMetaExprParser.linebreak_return linebreak34 = null;

        SourceMetaExprParser.overallNameStat_return overallNameStat35 = null;

        SourceMetaExprParser.linebreak_return linebreak36 = null;


        RewriteRuleSubtreeStream stream_overallNameStat=new RewriteRuleSubtreeStream(adaptor,"rule overallNameStat");
        RewriteRuleSubtreeStream stream_linebreak=new RewriteRuleSubtreeStream(adaptor,"rule linebreak");
        RewriteRuleSubtreeStream stream_descStat=new RewriteRuleSubtreeStream(adaptor,"rule descStat");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:43:2: ( overallNameStat linebreak descStat linebreak -> ^( SCRIPTINFO overallNameStat descStat ) | overallNameStat linebreak -> ^( SCRIPTINFO overallNameStat ) )
            int alt8=2;
            alt8 = dfa8.predict(input);
            switch (alt8) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:43:4: overallNameStat linebreak descStat linebreak
                    {
                    pushFollow(FOLLOW_overallNameStat_in_overallScriptInfo296);
                    overallNameStat31=overallNameStat();

                    state._fsp--;

                    stream_overallNameStat.add(overallNameStat31.getTree());
                    pushFollow(FOLLOW_linebreak_in_overallScriptInfo298);
                    linebreak32=linebreak();

                    state._fsp--;

                    stream_linebreak.add(linebreak32.getTree());
                    pushFollow(FOLLOW_descStat_in_overallScriptInfo300);
                    descStat33=descStat();

                    state._fsp--;

                    stream_descStat.add(descStat33.getTree());
                    pushFollow(FOLLOW_linebreak_in_overallScriptInfo302);
                    linebreak34=linebreak();

                    state._fsp--;

                    stream_linebreak.add(linebreak34.getTree());


                    // AST REWRITE
                    // elements: overallNameStat, descStat
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 44:2: -> ^( SCRIPTINFO overallNameStat descStat )
                    {
                        // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:44:5: ^( SCRIPTINFO overallNameStat descStat )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(SCRIPTINFO, "SCRIPTINFO"), root_1);

                        adaptor.addChild(root_1, stream_overallNameStat.nextTree());
                        adaptor.addChild(root_1, stream_descStat.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:45:4: overallNameStat linebreak
                    {
                    pushFollow(FOLLOW_overallNameStat_in_overallScriptInfo318);
                    overallNameStat35=overallNameStat();

                    state._fsp--;

                    stream_overallNameStat.add(overallNameStat35.getTree());
                    pushFollow(FOLLOW_linebreak_in_overallScriptInfo320);
                    linebreak36=linebreak();

                    state._fsp--;

                    stream_linebreak.add(linebreak36.getTree());


                    // AST REWRITE
                    // elements: overallNameStat
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 46:2: -> ^( SCRIPTINFO overallNameStat )
                    {
                        // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:46:5: ^( SCRIPTINFO overallNameStat )
                        {
                        CommonTree root_1 = (CommonTree)adaptor.nil();
                        root_1 = (CommonTree)adaptor.becomeRoot((CommonTree)adaptor.create(SCRIPTINFO, "SCRIPTINFO"), root_1);

                        adaptor.addChild(root_1, stream_overallNameStat.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "overallScriptInfo"

    public static class overallNameStat_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "overallNameStat"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:48:1: overallNameStat : SCRIPTNAME ( id )+ -> ^( SCRIPTNAME ( id )+ ) ;
    public final SourceMetaExprParser.overallNameStat_return overallNameStat() throws RecognitionException {
        SourceMetaExprParser.overallNameStat_return retval = new SourceMetaExprParser.overallNameStat_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token SCRIPTNAME37=null;
        SourceMetaExprParser.id_return id38 = null;


        CommonTree SCRIPTNAME37_tree=null;
        RewriteRuleTokenStream stream_SCRIPTNAME=new RewriteRuleTokenStream(adaptor,"token SCRIPTNAME");
        RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:49:2: ( SCRIPTNAME ( id )+ -> ^( SCRIPTNAME ( id )+ ) )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:49:4: SCRIPTNAME ( id )+
            {
            SCRIPTNAME37=(Token)match(input,SCRIPTNAME,FOLLOW_SCRIPTNAME_in_overallNameStat339);  
            stream_SCRIPTNAME.add(SCRIPTNAME37);

            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:49:15: ( id )+
            int cnt9=0;
            loop9:
            do {
                int alt9=2;
                int LA9_0 = input.LA(1);

                if ( (LA9_0==ID||LA9_0==28) ) {
                    alt9=1;
                }


                switch (alt9) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:49:15: id
            	    {
            	    pushFollow(FOLLOW_id_in_overallNameStat341);
            	    id38=id();

            	    state._fsp--;

            	    stream_id.add(id38.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt9 >= 1 ) break loop9;
                        EarlyExitException eee =
                            new EarlyExitException(9, input);
                        throw eee;
                }
                cnt9++;
            } while (true);



            // AST REWRITE
            // elements: id, SCRIPTNAME
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 49:19: -> ^( SCRIPTNAME ( id )+ )
            {
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:49:22: ^( SCRIPTNAME ( id )+ )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                root_1 = (CommonTree)adaptor.becomeRoot(stream_SCRIPTNAME.nextNode(), root_1);

                if ( !(stream_id.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_id.hasNext() ) {
                    adaptor.addChild(root_1, stream_id.nextTree());

                }
                stream_id.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "overallNameStat"

    public static class explicitMetaData_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "explicitMetaData"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:52:1: explicitMetaData : NAME id NEWLINE metaData NEWLINE -> ^( NAME id metaData ) ;
    public final SourceMetaExprParser.explicitMetaData_return explicitMetaData() throws RecognitionException {
        SourceMetaExprParser.explicitMetaData_return retval = new SourceMetaExprParser.explicitMetaData_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token NAME39=null;
        Token NEWLINE41=null;
        Token NEWLINE43=null;
        SourceMetaExprParser.id_return id40 = null;

        SourceMetaExprParser.metaData_return metaData42 = null;


        CommonTree NAME39_tree=null;
        CommonTree NEWLINE41_tree=null;
        CommonTree NEWLINE43_tree=null;
        RewriteRuleTokenStream stream_NAME=new RewriteRuleTokenStream(adaptor,"token NAME");
        RewriteRuleTokenStream stream_NEWLINE=new RewriteRuleTokenStream(adaptor,"token NEWLINE");
        RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
        RewriteRuleSubtreeStream stream_metaData=new RewriteRuleSubtreeStream(adaptor,"rule metaData");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:53:2: ( NAME id NEWLINE metaData NEWLINE -> ^( NAME id metaData ) )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:53:4: NAME id NEWLINE metaData NEWLINE
            {
            NAME39=(Token)match(input,NAME,FOLLOW_NAME_in_explicitMetaData362);  
            stream_NAME.add(NAME39);

            pushFollow(FOLLOW_id_in_explicitMetaData364);
            id40=id();

            state._fsp--;

            stream_id.add(id40.getTree());
            NEWLINE41=(Token)match(input,NEWLINE,FOLLOW_NEWLINE_in_explicitMetaData366);  
            stream_NEWLINE.add(NEWLINE41);

            pushFollow(FOLLOW_metaData_in_explicitMetaData368);
            metaData42=metaData();

            state._fsp--;

            stream_metaData.add(metaData42.getTree());
            NEWLINE43=(Token)match(input,NEWLINE,FOLLOW_NEWLINE_in_explicitMetaData370);  
            stream_NEWLINE.add(NEWLINE43);



            // AST REWRITE
            // elements: metaData, id, NAME
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 53:37: -> ^( NAME id metaData )
            {
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:53:40: ^( NAME id metaData )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                root_1 = (CommonTree)adaptor.becomeRoot(stream_NAME.nextNode(), root_1);

                adaptor.addChild(root_1, stream_id.nextTree());
                adaptor.addChild(root_1, stream_metaData.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "explicitMetaData"

    public static class metaData_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "metaData"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:55:1: metaData : metaStat ( linebreak metaStat )* -> ( metaStat )+ ;
    public final SourceMetaExprParser.metaData_return metaData() throws RecognitionException {
        SourceMetaExprParser.metaData_return retval = new SourceMetaExprParser.metaData_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        SourceMetaExprParser.metaStat_return metaStat44 = null;

        SourceMetaExprParser.linebreak_return linebreak45 = null;

        SourceMetaExprParser.metaStat_return metaStat46 = null;


        RewriteRuleSubtreeStream stream_metaStat=new RewriteRuleSubtreeStream(adaptor,"rule metaStat");
        RewriteRuleSubtreeStream stream_linebreak=new RewriteRuleSubtreeStream(adaptor,"rule linebreak");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:55:9: ( metaStat ( linebreak metaStat )* -> ( metaStat )+ )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:55:11: metaStat ( linebreak metaStat )*
            {
            pushFollow(FOLLOW_metaStat_in_metaData388);
            metaStat44=metaStat();

            state._fsp--;

            stream_metaStat.add(metaStat44.getTree());
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:55:20: ( linebreak metaStat )*
            loop10:
            do {
                int alt10=2;
                alt10 = dfa10.predict(input);
                switch (alt10) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:55:21: linebreak metaStat
            	    {
            	    pushFollow(FOLLOW_linebreak_in_metaData391);
            	    linebreak45=linebreak();

            	    state._fsp--;

            	    stream_linebreak.add(linebreak45.getTree());
            	    pushFollow(FOLLOW_metaStat_in_metaData393);
            	    metaStat46=metaStat();

            	    state._fsp--;

            	    stream_metaStat.add(metaStat46.getTree());

            	    }
            	    break;

            	default :
            	    break loop10;
                }
            } while (true);



            // AST REWRITE
            // elements: metaStat
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 55:42: -> ( metaStat )+
            {
                if ( !(stream_metaStat.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_metaStat.hasNext() ) {
                    adaptor.addChild(root_0, stream_metaStat.nextTree());

                }
                stream_metaStat.reset();

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "metaData"

    public static class metaStat_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "metaStat"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:57:1: metaStat : ( typeStat | descStat | iconStat | altNameStat );
    public final SourceMetaExprParser.metaStat_return metaStat() throws RecognitionException {
        SourceMetaExprParser.metaStat_return retval = new SourceMetaExprParser.metaStat_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        SourceMetaExprParser.typeStat_return typeStat47 = null;

        SourceMetaExprParser.descStat_return descStat48 = null;

        SourceMetaExprParser.iconStat_return iconStat49 = null;

        SourceMetaExprParser.altNameStat_return altNameStat50 = null;



        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:57:9: ( typeStat | descStat | iconStat | altNameStat )
            int alt11=4;
            switch ( input.LA(1) ) {
            case TOGGLE:
            case KEY:
            case SUBKEY:
                {
                alt11=1;
                }
                break;
            case DESCRIPTION:
                {
                alt11=2;
                }
                break;
            case ICON:
                {
                alt11=3;
                }
                break;
            case ALTNAME:
                {
                alt11=4;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 11, 0, input);

                throw nvae;
            }

            switch (alt11) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:57:11: typeStat
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    pushFollow(FOLLOW_typeStat_in_metaStat408);
                    typeStat47=typeStat();

                    state._fsp--;

                    adaptor.addChild(root_0, typeStat47.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:58:4: descStat
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    pushFollow(FOLLOW_descStat_in_metaStat413);
                    descStat48=descStat();

                    state._fsp--;

                    adaptor.addChild(root_0, descStat48.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:59:4: iconStat
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    pushFollow(FOLLOW_iconStat_in_metaStat418);
                    iconStat49=iconStat();

                    state._fsp--;

                    adaptor.addChild(root_0, iconStat49.getTree());

                    }
                    break;
                case 4 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:60:4: altNameStat
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    pushFollow(FOLLOW_altNameStat_in_metaStat423);
                    altNameStat50=altNameStat();

                    state._fsp--;

                    adaptor.addChild(root_0, altNameStat50.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "metaStat"

    public static class typeStat_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "typeStat"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:62:1: typeStat : ( TOGGLE -> TOGGLE | KEY -> KEY | SUBKEY -> SUBKEY );
    public final SourceMetaExprParser.typeStat_return typeStat() throws RecognitionException {
        SourceMetaExprParser.typeStat_return retval = new SourceMetaExprParser.typeStat_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token TOGGLE51=null;
        Token KEY52=null;
        Token SUBKEY53=null;

        CommonTree TOGGLE51_tree=null;
        CommonTree KEY52_tree=null;
        CommonTree SUBKEY53_tree=null;
        RewriteRuleTokenStream stream_SUBKEY=new RewriteRuleTokenStream(adaptor,"token SUBKEY");
        RewriteRuleTokenStream stream_TOGGLE=new RewriteRuleTokenStream(adaptor,"token TOGGLE");
        RewriteRuleTokenStream stream_KEY=new RewriteRuleTokenStream(adaptor,"token KEY");

        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:62:9: ( TOGGLE -> TOGGLE | KEY -> KEY | SUBKEY -> SUBKEY )
            int alt12=3;
            switch ( input.LA(1) ) {
            case TOGGLE:
                {
                alt12=1;
                }
                break;
            case KEY:
                {
                alt12=2;
                }
                break;
            case SUBKEY:
                {
                alt12=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 12, 0, input);

                throw nvae;
            }

            switch (alt12) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:62:11: TOGGLE
                    {
                    TOGGLE51=(Token)match(input,TOGGLE,FOLLOW_TOGGLE_in_typeStat431);  
                    stream_TOGGLE.add(TOGGLE51);



                    // AST REWRITE
                    // elements: TOGGLE
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 62:18: -> TOGGLE
                    {
                        adaptor.addChild(root_0, stream_TOGGLE.nextNode());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:63:4: KEY
                    {
                    KEY52=(Token)match(input,KEY,FOLLOW_KEY_in_typeStat440);  
                    stream_KEY.add(KEY52);



                    // AST REWRITE
                    // elements: KEY
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 63:8: -> KEY
                    {
                        adaptor.addChild(root_0, stream_KEY.nextNode());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 3 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:64:4: SUBKEY
                    {
                    SUBKEY53=(Token)match(input,SUBKEY,FOLLOW_SUBKEY_in_typeStat449);  
                    stream_SUBKEY.add(SUBKEY53);



                    // AST REWRITE
                    // elements: SUBKEY
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (CommonTree)adaptor.nil();
                    // 64:11: -> SUBKEY
                    {
                        adaptor.addChild(root_0, stream_SUBKEY.nextNode());

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "typeStat"

    public static class descStat_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "descStat"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:66:1: descStat : DESCRIPTION ( id )+ -> ^( DESCRIPTION ( id )+ ) ;
    public final SourceMetaExprParser.descStat_return descStat() throws RecognitionException {
        SourceMetaExprParser.descStat_return retval = new SourceMetaExprParser.descStat_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token DESCRIPTION54=null;
        SourceMetaExprParser.id_return id55 = null;


        CommonTree DESCRIPTION54_tree=null;
        RewriteRuleTokenStream stream_DESCRIPTION=new RewriteRuleTokenStream(adaptor,"token DESCRIPTION");
        RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:66:9: ( DESCRIPTION ( id )+ -> ^( DESCRIPTION ( id )+ ) )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:66:11: DESCRIPTION ( id )+
            {
            DESCRIPTION54=(Token)match(input,DESCRIPTION,FOLLOW_DESCRIPTION_in_descStat461);  
            stream_DESCRIPTION.add(DESCRIPTION54);

            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:66:23: ( id )+
            int cnt13=0;
            loop13:
            do {
                int alt13=2;
                int LA13_0 = input.LA(1);

                if ( (LA13_0==ID||LA13_0==28) ) {
                    alt13=1;
                }


                switch (alt13) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:66:23: id
            	    {
            	    pushFollow(FOLLOW_id_in_descStat463);
            	    id55=id();

            	    state._fsp--;

            	    stream_id.add(id55.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt13 >= 1 ) break loop13;
                        EarlyExitException eee =
                            new EarlyExitException(13, input);
                        throw eee;
                }
                cnt13++;
            } while (true);



            // AST REWRITE
            // elements: id, DESCRIPTION
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 66:27: -> ^( DESCRIPTION ( id )+ )
            {
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:66:30: ^( DESCRIPTION ( id )+ )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                root_1 = (CommonTree)adaptor.becomeRoot(stream_DESCRIPTION.nextNode(), root_1);

                if ( !(stream_id.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_id.hasNext() ) {
                    adaptor.addChild(root_1, stream_id.nextTree());

                }
                stream_id.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "descStat"

    public static class altNameStat_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "altNameStat"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:68:1: altNameStat : ALTNAME ( id )+ -> ^( ALTNAME ( id )+ ) ;
    public final SourceMetaExprParser.altNameStat_return altNameStat() throws RecognitionException {
        SourceMetaExprParser.altNameStat_return retval = new SourceMetaExprParser.altNameStat_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token ALTNAME56=null;
        SourceMetaExprParser.id_return id57 = null;


        CommonTree ALTNAME56_tree=null;
        RewriteRuleTokenStream stream_ALTNAME=new RewriteRuleTokenStream(adaptor,"token ALTNAME");
        RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:69:2: ( ALTNAME ( id )+ -> ^( ALTNAME ( id )+ ) )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:69:4: ALTNAME ( id )+
            {
            ALTNAME56=(Token)match(input,ALTNAME,FOLLOW_ALTNAME_in_altNameStat483);  
            stream_ALTNAME.add(ALTNAME56);

            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:69:12: ( id )+
            int cnt14=0;
            loop14:
            do {
                int alt14=2;
                int LA14_0 = input.LA(1);

                if ( (LA14_0==ID||LA14_0==28) ) {
                    alt14=1;
                }


                switch (alt14) {
            	case 1 :
            	    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:69:12: id
            	    {
            	    pushFollow(FOLLOW_id_in_altNameStat485);
            	    id57=id();

            	    state._fsp--;

            	    stream_id.add(id57.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt14 >= 1 ) break loop14;
                        EarlyExitException eee =
                            new EarlyExitException(14, input);
                        throw eee;
                }
                cnt14++;
            } while (true);



            // AST REWRITE
            // elements: id, ALTNAME
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 69:16: -> ^( ALTNAME ( id )+ )
            {
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:69:19: ^( ALTNAME ( id )+ )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                root_1 = (CommonTree)adaptor.becomeRoot(stream_ALTNAME.nextNode(), root_1);

                if ( !(stream_id.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_id.hasNext() ) {
                    adaptor.addChild(root_1, stream_id.nextTree());

                }
                stream_id.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "altNameStat"

    public static class iconStat_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "iconStat"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:71:1: iconStat : ICON id -> ^( ICON id ) ;
    public final SourceMetaExprParser.iconStat_return iconStat() throws RecognitionException {
        SourceMetaExprParser.iconStat_return retval = new SourceMetaExprParser.iconStat_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token ICON58=null;
        SourceMetaExprParser.id_return id59 = null;


        CommonTree ICON58_tree=null;
        RewriteRuleTokenStream stream_ICON=new RewriteRuleTokenStream(adaptor,"token ICON");
        RewriteRuleSubtreeStream stream_id=new RewriteRuleSubtreeStream(adaptor,"rule id");
        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:72:2: ( ICON id -> ^( ICON id ) )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:72:4: ICON id
            {
            ICON58=(Token)match(input,ICON,FOLLOW_ICON_in_iconStat505);  
            stream_ICON.add(ICON58);

            pushFollow(FOLLOW_id_in_iconStat507);
            id59=id();

            state._fsp--;

            stream_id.add(id59.getTree());


            // AST REWRITE
            // elements: ICON, id
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (CommonTree)adaptor.nil();
            // 72:12: -> ^( ICON id )
            {
                // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:72:15: ^( ICON id )
                {
                CommonTree root_1 = (CommonTree)adaptor.nil();
                root_1 = (CommonTree)adaptor.becomeRoot(stream_ICON.nextNode(), root_1);

                adaptor.addChild(root_1, stream_id.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "iconStat"

    public static class id_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "id"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:74:1: id : ( '\"' ID '\"' | ID );
    public final SourceMetaExprParser.id_return id() throws RecognitionException {
        SourceMetaExprParser.id_return retval = new SourceMetaExprParser.id_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token char_literal60=null;
        Token ID61=null;
        Token char_literal62=null;
        Token ID63=null;

        CommonTree char_literal60_tree=null;
        CommonTree ID61_tree=null;
        CommonTree char_literal62_tree=null;
        CommonTree ID63_tree=null;

        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:74:4: ( '\"' ID '\"' | ID )
            int alt15=2;
            int LA15_0 = input.LA(1);

            if ( (LA15_0==28) ) {
                alt15=1;
            }
            else if ( (LA15_0==ID) ) {
                alt15=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 15, 0, input);

                throw nvae;
            }
            switch (alt15) {
                case 1 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:74:6: '\"' ID '\"'
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    char_literal60=(Token)match(input,28,FOLLOW_28_in_id524); 
                    ID61=(Token)match(input,ID,FOLLOW_ID_in_id527); 
                    ID61_tree = (CommonTree)adaptor.create(ID61);
                    adaptor.addChild(root_0, ID61_tree);

                    char_literal62=(Token)match(input,28,FOLLOW_28_in_id529); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:75:4: ID
                    {
                    root_0 = (CommonTree)adaptor.nil();

                    ID63=(Token)match(input,ID,FOLLOW_ID_in_id535); 
                    ID63_tree = (CommonTree)adaptor.create(ID63);
                    adaptor.addChild(root_0, ID63_tree);


                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "id"

    public static class linebreak_return extends ParserRuleReturnScope {
        CommonTree tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "linebreak"
    // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:77:1: linebreak : ( SEMI | NEWLINE );
    public final SourceMetaExprParser.linebreak_return linebreak() throws RecognitionException {
        SourceMetaExprParser.linebreak_return retval = new SourceMetaExprParser.linebreak_return();
        retval.start = input.LT(1);

        CommonTree root_0 = null;

        Token set64=null;

        CommonTree set64_tree=null;

        try {
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:78:2: ( SEMI | NEWLINE )
            // C:\\Users\\Administrator\\Projects\\config\\Installer\\Installer\\Model\\DAL\\SourceMetaExpr.g:
            {
            root_0 = (CommonTree)adaptor.nil();

            set64=(Token)input.LT(1);
            if ( (input.LA(1)>=NEWLINE && input.LA(1)<=SEMI) ) {
                input.consume();
                adaptor.addChild(root_0, (CommonTree)adaptor.create(set64));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (CommonTree)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (CommonTree)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        return retval;
    }
    // $ANTLR end "linebreak"

    // Delegated rules


    protected DFA3 dfa3 = new DFA3(this);
    protected DFA8 dfa8 = new DFA8(this);
    protected DFA10 dfa10 = new DFA10(this);
    static final String DFA3_eotS =
        "\53\uffff";
    static final String DFA3_eofS =
        "\53\uffff";
    static final String DFA3_minS =
        "\1\21\2\uffff\3\16\3\20\1\4\1\23\1\20\1\16\1\20\1\16\1\20\1\16"+
        "\2\uffff\3\16\3\20\3\34\1\20\1\16\1\20\1\16\1\20\4\16\3\34\3\16";
    static final String DFA3_maxS =
        "\1\30\2\uffff\3\17\4\34\1\30\1\20\1\34\1\20\1\17\1\20\1\34\2\uffff"+
        "\3\17\6\34\1\20\1\34\1\20\1\17\1\20\2\34\1\17\5\34\1\17\1\34";
    static final String DFA3_acceptS =
        "\1\uffff\1\1\1\2\16\uffff\1\3\1\4\30\uffff";
    static final String DFA3_specialS =
        "\53\uffff}>";
    static final String[] DFA3_transitionS = {
            "\1\1\1\2\1\3\1\4\1\5\1\6\1\10\1\7",
            "",
            "",
            "\1\11\1\12",
            "\1\11\1\12",
            "\1\11\1\12",
            "\1\14\13\uffff\1\13",
            "\1\16\13\uffff\1\15",
            "\1\20\13\uffff\1\17",
            "\1\21\1\uffff\1\22\11\uffff\1\22\2\uffff\1\23\1\24\1\25\1"+
            "\26\1\30\1\27\3\uffff\1\22",
            "\1\23\1\24\1\25\1\26\1\30\1\27",
            "\1\31",
            "\1\11\1\12\1\14\13\uffff\1\13",
            "\1\32",
            "\1\11\1\12",
            "\1\33",
            "\1\11\1\12\1\20\13\uffff\1\17",
            "",
            "",
            "\1\11\1\12",
            "\1\11\1\12",
            "\1\11\1\12",
            "\1\35\13\uffff\1\34",
            "\1\37\13\uffff\1\36",
            "\1\41\13\uffff\1\40",
            "\1\42",
            "\1\43",
            "\1\44",
            "\1\45",
            "\1\11\1\12\1\35\13\uffff\1\34",
            "\1\46",
            "\1\11\1\12",
            "\1\47",
            "\1\11\1\12\1\41\13\uffff\1\40",
            "\1\11\1\12\1\14\13\uffff\1\13",
            "\1\11\1\12",
            "\1\11\1\12\1\20\13\uffff\1\17",
            "\1\50",
            "\1\51",
            "\1\52",
            "\1\11\1\12\1\35\13\uffff\1\34",
            "\1\11\1\12",
            "\1\11\1\12\1\41\13\uffff\1\40"
    };

    static final short[] DFA3_eot = DFA.unpackEncodedString(DFA3_eotS);
    static final short[] DFA3_eof = DFA.unpackEncodedString(DFA3_eofS);
    static final char[] DFA3_min = DFA.unpackEncodedStringToUnsignedChars(DFA3_minS);
    static final char[] DFA3_max = DFA.unpackEncodedStringToUnsignedChars(DFA3_maxS);
    static final short[] DFA3_accept = DFA.unpackEncodedString(DFA3_acceptS);
    static final short[] DFA3_special = DFA.unpackEncodedString(DFA3_specialS);
    static final short[][] DFA3_transition;

    static {
        int numStates = DFA3_transitionS.length;
        DFA3_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA3_transition[i] = DFA.unpackEncodedString(DFA3_transitionS[i]);
        }
    }

    class DFA3 extends DFA {

        public DFA3(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;
        }
        public String getDescription() {
            return "27:1: metaDecl : ( overallScriptInfo | explicitMetaData | metaData NEWLINE ALIAS id unNeededLineEnding -> ^( ALIAS id metaData ) | metaData NEWLINE ( RCON )? id unNeededLineEnding -> ^( COMMAND id metaData ) );";
        }
    }
    static final String DFA8_eotS =
        "\57\uffff";
    static final String DFA8_eofS =
        "\5\uffff\1\10\6\uffff\2\22\12\uffff\1\43\1\uffff\1\46\7\uffff\1"+
        "\43\2\uffff\1\46\4\uffff\1\43\1\46\3\uffff";
    static final String DFA8_minS =
        "\1\21\2\20\1\16\1\34\1\4\1\16\1\20\1\uffff\1\20\1\16\1\34\2\4\1"+
        "\16\1\20\3\uffff\3\20\1\7\1\20\1\4\1\20\1\4\1\20\1\uffff\1\20\1"+
        "\uffff\1\20\1\uffff\1\34\1\4\1\uffff\1\34\1\4\1\uffff\3\34\2\4\3"+
        "\uffff";
    static final String DFA8_maxS =
        "\1\21\1\34\1\20\5\34\1\uffff\1\20\6\34\3\uffff\4\34\1\20\1\34\1"+
        "\20\1\34\1\20\1\uffff\1\20\1\uffff\1\20\1\uffff\2\34\1\uffff\2\34"+
        "\1\uffff\5\34\3\uffff";
    static final String DFA8_acceptS =
        "\10\uffff\1\2\7\uffff\3\1\11\uffff\1\1\1\uffff\1\1\1\uffff\1\1"+
        "\2\uffff\1\1\2\uffff\1\1\5\uffff\3\1";
    static final String DFA8_specialS =
        "\57\uffff}>";
    static final String[] DFA8_transitionS = {
            "\1\1",
            "\1\3\13\uffff\1\2",
            "\1\4",
            "\2\5\1\3\13\uffff\1\2",
            "\1\6",
            "\4\10\6\uffff\1\10\1\uffff\6\10\1\7\2\10\3\uffff\1\10",
            "\2\5\1\3\13\uffff\1\2",
            "\1\12\13\uffff\1\11",
            "",
            "\1\13",
            "\1\14\1\15\1\12\13\uffff\1\11",
            "\1\16",
            "\1\17\1\22\1\26\1\22\6\uffff\1\22\1\uffff\1\30\2\22\1\20\1"+
            "\21\1\22\1\23\1\25\1\24\3\uffff\1\27",
            "\4\22\6\uffff\1\22\1\uffff\3\22\1\20\1\21\1\22\1\23\1\25\1"+
            "\24\3\uffff\1\22",
            "\1\14\1\15\1\12\13\uffff\1\11",
            "\1\32\13\uffff\1\31",
            "",
            "",
            "",
            "\1\34\13\uffff\1\33",
            "\1\36\13\uffff\1\35",
            "\1\40\13\uffff\1\37",
            "\1\40\10\uffff\1\30\13\uffff\1\27",
            "\1\41",
            "\4\42\6\uffff\1\43\2\42\13\uffff\1\42",
            "\1\44",
            "\4\45\6\uffff\1\46\2\45\13\uffff\1\45",
            "\1\47",
            "",
            "\1\50",
            "",
            "\1\51",
            "",
            "\1\52",
            "\4\42\6\uffff\1\43\2\42\13\uffff\1\42",
            "",
            "\1\53",
            "\4\45\6\uffff\1\46\2\45\13\uffff\1\45",
            "",
            "\1\54",
            "\1\55",
            "\1\56",
            "\4\42\6\uffff\1\43\2\42\13\uffff\1\42",
            "\4\45\6\uffff\1\46\2\45\13\uffff\1\45",
            "",
            "",
            ""
    };

    static final short[] DFA8_eot = DFA.unpackEncodedString(DFA8_eotS);
    static final short[] DFA8_eof = DFA.unpackEncodedString(DFA8_eofS);
    static final char[] DFA8_min = DFA.unpackEncodedStringToUnsignedChars(DFA8_minS);
    static final char[] DFA8_max = DFA.unpackEncodedStringToUnsignedChars(DFA8_maxS);
    static final short[] DFA8_accept = DFA.unpackEncodedString(DFA8_acceptS);
    static final short[] DFA8_special = DFA.unpackEncodedString(DFA8_specialS);
    static final short[][] DFA8_transition;

    static {
        int numStates = DFA8_transitionS.length;
        DFA8_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA8_transition[i] = DFA.unpackEncodedString(DFA8_transitionS[i]);
        }
    }

    class DFA8 extends DFA {

        public DFA8(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "42:1: overallScriptInfo : ( overallNameStat linebreak descStat linebreak -> ^( SCRIPTINFO overallNameStat descStat ) | overallNameStat linebreak -> ^( SCRIPTINFO overallNameStat ) );";
        }
    }
    static final String DFA10_eotS =
        "\26\uffff";
    static final String DFA10_eofS =
        "\1\uffff\1\3\24\uffff";
    static final String DFA10_minS =
        "\1\16\1\4\5\uffff\4\20\1\uffff\1\20\1\uffff\1\20\1\uffff\3\34\3"+
        "\uffff";
    static final String DFA10_maxS =
        "\1\17\1\34\5\uffff\3\34\1\20\1\uffff\1\20\1\uffff\1\20\1\uffff"+
        "\3\34\3\uffff";
    static final String DFA10_acceptS =
        "\2\uffff\1\1\1\2\3\1\4\uffff\1\1\1\uffff\1\1\1\uffff\1\1\3\uffff"+
        "\3\1";
    static final String DFA10_specialS =
        "\26\uffff}>";
    static final String[] DFA10_transitionS = {
            "\1\1\1\2",
            "\4\3\6\uffff\1\3\1\uffff\3\3\1\4\1\5\1\6\1\7\1\11\1\10\3\uffff"+
            "\1\3",
            "",
            "",
            "",
            "",
            "",
            "\1\13\13\uffff\1\12",
            "\1\15\13\uffff\1\14",
            "\1\17\13\uffff\1\16",
            "\1\20",
            "",
            "\1\21",
            "",
            "\1\22",
            "",
            "\1\23",
            "\1\24",
            "\1\25",
            "",
            "",
            ""
    };

    static final short[] DFA10_eot = DFA.unpackEncodedString(DFA10_eotS);
    static final short[] DFA10_eof = DFA.unpackEncodedString(DFA10_eofS);
    static final char[] DFA10_min = DFA.unpackEncodedStringToUnsignedChars(DFA10_minS);
    static final char[] DFA10_max = DFA.unpackEncodedStringToUnsignedChars(DFA10_maxS);
    static final short[] DFA10_accept = DFA.unpackEncodedString(DFA10_acceptS);
    static final short[] DFA10_special = DFA.unpackEncodedString(DFA10_specialS);
    static final short[][] DFA10_transition;

    static {
        int numStates = DFA10_transitionS.length;
        DFA10_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA10_transition[i] = DFA.unpackEncodedString(DFA10_transitionS[i]);
        }
    }

    class DFA10 extends DFA {

        public DFA10(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;
        }
        public String getDescription() {
            return "()* loopback of 55:20: ( linebreak metaStat )*";
        }
    }
 

    public static final BitSet FOLLOW_metaDecl_in_prog102 = new BitSet(new long[]{0x0000000011FF40F2L});
    public static final BitSet FOLLOW_whiteSpace_in_prog108 = new BitSet(new long[]{0x0000000011FF40F2L});
    public static final BitSet FOLLOW_NEWLINE_in_prog112 = new BitSet(new long[]{0x0000000011FF40F2L});
    public static final BitSet FOLLOW_overallScriptInfo_in_metaDecl124 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_explicitMetaData_in_metaDecl129 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_metaData_in_metaDecl135 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_NEWLINE_in_metaDecl137 = new BitSet(new long[]{0x0000000000000010L});
    public static final BitSet FOLLOW_ALIAS_in_metaDecl139 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_metaDecl141 = new BitSet(new long[]{0x000000001001C0F0L});
    public static final BitSet FOLLOW_unNeededLineEnding_in_metaDecl143 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_metaData_in_metaDecl158 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_NEWLINE_in_metaDecl160 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_RCON_in_metaDecl162 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_metaDecl165 = new BitSet(new long[]{0x000000001001C0F0L});
    public static final BitSet FOLLOW_unNeededLineEnding_in_metaDecl167 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ALIAS_in_whiteSpace187 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_whiteSpace189 = new BitSet(new long[]{0x000000001001C0F0L});
    public static final BitSet FOLLOW_unNeededLineEnding_in_whiteSpace191 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RCON_in_whiteSpace201 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_whiteSpace204 = new BitSet(new long[]{0x000000001001C0F0L});
    public static final BitSet FOLLOW_unNeededLineEnding_in_whiteSpace206 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BIND_in_whiteSpace216 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_whiteSpace218 = new BitSet(new long[]{0x000000001001C0F0L});
    public static final BitSet FOLLOW_unNeededLineEnding_in_whiteSpace220 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_RCON_in_whiteSpace229 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_EXEC_in_whiteSpace232 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_whiteSpace234 = new BitSet(new long[]{0x000000001001C0F0L});
    public static final BitSet FOLLOW_unNeededLineEnding_in_whiteSpace236 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_unNeededLineEnding250 = new BitSet(new long[]{0x000000001001C0F0L});
    public static final BitSet FOLLOW_set_in_unNeededLineEnding279 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_overallNameStat_in_overallScriptInfo296 = new BitSet(new long[]{0x000000000000C000L});
    public static final BitSet FOLLOW_linebreak_in_overallScriptInfo298 = new BitSet(new long[]{0x0000000000400000L});
    public static final BitSet FOLLOW_descStat_in_overallScriptInfo300 = new BitSet(new long[]{0x000000000000C000L});
    public static final BitSet FOLLOW_linebreak_in_overallScriptInfo302 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_overallNameStat_in_overallScriptInfo318 = new BitSet(new long[]{0x000000000000C000L});
    public static final BitSet FOLLOW_linebreak_in_overallScriptInfo320 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SCRIPTNAME_in_overallNameStat339 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_overallNameStat341 = new BitSet(new long[]{0x0000000010010042L});
    public static final BitSet FOLLOW_NAME_in_explicitMetaData362 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_explicitMetaData364 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_NEWLINE_in_explicitMetaData366 = new BitSet(new long[]{0x0000000001F80000L});
    public static final BitSet FOLLOW_metaData_in_explicitMetaData368 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_NEWLINE_in_explicitMetaData370 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_metaStat_in_metaData388 = new BitSet(new long[]{0x000000000000C002L});
    public static final BitSet FOLLOW_linebreak_in_metaData391 = new BitSet(new long[]{0x0000000001F80000L});
    public static final BitSet FOLLOW_metaStat_in_metaData393 = new BitSet(new long[]{0x000000000000C002L});
    public static final BitSet FOLLOW_typeStat_in_metaStat408 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_descStat_in_metaStat413 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_iconStat_in_metaStat418 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_altNameStat_in_metaStat423 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_TOGGLE_in_typeStat431 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_KEY_in_typeStat440 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_SUBKEY_in_typeStat449 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_DESCRIPTION_in_descStat461 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_descStat463 = new BitSet(new long[]{0x0000000010010042L});
    public static final BitSet FOLLOW_ALTNAME_in_altNameStat483 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_altNameStat485 = new BitSet(new long[]{0x0000000010010042L});
    public static final BitSet FOLLOW_ICON_in_iconStat505 = new BitSet(new long[]{0x0000000010010040L});
    public static final BitSet FOLLOW_id_in_iconStat507 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_28_in_id524 = new BitSet(new long[]{0x0000000000010000L});
    public static final BitSet FOLLOW_ID_in_id527 = new BitSet(new long[]{0x0000000010000000L});
    public static final BitSet FOLLOW_28_in_id529 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ID_in_id535 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_linebreak0 = new BitSet(new long[]{0x0000000000000002L});

}