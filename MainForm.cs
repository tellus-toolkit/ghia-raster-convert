using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TellUsToolkit.GHIA.RasterConvert {

  /// <summary>
  /// The main form of the application.
  /// </summary>
  public partial class MainForm : Form {

    /// <summary>
    /// Initializes the main form.
    /// </summary>
    public MainForm() {
      InitializeComponent();
    }

    /// <summary>
    /// Selects the ESRI raster ASCII file.
    /// </summary>
    /// <param name="sender">The sender of the event.</param>
    /// <param name="e">The <see cref="EventArgs">event arguments</see>.</param>
    private void SelectRasterFileButton_Click(object sender, EventArgs e) {

      DialogResult result = this.OpenFileDialog.ShowDialog();

      // Check if a file has been selected.
      if (result == DialogResult.OK) {

        // The file has been selected, do something for it.


      }



    }

  }

}
