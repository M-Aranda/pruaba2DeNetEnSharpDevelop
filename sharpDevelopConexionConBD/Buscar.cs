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
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using sharpDevelopConexionConBD.Model;

namespace sharpDevelopConexionConBD
{
	/// <summary>
	/// Description of Buscar.
	/// </summary>
	public partial class Buscar : Form
	{
		public Buscar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			
			DAO_Automovil da= new DAO_Automovil();
			String patenteAbuscar=txtPatenteABuscar.Text;
			
			int coincidenciasDePatente=da.GetCantCoincidencias(patenteAbuscar);
			
			if(coincidenciasDePatente==0){
				MessageBox.Show("No hay coincidencias");
			}else if(coincidenciasDePatente>0){
							DataTable dt= da.BuscarPorPatenteYVerMasDatos(patenteAbuscar);
			for (int i = 0; i < dt.Rows.Count; i++) {
				
				for (int j = 0; j < 8; j++) {
					
					String txtEnr=dt.Rows[i][j].ToString()+" ";	
					FontFamily family = new FontFamily("Times New Roman");
			/*
            Font negrita = new Font(family, 16.0f,
                FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);// esto agrega todos esos estilos
                */
               		Font negrita = new Font(family, 16.0f, FontStyle.Bold);
					
					Color destacar=Color.Red;
					
					
					if(j==0){
						
						richTextBox1.AppendText("Id: "+txtEnr);
					}else if(j==1){
						
						richTextBox1.AppendText("Patente: "+txtEnr);
					}else if(j==2){
						
						richTextBox1.AppendText("Marca: "+txtEnr);
					}else if(j==3){
						
						richTextBox1.AppendText("Anio: "+txtEnr);
					}else if(j==4){
						//detalles
						txtEnr="Detalles del auto: "+txtEnr;
						AppendTextWithStuff(richTextBox1,txtEnr,destacar,negrita);
					}else if(j==5){
						
						richTextBox1.AppendText("Run ultimoDuenio: "+txtEnr);				
						
					}else if(j==6){
						//nombre
						txtEnr="Nombre completo del ultimo duenio: "+txtEnr;
						AppendTextWithStuff(richTextBox1,txtEnr,destacar,negrita);
					}else if(j==7){
						//telefono
						txtEnr="Telefono del ultimo duenio: "+txtEnr;
						AppendTextWithStuff(richTextBox1,txtEnr,destacar,negrita);
						richTextBox1.AppendText("\n");
					
						
						
					
				}
				
			}

	
		}
			}
				
			}
			

		
		
		
	public  void AppendTextWithStuff( RichTextBox box, string text, Color color, Font font)
		{
   		 box.SelectionStart = box.TextLength;
   		 box.SelectionLength = 0;

   		 box.SelectionColor = color;
    	 box.SelectionFont = font;
   		 box.AppendText(text);
   		 box.SelectionColor = box.ForeColor;
		}
		
		
	}
}
