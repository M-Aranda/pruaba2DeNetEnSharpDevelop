/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using sharpDevelopConexionConBD.Model;

namespace sharpDevelopConexionConBD
{
	/// <summary>
	/// Description of Registrar.
	/// </summary>
	public partial class Registrar : Form
	{
		public Registrar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			DAO_Automovil da= new DAO_Automovil();
			DAO_UltimoDuenio dud= new DAO_UltimoDuenio();
			
			String patente= txtPatente.Text;
			String marca=txtMarca.Text;
			int anio=int.Parse(txtAnio.Text);
			String detalles= txtDetalles.Text;
			String runUd= txtRun.Text;
			
			int cantDuenios=dud.CantDueniosConEseRun(runUd);
			
			UltimoDuenio ud=null;

			
			if(cantDuenios==1){
				MessageBox.Show("No puede volver a registrar ese run");

			}else if(cantDuenios==0){
			
				ud=new UltimoDuenio();
				ud.Run=txtRun.Text;
				ud.NombreCompleto=txtNombre.Text;
				ud.Telefono=txtTelefono.Text;
				dud.Create(ud);
				
				Automovil a= new Automovil();
				a.Patente=patente;
				a.Marca=marca;
				a.Anio=anio;
				a.Detalles=detalles;
				a.Ud=ud;
			
				da.Create(a);
			
				txtAnio.Clear();
				txtDetalles.Clear();
				txtMarca.Clear();
				txtNombre.Clear();
				txtPatente.Clear();
				txtRun.Clear();
				txtTelefono.Clear();
				
				MessageBox.Show("Registro exitoso");
				
			
				
			}
			

			
	
		}
	}
}
