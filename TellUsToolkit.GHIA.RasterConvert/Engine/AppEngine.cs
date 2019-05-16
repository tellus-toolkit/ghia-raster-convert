﻿
#region Header

#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using TupleGeo.Apps.Presentation;
using TupleGeo.General.ComponentModel;
using TupleGeo.General.FileSystem;
using TellUsToolkit.GHIA.RasterConverter.Models;
using TellUsToolkit.GHIA.RasterConverter.Models.Application;
using TellUsToolkit.GHIA.RasterConverter.Properties;
using TellUsToolkit.GHIA.RasterConverter.ViewModels;
using TellUsToolkit.GHIA.RasterConverter.Views;

#endregion

namespace TellUsToolkit.GHIA.RasterConverter.Engine {

  /// <summary>
  /// The application engine.
  /// </summary>
  public sealed class AppEngine : ObservableObject<AppEngine> {

    #region Member Variables

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the AppEngine.
    /// </summary>
    private AppEngine() {
      _applicationModel = new ApplicationModel();
      _catalog = new AppCatalog();
      InitializeAppCatalog();
    }

    #endregion

    #region Public Properties

    private static readonly AppEngine _instance = new AppEngine();

    /// <summary>
    /// Gets the instance of the <see cref="AppEngine"/>.
    /// </summary>
    public static AppEngine Instance {
      get {
        return _instance;
      }
    }

    private ApplicationModel _applicationModel;

    /// <summary>
    /// Gets / Sets the <see cref="ApplicationModel"/>.
    /// </summary>
    public ApplicationModel ApplicationModel {
      get {
        return _applicationModel;
      }
      set {
        if (_applicationModel != value) {
          _applicationModel = value;
          this.OnPropertyChanged(m => m.ApplicationModel);
        }
      }
    }

    private AppCatalog _catalog;

    /// <summary>
    /// Gets the <see cref="AppCatalog"/> of the application.
    /// </summary>
    public AppCatalog Catalog {
      get {
        return _catalog;
      }
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Reads the configuration of the application from the configuration file.
    /// </summary>
    public void ReadConfiguration() {
      string configFile = string.Format(
        CultureInfo.InvariantCulture,
        "{0}{1}",
        PathsUtility.AddBackslashToPath(AppDomain.CurrentDomain.BaseDirectory), Settings.Default.ApplicationConfigFile
      );

      // Get the application level information.
      AppEngine.Instance.ApplicationModel = (ApplicationModel)TupleGeo.General.Serialization.XmlSerializer.Deserialize(
        typeof(ApplicationModel),
        configFile
      );
    }

    /// <summary>
    /// Saves the configuration of the application in to the configuration file.
    /// </summary>
    public void SaveConfiguration() {
      string configFile = string.Format(
        CultureInfo.InvariantCulture,
        "{0}{1}",
        PathsUtility.AddBackslashToPath(AppDomain.CurrentDomain.BaseDirectory), Settings.Default.ApplicationConfigFile
      );

      TupleGeo.General.Serialization.XmlSerializer.Serialize(_applicationModel, configFile);
    }

    /// <summary>
    /// Logs an error in to the application error log file.
    /// </summary>
    /// <param name="exception">The <see cref="Exception"/> that has been occurred.</param>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
    public static void LogError(Exception exception) {

      if (exception == null) {
        return;
      }

      string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      string logPath = directory + "\\" +
                       AppEngine.Instance.ApplicationModel.LogSubfolder + "\\" +
                       "Log_" +
                       DateTime.Now.Year.ToString("D2", CultureInfo.InvariantCulture) +
                       "_" +
                       DateTime.Now.Month.ToString("D2", CultureInfo.InvariantCulture) +
                       "_" +
                       DateTime.Now.Day.ToString("D2", CultureInfo.InvariantCulture) +
                       ".txt";

      StreamWriter streamWriter = new StreamWriter(logPath, true);

      try {
        streamWriter.WriteLine("--------");
        streamWriter.WriteLine("Error Time: " + DateTime.Now.ToShortTimeString());
        streamWriter.WriteLine();
        streamWriter.WriteLine("Message: " + exception.Message);
        streamWriter.WriteLine();
        streamWriter.WriteLine("Source: " + exception.Source);
        streamWriter.WriteLine();
        streamWriter.WriteLine("StackTrace: " + exception.StackTrace);
        streamWriter.WriteLine("--------");

        MessageBox.Show(exception.Message, Resources.Application_Error, MessageBoxButton.OK, MessageBoxImage.Error);
      }
      catch {
        // Swallow the error.
      }
      finally {
        streamWriter.Close(); // Close is enough since it calls Dispose internally.
      }

    }

    /// <summary>
    /// Logs an error in to the application error log file.
    /// </summary>
    /// <param name="exception">The <see cref="Exception"/> that has been occurred.</param>
    /// <param name="friendlySource">A friendly source name.</param>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
    public static void LogError(Exception exception, string friendlySource) {

      if (exception == null) {
        return;
      }

      if (friendlySource == null) {
        friendlySource = string.Empty;
      }

      string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
      string logPath = directory + "\\" +
                       AppEngine.Instance.ApplicationModel.LogSubfolder + "\\" +
                       "Log_" +
                       DateTime.Now.Year.ToString("D2", CultureInfo.InvariantCulture) +
                       "_" +
                       DateTime.Now.Month.ToString("D2", CultureInfo.InvariantCulture) +
                       "_" +
                       DateTime.Now.Day.ToString("D2", CultureInfo.InvariantCulture) +
                       ".txt";

      StreamWriter streamWriter = new StreamWriter(logPath, true);

      try {
        streamWriter.WriteLine("--------");
        streamWriter.WriteLine("Error Time: " + DateTime.Now.ToShortTimeString());
        streamWriter.WriteLine();
        streamWriter.WriteLine("Message: " + exception.Message);
        streamWriter.WriteLine();
        streamWriter.WriteLine("Friendly Source: " + friendlySource);
        streamWriter.WriteLine();
        streamWriter.WriteLine("Source: " + exception.Source);
        streamWriter.WriteLine();
        streamWriter.WriteLine("StackTrace: " + exception.StackTrace);
        streamWriter.WriteLine("--------");

        MessageBox.Show(exception.Message, Resources.Application_Error, MessageBoxButton.OK, MessageBoxImage.Error);
      }
      catch {
        // Swallow the error.
      }
      finally {
        streamWriter.Close(); // Close is enough since it calls Dispose internally.
      }

    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Initializes the application 's catalog.
    /// </summary>
    private void InitializeAppCatalog() {

      // Register all view models and models here:

      // Register ViewModels.
      _catalog.RegisterViewModel(typeof(UserView), typeof(UserViewModel));
      _catalog.RegisterViewModel(typeof(UsersView), typeof(UsersViewModel));
      _catalog.RegisterViewModel(typeof(SampleView), typeof(SampleViewModel));
      //_catalog.RegisterViewModel(typeof(Sample1View), typeof(Sample1ViewModel));
      //_catalog.RegisterViewModel(typeof(Sample2View), typeof(Sample2ViewModel));
      // etc ...
      _catalog.RegisterViewModel(typeof(ShellView), typeof(ShellViewModel));

      // Register Models.
      _catalog.RegisterModel(typeof(UserViewModel), typeof(UserModel));
      _catalog.RegisterModel(typeof(UsersViewModel), typeof(UsersModel));
      _catalog.RegisterModel(typeof(SampleViewModel), typeof(SampleModel));
      //_catalog.RegisterModel(typeof(Sample1ViewModel), typeof(Sample1Model));
      //_catalog.RegisterModel(typeof(Sample2ViewModel), typeof(Sample2Model));
      // etc ...
      _catalog.RegisterModel(typeof(ShellViewModel), typeof(ShellModel));

    }

    #endregion

  }

}
