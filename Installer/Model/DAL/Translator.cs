
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace Installer.Model
{
	public class Translator
	{
		Script _script;
		
		public Translator(Script script)
		{
			_script = script;
		}
		/// <summary>
		/// Fills translator's script with both meta and logic data.
		/// </summary>
		public void Parse()
		{
			// populates the script with all the raw data
			ParseScriptData();

		}
		/// <summary>
		/// Retrieves script data from the parser.
		/// </summary>
		public void ParseScriptData()
		{
			// walk the files to retrieve a list of aliases and commands
			foreach (string fi in _script.Files)
			{
				SourceEval walker = createWalker(fi);
				
				// calls the root method of the parser
				// script contains the map for which order to call files
				walker.prog(_script);
			}
		}
		private SourceEval createWalker(string file)
		{
			ANTLRFileStream stream = new ANTLRFileStream(file);
			SourceExprLexer lex = new SourceExprLexer(stream);
			CommonTokenStream tokens = new CommonTokenStream(lex);
			SourceExprParser parser = new SourceExprParser(tokens);
			SourceExprParser.prog_return r = parser.prog(_script);
			// WALK RESULTING TREE
			CommonTree t = (CommonTree)r.Tree; // get tree from parser
			// Create a tree node stream from resulting tree
			CommonTreeNodeStream nodes = new CommonTreeNodeStream(t);
			SourceEval walker = new SourceEval(nodes); // create a tree parser
			return walker;
		}
	}
}
