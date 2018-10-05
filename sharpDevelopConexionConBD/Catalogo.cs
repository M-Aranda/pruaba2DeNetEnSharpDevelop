/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using sharpDevelopConexionConBD.Model;

namespace sharpDevelopConexionConBD
{
	/// <summary>
	/// Description of Catalogo.
	/// </summary>
	public partial class Catalogo : Form
	{
		public Catalogo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			DAO_Automovil da= new DAO_Automovil();
			dtgv.DataSource=da.VerCatalogo();
			
		}
	}
}
