namespace TellUsToolkit.GHIA.RasterConvert {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.SelectRasterFileButton = new System.Windows.Forms.Button();
      this.RasterAsciiFile = new System.Windows.Forms.Label();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.SuspendLayout();
      // 
      // SelectRasterFileButton
      // 
      this.SelectRasterFileButton.Location = new System.Drawing.Point(636, 8);
      this.SelectRasterFileButton.Name = "SelectRasterFileButton";
      this.SelectRasterFileButton.Size = new System.Drawing.Size(75, 23);
      this.SelectRasterFileButton.TabIndex = 0;
      this.SelectRasterFileButton.Text = "Select File";
      this.SelectRasterFileButton.UseVisualStyleBackColor = true;
      this.SelectRasterFileButton.Click += new System.EventHandler(this.SelectRasterFileButton_Click);
      // 
      // RasterAsciiFile
      // 
      this.RasterAsciiFile.AutoSize = true;
      this.RasterAsciiFile.Location = new System.Drawing.Point(12, 13);
      this.RasterAsciiFile.Name = "RasterAsciiFile";
      this.RasterAsciiFile.Size = new System.Drawing.Size(213, 13);
      this.RasterAsciiFile.TabIndex = 1;
      this.RasterAsciiFile.Text = "Select the Classified ESRI Raster ASCII File";
      // 
      // OpenFileDialog
      // 
      this.OpenFileDialog.AddExtension = false;
      this.OpenFileDialog.FileName = "OpenFileDialog";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(723, 456);
      this.Controls.Add(this.RasterAsciiFile);
      this.Controls.Add(this.SelectRasterFileButton);
      this.Name = "MainForm";
      this.Text = "Convert Raster";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button SelectRasterFileButton;
    private System.Windows.Forms.Label RasterAsciiFile;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
  }
}

