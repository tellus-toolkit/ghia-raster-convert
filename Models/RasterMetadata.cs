
#region Imported Namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace TellUsToolkit.GHIA.RasterConvert.Models {

  /// <summary>
  /// The metadata of the raster.
  /// </summary>
  public class RasterMetadata {

    private int _totalOutputColumns;

    /// <summary>
    /// The output 
    /// </summary>
    public int OutputRasterColumns {
      get {
        return _totalOutputColumns;
      }
      set {
        _totalOutputColumns = value;
      }
    }




  }

}
