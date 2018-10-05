/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sharpDevelopConexionConBD
{
	partial class Buscar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtPatenteABuscar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.RichTextBox richTextBox1;
		
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
			this.txtPatenteABuscar = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// txtPatenteABuscar
			// 
			this.txtPatenteABuscar.Location = new System.Drawing.Point(12, 12);
			this.txtPatenteABuscar.Name = "txtPatenteABuscar";
			this.txtPatenteABuscar.Size = new System.Drawing.Size(199, 20);
			this.txtPatenteABuscar.TabIndex = 0;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(217, 12);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(123, 23);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Buscar por patente";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 41);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(727, 195);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// Buscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 261);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtPatenteABuscar);
			this.Name = "Buscar";
			this.Text = "Buscar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
