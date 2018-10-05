/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of DAO_Automovil.
	/// </summary>
	public class DAO_Automovil : Conexion, IDAO<Automovil>
	{
		public DAO_Automovil():base("registroAutomovilesSharpDevelop")
		{
		}

		

		public void Create(Automovil ob)
		{
			Ejecutar("INSERT INTO automovil VALUES ('"+ob.Patente+"', '"+ob.Marca+"', "+ob.Anio+", '"+ob.Detalles+"', " +
			        " '"+ob.Ud.Run+"');");
			
		}

		public DataTable Read()
		{
			
			DataTable dt= new DataTable();
			dt=Ejecutar("SELECT * FROM automovil");
			return dt;		
			
		}

		public void Update(Automovil ob)
		{
			Ejecutar("UPDATE automovil SET patente='"+ob.Patente+"', '"+ob.Marca+"', "+ob.Anio+", '"+ob.Detalles+"', '"+ob.Ud.Run+"'," +
			"WHERE id="+ob.Id+";");
		}

		public void Delete(int id)
		{
			Ejecutar("DELETE FROM automovil WHERE id="+id+"; ");
		}
		

		public DataTable BuscarPorRun(string run)
		{
			throw new NotSupportedException();
		}
		
		public DataTable BuscarPorPatente (String patente){
			
			DataTable dt= new DataTable();
			dt=Ejecutar("SELECT * FROM automovil WHERE patente='"+patente+"'; ");
			return dt;
			
		}
		
		
		public int GetCantAutos(){
			int cant=0;
			DataTable dt= new DataTable();
			dt=Ejecutar("SELECT COUNT(*) FROM automovil;");
			cant=int.Parse(dt.Rows[0][0].ToString());
			
			return cant;	
		}
		
		
		public DataTable VerCatalogo()
		{
			
			DataTable dt= null;
			dt=Ejecutar("SELECT * FROM verCatalogo");
			return dt;		
			
		}
		
		
		
		public DataTable BuscarPorPatenteYVerMasDatos (String patente){
			
			DataTable dt= null;
			dt=Ejecutar("SELECT automovil.id AS 'ID', automovil.patente AS 'Patente', automovil.marca AS 'Marca'," +
"			            automovil.anio AS 'Anio', automovil.detalles AS 'Detalles', ultimoDuenio.run AS 'Run', ultimoDuenio.nombreCompleto AS 'Nombre completo', " +
"			ultimoDuenio.telefono AS 'Telefono'	FROM automovil, ultimoDuenio WHERE patente='"+patente+"' AND automovil.ultimoDuenio_fk=ultimoDuenio.run; ");
			return dt;
			
		}
		
		
		public int GetCantCoincidencias(String patente){
			int cant=0;
			DataTable dt= new DataTable();
			dt=Ejecutar("SELECT COUNT(*) FROM automovil WHERE patente= '"+patente+"';");
			cant=int.Parse(dt.Rows[0][0].ToString());
			
			return cant;	
		}
		

		
	}
}
