using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Installer.Model;
using Microsoft.Win32;
using Installer.Properties;


namespace Installer.Helpers
{
	using System.Diagnostics;
	public class FileHandler
	{
		private static string _root = AppDomain.CurrentDomain.BaseDirectory;
		private static string _files = Path.Combine(_root, Strings.Directory_Games);

		#region Property Getters and Setters
		public string Files { get { return _files; } }
		#endregion
		
		public FileHandler() { }

		public void WriteToFile(string destination, string text)
		{
			File.WriteAllText(destination, text);
		}
		public string GetFileName(string path)
		{
			return Path.GetFileName(path);
		}
		public void CreateFolderStructure(string source, string destination)
		{
			DirectoryInfo diSource = new DirectoryInfo(source);
			DirectoryInfo diDestination = new DirectoryInfo(destination);
			System.IO.FileInfo[] files = null;
			System.IO.DirectoryInfo[] subDirs = null;
			try
			{
				// First, process all the files directly under this folder
				files = diSource.GetFiles("*.*");
			}
			catch (UnauthorizedAccessException e)
			{
				// This code just writes out the message and continues to recurse.
				// You may decide to do something different here. For example, you
				// can try to elevate your privileges and access the file again.
				Debug.WriteLine(e.Message);
			}

			if (files != null)
			{
				if (Directory.Exists(diDestination.FullName) == false)
				{
					Directory.CreateDirectory(diDestination.FullName);
				}

				// Now find all the subdirectories under this directory.
				subDirs = diSource.GetDirectories();

				foreach (DirectoryInfo dirInfo in subDirs)
				{
					DirectoryInfo nextDestinationSubDir = diDestination.CreateSubdirectory(dirInfo.Name);
					// Resursive call for each subdirectory.
					CreateFolderStructure(dirInfo.FullName, nextDestinationSubDir.FullName);
				}
			}
		}
        /// <summary>
        /// Copies a directory recursively.
        /// </summary>
        /// <param name="diSource">source of the copy</param>
        /// <param name="diDestination">destination of the copy</param>
		private static void CopyDirectoryTree(string source, string destination)
		{
			DirectoryInfo diSource = new DirectoryInfo(source);
			DirectoryInfo diDestination = new DirectoryInfo(destination);
			System.IO.FileInfo[] files = null;
			System.IO.DirectoryInfo[] subDirs = null;
			// First, process all the files directly under this folder
			files = diSource.GetFiles("*.*");
			/*
			catch (UnauthorizedAccessException e)
			{
				// This code just writes out the message and continues to recurse.
				// You may decide to do something different here. For example, you
				// can try to elevate your privileges and access the file again.
				log.Add(e.Message);
			}
			 */

			if (files != null)
			{
				if (Directory.Exists(diDestination.FullName) == false)
				{
					Directory.CreateDirectory(diDestination.FullName);
				}

				foreach (System.IO.FileInfo fi in files)
				{
					fi.CopyTo(System.IO.Path.Combine(diDestination.ToString(), fi.Name), true);
				}

				// Now find all the subdirectories under this directory.
				subDirs = diSource.GetDirectories();

				foreach (DirectoryInfo dirInfo in subDirs)
				{
					DirectoryInfo nextDestinationSubDir = diDestination.CreateSubdirectory(dirInfo.Name);
					// Resursive call for each subdirectory.
					CopyDirectoryTree(dirInfo.FullName, nextDestinationSubDir.FullName);
				}
			}
		}
		/// <summary>
		/// Searches a folder for files.
		/// </summary>
		/// <param name="b">folder to search</param>
		/// <returns>returns a list of files</returns>
		public List<string> GetFilesRec(string b)
		{
			// Store results in the file results list.
			List<string> result = new List<string>();

			// Store a stack of our directories.
			Stack<string> stack = new Stack<string>();

			// Add initial directory.
			stack.Push(b);

			// Continue while there are directories to process
			while (stack.Count > 0)
			{
				// Get top directory
				string dir = stack.Pop();

				try
				{
					string[] filesToAdd = Directory.GetFiles(dir, "*.cfg");
					// Add all files at this directory to the result List.
					result.AddRange(filesToAdd);

					// Add all directories at this directory.
					foreach (string dn in Directory.GetDirectories(dir))
					{
						stack.Push(dn);
					}
				}
				catch
				{
					// Could not open the directory
				}
			}
			return result;
		}
		public string[] GetDirectorySubfolders(string source)
		{
			string directoryString = new DirectoryInfo(source).FullName;
			int i = directoryString.LastIndexOf('\\');
			directoryString = directoryString.Remove(i, directoryString.Length - i);
			//Debug.WriteLine("Directories under \"{0}\" are...", directoryString);
			string[] directories = Directory.GetDirectories(directoryString);
			foreach (string directory in directories)
			{
				//Debug.WriteLine("Subdirectory: \"{0}\"", directory); 
			}
			return directories;
		}
		/// <summary>
		/// Reads a registry key and returns the value.
		/// </summary>
		/// <param name="Key">key to be read</param>
		/// <param name="SubKey">subkey, or parameter, of a given key to be read</param>
		/// <returns>Value contained by the key</returns>
		public string ReadKey(string Key, string SubKey)
		{
			RegistryKey regKey;
			string ver = string.Empty;
			try
			{
				regKey = Registry.LocalMachine.OpenSubKey(Key);
				ver = (string)regKey.GetValue(SubKey);
				regKey.Close();
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
			return ver;
		}
	}
}
