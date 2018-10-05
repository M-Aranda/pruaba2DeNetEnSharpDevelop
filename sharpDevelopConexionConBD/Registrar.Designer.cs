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
	partial class Registrar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblPatente;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label lblAnio;
		private System.Windows.Forms.Label lblDetalles;
		private System.Windows.Forms.Label lblRun;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.TextBox txtPatente;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.TextBox txtDetalles;
		private System.Windows.Forms.TextBox txtAnio;
		private System.Windows.Forms.TextBox txtRun;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Button btnRegistrar;
		
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
			this.lblPatente = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblAnio = new System.Windows.Forms.Label();
			this.lblDetalles = new System.Windows.Forms.Label();
			this.lblRun = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.txtPatente = new System.Windows.Forms.TextBox();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.txtDetalles = new System.Windows.Forms.TextBox();
			this.txtAnio = new System.Windows.Forms.TextBox();
			this.txtRun = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPatente
			// 
			this.lblPatente.Location = new System.Drawing.Point(12, 22);
			this.lblPatente.Name = "lblPatente";
			this.lblPatente.Size = new System.Drawing.Size(100, 23);
			this.lblPatente.TabIndex = 0;
			this.lblPatente.Text = "Patente: ";
			// 
			// lblMarca
			// 
			this.lblMarca.Location = new System.Drawing.Point(12, 60);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(100, 23);
			this.lblMarca.TabIndex = 1;
			this.lblMarca.Text = "Marca: ";
			// 
			// lblAnio
			// 
			this.lblAnio.Location = new System.Drawing.Point(12, 92);
			this.lblAnio.Name = "lblAnio";
			this.lblAnio.Size = new System.Drawing.Size(100, 23);
			this.lblAnio.TabIndex = 2;
			this.lblAnio.Text = "Anio: ";
			// 
			// lblDetalles
			// 
			this.lblDetalles.Location = new System.Drawing.Point(12, 133);
			this.lblDetalles.Name = "lblDetalles";
			this.lblDetalles.Size = new System.Drawing.Size(100, 23);
			this.lblDetalles.TabIndex = 3;
			this.lblDetalles.Text = "Detalles: ";
			// 
			// lblRun
			// 
			this.lblRun.Location = new System.Drawing.Point(12, 173);
			this.lblRun.Name = "lblRun";
			this.lblRun.Size = new System.Drawing.Size(100, 23);
			this.lblRun.TabIndex = 4;
			this.lblRun.Text = "Run ultimo duenio: ";
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(12, 208);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(118, 23);
			this.lblNombre.TabIndex = 5;
			this.lblNombre.Text = "Nombre ultimo duenio: ";
			// 
			// lblTelefono
			// 
			this.lblTelefono.Location = new System.Drawing.Point(12, 241);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(118, 23);
			this.lblTelefono.TabIndex = 6;
			this.lblTelefono.Text = "Telefono ultimo duenio: ";
			// 
			// txtPatente
			// 
			this.txtPatente.Location = new System.Drawing.Point(64, 19);
			this.txtPatente.Name = "txtPatente";
			this.txtPatente.Size = new System.Drawing.Size(100, 20);
			this.txtPatente.TabIndex = 7;
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(64, 60);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(100, 20);
			this.txtMarca.TabIndex = 8;
			// 
			// txtDetalles
			// 
			this.txtDetalles.Location = new System.Drawing.Point(64, 133);
			this.txtDetalles.Name = "txtDetalles";
			this.txtDetalles.Size = new System.Drawing.Size(256, 20);
			this.txtDetalles.TabIndex = 9;
			// 
			// txtAnio
			// 
			this.txtAnio.Location = new System.Drawing.Point(64, 95);
			this.txtAnio.Name = "txtAnio";
			this.txtAnio.Size = new System.Drawing.Size(100, 20);
			this.txtAnio.TabIndex = 10;
			// 
			// txtRun
			// 
			this.txtRun.Location = new System.Drawing.Point(132, 170);
			this.txtRun.Name = "txtRun";
			this.txtRun.Size = new System.Drawing.Size(188, 20);
			this.txtRun.TabIndex = 11;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(132, 205);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(188, 20);
			this.txtNombre.TabIndex = 12;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(132, 238);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(188, 20);
			this.txtTelefono.TabIndex = 13;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(89, 267);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
			this.btnRegistrar.TabIndex = 14;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// Registrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(858, 300);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtRun);
			this.Controls.Add(this.txtAnio);
			this.Controls.Add(this.txtDetalles);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.txtPatente);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblRun);
			this.Controls.Add(this.lblDetalles);
			this.Controls.Add(this.lblAnio);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblPatente);
			this.Name = "Registrar";
			this.Text = "Registrar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
