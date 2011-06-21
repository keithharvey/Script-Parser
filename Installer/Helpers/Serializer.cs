using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Diagnostics;


using Installer.Model;

namespace Installer.Helpers
{
	class Serializer
	{
		public void Serialize(string location, ViewData viewData)
		{
			// To serialize the hashtable and its key/value pairs,  
			// you must first open a stream for writing. 
			// In this case, use a file stream.
			FileStream fs = new FileStream(location, FileMode.Create);

			// Construct a BinaryFormatter and use it to serialize the data to the stream.
			BinaryFormatter formatter = new BinaryFormatter();
			try
			{
				formatter.Serialize(fs, viewData);
			}
			catch (SerializationException e)
			{
				Debug.WriteLine("Failed to serialize. Reason: " + e.Message);
				throw;
			}
			finally
			{
				fs.Close();
			}
		}
		public ViewData Deserialize(string location)
		{
			// Declare the hashtable reference.
			ViewData viewData = null;

			// Open the file containing the data that you want to deserialize.
			FileStream fs = new FileStream(location, FileMode.Open);
			try
			{
				BinaryFormatter formatter = new BinaryFormatter();

				// Deserialize the hashtable from the file and 
				// assign the reference to the local variable.
				viewData = (ViewData)formatter.Deserialize(fs);
			}
			catch (SerializationException e)
			{
				Debug.WriteLine("Failed to deserialize. Reason: " + e.Message);
				throw;
			}
			finally
			{
				fs.Close();
			}
			return viewData;
		}
	}
}
