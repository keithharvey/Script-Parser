using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Data;
using System.Diagnostics;
using Installer.Properties;
using Installer.View;
using Installer.Model;

namespace Installer.ViewModel
{
	/// <summary>
	/// This WorkspaceViewModel subclass implements save/load
	/// and stores information about the a file, 
	/// which holds all the settings for a single game.
	/// </summary>
	public class MainWindowViewModel : WorkspaceViewModel
	{
		#region Fields

		ReadOnlyCollection<CommandViewModel> _fileCommands;
		ObservableCollection<WorkspaceViewModel> _configurations;

		#endregion // Fields

		#region Properties

		public ObservableCollection<WorkspaceViewModel> Configurations
		{
			get
			{
				if (_configurations == null)
				{
					// initiate the collection
					_configurations = new ObservableCollection<WorkspaceViewModel>();
					// set the event handler for whenever the CollectionChanged triggers
					// inside the ObservableCollection
					_configurations.CollectionChanged += this.OnWorkspacesChanged;

					CreateNewConfiguration();
				}

				return _configurations;
			}
		}

		void OnWorkspacesChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
			if (e.NewItems != null && e.NewItems.Count != 0)
			{
				foreach (WorkspaceViewModel workspace in e.NewItems)
				{
					workspace.OkPressed += this.OnNewConfigFinalized;
					workspace.RequestClose += this.OnWorkspaceRequestClose;
				}
			}

			if (e.OldItems != null && e.OldItems.Count != 0)
				foreach (WorkspaceViewModel workspace in e.OldItems)
					workspace.RequestClose -= this.OnWorkspaceRequestClose;
		}

		void OnWorkspaceRequestClose(object sender, EventArgs e)
		{
			WorkspaceViewModel workspace = sender as WorkspaceViewModel;
			workspace.Dispose();
			this.Configurations.Remove(workspace);
		}

		void OnNewConfigFinalized(object sender, EventArgs e)
		{
			NewConfigurationViewModel newConfig = sender as NewConfigurationViewModel;
			CreateConfiguration(newConfig);
			newConfig.Dispose();
			this.Configurations.Remove(newConfig);
		}

		#endregion // Properties

		#region Constructor

		public MainWindowViewModel()
		{ 
			base.DisplayName = Strings.MainWindowViewModel_DisplayName;
		}

		#endregion // Constructor

		#region Commands

		/// <summary>
		/// Returns a read-only list of commands 
		/// that the UI can display and execute.
		/// </summary>
		public ReadOnlyCollection<CommandViewModel> FileCommands
		{
			get
			{
				if (_fileCommands == null)
				{
					List<CommandViewModel> cmds = this.CreateFileCommands();
					_fileCommands = new ReadOnlyCollection<CommandViewModel>(cmds);
				}

				return _fileCommands;
			}
		}

		List<CommandViewModel> CreateFileCommands()
		{
			return new List<CommandViewModel>
            {
                new CommandViewModel(
                    Strings.MainWindowViewModel_Command_NewConfiguration,
                    new RelayCommand(param => this.CreateNewConfiguration())),
					
                new CommandViewModel(
                    "Open",
                    new RelayCommand(param => this.OpenConfiguration())),

                new CommandViewModel(
                    "Save",
                    new RelayCommand(param => this.SaveConfiguration())),

                new CommandViewModel(
                    "Save As",
                    new RelayCommand(param => this.SaveConfigurationAs())),
					
                new CommandViewModel(
					"Exit",
					base.CloseCommand)
            };
		}

		#endregion // Commands

		#region Private Helpers

		void CreateConfiguration(NewConfigurationViewModel newConfig)
		{
			var viewModel = new ConfigurationViewModel(
                new Configuration(
				newConfig.ConfigurationName, 
				newConfig.Games[newConfig.SelectedGameIndex].Game ) 
                );

			Configurations.Add(viewModel);

			SetActiveWorkspace(viewModel as WorkspaceViewModel);
		}

		void CreateNewConfiguration()
		{
			// Create the ViewModel to which the window binds.
			var viewModel = new NewConfigurationViewModel();

			Configurations.Add(viewModel);

			SetActiveWorkspace(viewModel as WorkspaceViewModel);
		}

		void SaveConfiguration()
		{

		}

		void SaveConfigurationAs()
		{

		}

		void OpenConfiguration()
		{

		}

		void SetActiveWorkspace(WorkspaceViewModel workspace)
		{
			Debug.Assert(this.Configurations.Contains(workspace));

			ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Configurations);
			if (collectionView != null)
				collectionView.MoveCurrentTo(workspace);
		}

		#endregion // Private Helpers
	}


}
