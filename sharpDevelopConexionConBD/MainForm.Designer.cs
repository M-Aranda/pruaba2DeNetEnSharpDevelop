/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/13/2018
 * Time: 5:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sharpDevelopConexionConBD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip mnsInicio;
		private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mniRegistrar;
		private System.Windows.Forms.ToolStripMenuItem mniBuscarAuto;
		private System.Windows.Forms.ToolStripMenuItem mniVerCatalogo;
		private System.Windows.Forms.Label lblCantAutos;
		private System.Windows.Forms.Button btnActualizar;
		
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
			this.mnsInicio = new System.Windows.Forms.MenuStrip();
			this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniRegistrar = new System.Windows.Forms.ToolStripMenuItem();
			this.mniBuscarAuto = new System.Windows.Forms.ToolStripMenuItem();
			this.mniVerCatalogo = new System.Windows.Forms.ToolStripMenuItem();
			this.lblCantAutos = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.mnsInicio.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnsInicio
			// 
			this.mnsInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.iniciarToolStripMenuItem});
			this.mnsInicio.Location = new System.Drawing.Point(0, 0);
			this.mnsInicio.Name = "mnsInicio";
			this.mnsInicio.Size = new System.Drawing.Size(682, 24);
			this.mnsInicio.TabIndex = 0;
			this.mnsInicio.Text = "menuStrip1";
			// 
			// iniciarToolStripMenuItem
			// 
			this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniRegistrar,
			this.mniBuscarAuto,
			this.mniVerCatalogo});
			this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
			this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.iniciarToolStripMenuItem.Text = "Iniciar";
			// 
			// mniRegistrar
			// 
			this.mniRegistrar.Name = "mniRegistrar";
			this.mniRegistrar.Size = new System.Drawing.Size(147, 22);
			this.mniRegistrar.Text = "Registrar auto";
			this.mniRegistrar.Click += new System.EventHandler(this.MniRegistrarClick);
			// 
			// mniBuscarAuto
			// 
			this.mniBuscarAuto.Name = "mniBuscarAuto";
			this.mniBuscarAuto.Size = new System.Drawing.Size(147, 22);
			this.mniBuscarAuto.Text = "Buscar auto";
			this.mniBuscarAuto.Click += new System.EventHandler(this.MniBuscarAutoClick);
			// 
			// mniVerCatalogo
			// 
			this.mniVerCatalogo.Name = "mniVerCatalogo";
			this.mniVerCatalogo.Size = new System.Drawing.Size(147, 22);
			this.mniVerCatalogo.Text = "Ver catalogo";
			this.mniVerCatalogo.Click += new System.EventHandler(this.MniVerCatalogoClick);
			// 
			// lblCantAutos
			// 
			this.lblCantAutos.Location = new System.Drawing.Point(12, 90);
			this.lblCantAutos.Name = "lblCantAutos";
			this.lblCantAutos.Size = new System.Drawing.Size(313, 23);
			this.lblCantAutos.TabIndex = 1;
			this.lblCantAutos.Text = "Cantidad de autos: ";
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(23, 116);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(75, 23);
			this.btnActualizar.TabIndex = 2;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 261);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.lblCantAutos);
			this.Controls.Add(this.mnsInicio);
			this.MainMenuStrip = this.mnsInicio;
			this.Name = "MainForm";
			this.Text = "Inicio";
			this.mnsInicio.ResumeLayout(false);
			this.mnsInicio.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
