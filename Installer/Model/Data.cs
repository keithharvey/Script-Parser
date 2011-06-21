using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Installer.Model
{
	using System.Diagnostics;
	[Serializable]
	public class Data : INotifyPropertyChanged
	{
		#region Fields

		private string _name;

		#endregion

		#region Properties

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		#endregion

		#region Constructors

		public Data(string name)
		{
			_name = name;
		}

		#endregion

		#region Implementation of INotifyPropertyChanged

		[field: NonSerialized]
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public override int GetHashCode()
		{
			return ((!string.IsNullOrEmpty(Name)) ? Name.GetHashCode() : base.GetHashCode());
		}

		#endregion


	}
}
