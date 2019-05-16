
#region Header

#endregion

#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TupleGeo.General.ComponentModel;
using TupleGeo.Apps;

#endregion

namespace TellUsToolkit.GHIA.RasterConverter.Models {

  /// <summary>
  /// The model of the metadata of the raster.
  /// </summary>
  public sealed class RasterMetadataModel : ObservableObject<RasterMetadataModel>, IModel {

    #region Member Variables

    #endregion

    #region Constructors - Destructors

    /// <summary>
    /// Initializes the <see cref="RasterMetadataModel"/>.
    /// </summary>
    public RasterMetadataModel() {
      
    }

    #endregion

    #region Public Properties

    private int _totalOutputColumns;

    /// <summary>
    /// Gets / Sets the total output columns of the raster.
    /// </summary>
    public int OutputRasterColumns {
      get {
        return _totalOutputColumns;
      }
      set {
        if (_totalOutputColumns != value) {
          _totalOutputColumns = value;
          this.OnPropertyChanged(m => m.OutputRasterColumns);
        }
      }
    }

    private int _totalOutputRows;

    /// <summary>
    /// Gets / Sets the total output rows of the raster.
    /// </summary>
    public int TotalOutputRows {
      get {
        return _totalOutputRows;
      }
      set {
        if (_totalOutputRows != value) {
          _totalOutputRows = value;
          this.OnPropertyChanged(m => m.TotalOutputRows);
        }
      }
    }

    private int _inputColumns;

    /// <summary>
    /// Gets / Sets the input raster columns.
    /// </summary>
    public int InputColumns {
      get {
        return _inputColumns;
      }
      set {
        if (_inputColumns != value) {
          _inputColumns = value;
          this.OnPropertyChanged(m => m.InputColumns);
        }
      }
    }

    private int _inputRows;

    /// <summary>
    /// Gets / Sets the input raster rows.
    /// </summary>
    public int InputRows {
      get {
        return _inputRows;
      }
      set {
        if (_inputRows != value) {
          _inputRows = value;
          this.OnPropertyChanged(m => m.InputRows);
        }
      }
    }

    private double _xMin;

    /// <summary>
    /// Gets / Sets the minimum x coordinate of the raster.
    /// </summary>
    public double XMin {
      get {
        return _xMin;
      }
      set {
        if (_xMin != value) {
          _xMin = value;
          this.OnPropertyChanged(m => m.XMin);
        }
        
      }
    }

    private double _yMin;

    /// <summary>
    /// Gets / Sets the minimum y coordinate of the raster.
    /// </summary>
    public double YMin {
      get {
        return _yMin;
      }
      set {
        if (_yMin != value) {
          _yMin = value;
          this.OnPropertyChanged(m => m.YMin);
        }
      }
    }

    private int _cellSize;

    /// <summary>
    /// Gets / Sets the size of the raster cell.
    /// </summary>
    public int CellSize {
      get {
        return _cellSize;
      }
      set {
        if (_cellSize != value) {
          _cellSize = value;
          this.OnPropertyChanged(m => m.CellSize);
        }
      }
    }

    private int _noDataValue;

    /// <summary>
    /// Gets / Sets the nodata value of the raster.
    /// </summary>
    public int NoDataValue {
      get {
        return _noDataValue;
      }
      set {
        if (_noDataValue != value) {
          _noDataValue = value;
          this.OnPropertyChanged(m => m.NoDataValue);
        }
      }
    }

    #endregion

    #region Event Procedures

    #endregion

    #region Private Procedures

    #endregion

    #region IModel Members

    private const string _modelName = "RasterMetadataModel";

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
