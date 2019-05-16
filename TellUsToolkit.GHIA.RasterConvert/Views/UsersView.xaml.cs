﻿
#region Header

#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TupleGeo.Apps;
using TupleGeo.Apps.Presentation;
using TellUsToolkit.GHIA.RasterConverter.Engine;
using TellUsToolkit.GHIA.RasterConverter.ViewModels;

#endregion

namespace TellUsToolkit.GHIA.RasterConverter.Views {

  /// <summary>
  /// The Users View.
  /// </summary>
  public partial class UsersView : UserControl, IView {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="UsersView"/>.
    /// </summary>
    public UsersView() {
      InitializeComponent();
      InitializeView();
    }

    #endregion

    #region Private Procedures

    /// <summary>
    /// Initializes the view.
    /// </summary>
    private void InitializeView() {

      try {
        // Make sure this executes in runtime.
        if (!DesignerProperties.GetIsInDesignMode(this)) {
          // The viewmodel of this view acts as a datacontext. Bind the viewmodel here.
          UsersViewModel usersViewModel = (UsersViewModel)((IViewModel)(AppEngine.Instance.Catalog.GetViewModel(this.GetType())));
          this.DataContext = usersViewModel;

          // The event procedures reside in to the viewmodel. Binding is performed by calling the
          // 'SubscribeToEvents' method of the view model passing a dictionary of controls.
          // Bind the view model event procedures here.

          // The dictionary of the controls needed to be observed by the viewmodel.
          //Dictionary<string, object> observedControlsDictionary = new Dictionary<string, object>();
          // Add the controls.
          //observedControlsDictionary.Add(this.control1.Name, this.control1); // TODO: Change key and value here.
          //observedControlsDictionary.Add(this.control2.Name, this.control2); // TODO: Change key and value here.
          // ...
          //observedControlsDictionary.Add(this.controlN.Name, this.controlN); // TODO: Change key and value here.
          // Call the SubscribeToEvents method of the viewmodel.
          //usersViewModel.SubscribeToEvents(observedControlsDictionary);

          // Get any CollectionViewSources defined in the view as resources.
          //Dictionary<string, CollectionViewSource> collectionViewSourcesDictionary = new Dictionary<string, CollectionViewSource>();
          //CollectionViewSource collection1ViewSource = (CollectionViewSource)(this.Resources["collection1ViewSourceName"]); // TODO: Change key and value here.
          //collectionViewSourcesDictionary.Add("collection1ViewSourceName", collection1ViewSource); // TODO: Change key and value here.
          //CollectionViewSource collection2ViewSource = (CollectionViewSource)(this.Resources["collection2ViewSourceName"]); // TODO: Change key and value here.
          //collectionViewSourcesDictionary.Add("collection2ViewSourceName", collection2ViewSource); // TODO: Change key and value here.
          // ...
          //CollectionViewSource collectionNViewSource = (CollectionViewSource)(this.Resources["collectionNViewSourceName"]); // TODO: Change key and value here.
          //collectionViewSourcesDictionary.Add("collectionNViewSourceName", collectionNViewSource); // TODO: Change key and value here.

          // Set the collection view sources in the viewmodel.
          //usersViewModel.SetCollectionViewSources(collectionViewSourcesDictionary);
        }
      }
      catch (Exception ex) {
        AppEngine.LogError(ex, "UsersView - InitializeView()");
        string error = "An error has occurred while binding to the view 'UsersView'\r\n\r\n" +
                       "Error Message: " + ex.Message + "\r\n\r\n";
        if (ex.InnerException != null) {
          error += string.Format(CultureInfo.InvariantCulture, "Inner Exception: {0}", ex.InnerException.Message);
        }
        MessageBox.Show(error, TellUsToolkit.GHIA.RasterConverter.Properties.Resources.Application_ViewDataBindingError, MessageBoxButton.OK, MessageBoxImage.Error);
      }

    }

    #endregion

    #region IView Members

    /// <summary>
    /// Gets the view name.
    /// </summary>
    public string ViewName {
      get {
        return "UsersView";
      }
    }

    #endregion

  }

}
