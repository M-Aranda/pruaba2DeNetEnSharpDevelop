/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sharpDevelopConexionConBD
{
	partial class Catalogo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dtgv;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dtgv = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgv
			// 
			this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgv.Location = new System.Drawing.Point(12, 12);
			this.dtgv.Name = "dtgv";
			this.dtgv.Size = new System.Drawing.Size(628, 227);
			this.dtgv.TabIndex = 0;
			// 
			// Catalogo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 261);
			this.Controls.Add(this.dtgv);
			this.Name = "Catalogo";
			this.Text = "Catalogo";
			((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
