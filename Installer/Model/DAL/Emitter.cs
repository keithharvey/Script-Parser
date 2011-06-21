using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Installer.Model
{
	class Emitter
	{
		#region Fields

		List<string> _files;
		Script _script;

		#endregion // Fields

		public Emitter(Script script)
		{
			_files = script.Files;
			_script = script;
		}
		/// <summary>
		/// Rewrites a the files using the data from viewData
		/// </summary>
		/// <param name="viewData">Data used to guide rewriting.</param>
		/// <returns>A Dictionary of the file path, string rewritten text<</returns>
		public Dictionary<string, string> Rewrite()
		{
			Dictionary<string, string> emitProduct = new Dictionary<string, string>();
			// walk the files to rewrite where appropriate
			foreach (string fi in _files)
			{
				emitProduct.Add(fi, createRewriter(fi, _script));
			}
			return emitProduct;
		}

		#region Private Helpers

		static string createRewriter(string file, Script script)
		{
			ANTLRFileStream stream = new ANTLRFileStream(file);
			SourceExprLexer lex = new SourceExprLexer(stream);
			// create a buffer of tokens pulled from the lexer
			// Must use TokenRewriteStream not CommonTokenStream!
			TokenRewriteStream tokens = new TokenRewriteStream(lex);
			SourceExprParser parser = new SourceExprParser(tokens);
			SourceExprParser.prog_return r = parser.prog(script);

			// WALK TREE AND REWRITE TOKEN BUFFER
			CommonTree t = (CommonTree)r.Tree; // get tree from parser
			// create a stream of tree nodes from AST built by parser
			CommonTreeNodeStream nodes = new CommonTreeNodeStream(t);
			// tell it where it can find the token objects
			nodes.TokenStream = tokens;
			SourceRewrite rewriter = new SourceRewrite(nodes);
			rewriter.prog(script);
			return tokens.ToString(); // return tweaked token buffer
		}

		#endregion // Private Helpers
	}
}
