﻿
#region Header

#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TupleGeo.General.ComponentModel;
using TupleGeo.Apps;
using TupleGeo.Apps.Presentation;
using TellUsToolkit.GHIA.RasterConverter.Engine;

#endregion

namespace TellUsToolkit.GHIA.RasterConverter.Models {

  /// <summary>
  /// The model used by the shell.
  /// </summary>
  public sealed class ShellModel : ObservableObject<ShellModel>, IModel {

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the ShellModel.
    /// </summary>
    public ShellModel() {

    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the caption of the shell.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public string Caption {
      get {
        if (AppEngine.Instance.ApplicationModel != null) {
          return AppEngine.Instance.ApplicationModel.Caption;
        }
        else {
          return "";
        }
      }
    }

    #endregion

    #region Event Procedures

    #endregion

    #region IModel Members

    private const string _modelName = "ShellModel";

    /// <summary>
    /// Gets the name of the model.
    /// </summary>
    public string ModelName {
      get {
        return _modelName;
      }
    }

    #endregion

  }

}
