/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/13/2018
 * Time: 5:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using sharpDevelopConexionConBD.Model;


namespace sharpDevelopConexionConBD
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			DAO_Automovil da= new DAO_Automovil();
			int cantAutos=da.GetCantAutos();
			lblCantAutos.Text="La cantidad de autos registrados es de: "+cantAutos;
	
		
		}
		void MniVerCatalogoClick(object sender, EventArgs e)
		{
			Catalogo c= new Catalogo();
			c.Show();
	
		}
		void MniRegistrarClick(object sender, EventArgs e)
		{
			Registrar r= new Registrar();
			r.Show();
	
		}
		void MniBuscarAutoClick(object sender, EventArgs e)
		{
			Buscar b= new Buscar();
			b.Show();
	
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			DAO_Automovil da= new DAO_Automovil();
			int cantAutos=da.GetCantAutos();
			lblCantAutos.Text="La cantidad de autos registrados es de: "+cantAutos;
	
		}
	}
}
