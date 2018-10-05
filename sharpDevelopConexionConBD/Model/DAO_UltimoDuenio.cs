/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of DAO_UltimoDuenio.
	/// </summary>
	public class DAO_UltimoDuenio : Conexion, IDAO<UltimoDuenio>
	{
		public DAO_UltimoDuenio():base("registroAutomovilesSharpDevelop")
		{
			
		}
		
		

		public void Create(UltimoDuenio ob)
		{
			Ejecutar("INSERT INTO ultimoDuenio VALUES ('"+ob.Run+"', '"+ob.NombreCompleto+"', '"+ob.Telefono+"');");
		}

		public DataTable Read()
		{
			DataTable dt= new DataTable();
			dt=Ejecutar("SELECT * FROM ultimoDuenio");
			return dt;
		}

		public void Update(UltimoDuenio ob)
		{
			Ejecutar("UPDATE ultimoDuenio SET nombreCompleto='"+ob.NombreCompleto+"', telefono='"+ob.Telefono+"' " +
			         "WHERE run= '"+ob.Run+"' ");
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}
		
		public void DeletePorRun(String run){
			Ejecutar("DELETE FROM ultimoDuenio WHERE run='"+run+"'");
		}
		

		public DataTable BuscarPorRun(string run)
		{
			DataTable dt= new DataTable();
			dt=Ejecutar("SELECT * FROM ultimoDuenio WHERE run= '"+run+"'");
			return dt;
		}
		
		public int CantDueniosConEseRun(String run){
			int cant=0;
			DataTable dt= new DataTable();
			dt=Ejecutar("SELECT COUNT(*) FROM ultimoDuenio WHERE run='"+run+"';");
			cant=int.Parse(dt.Rows[0][0].ToString());
			
			return cant;
			
		}
		
		

		

		
	}
}
