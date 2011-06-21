
namespace Installer.Model
{
	public class Configuration
	{
		#region Fields

		string _name;
		Game _game;

		#endregion // Fields

		#region Properties

		public Game Game
		{
			get { return _game; }
		}

		public string Name
		{
			get { return _name;  }
		}

		#endregion // Properties

		#region Constructors

		public Configuration(string name, Game game)
		{
			_game = game;
			_name = name;
		}

		#endregion // Constructors
	}
}
