/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of Automovil.
	/// </summary>
	public class Automovil
	{
		int id;
		String patente;
		String marca;
		int anio;
		String detalles;
		UltimoDuenio ud;
		 
		
		public Automovil()
		{
		}
		
		public Automovil(int id, string patente, string marca, int anio, string detalles, UltimoDuenio ud)
		{
			this.id = id;
			this.patente = patente;
			this.marca = marca;
			this.anio = anio;
			this.detalles = detalles;
			this.ud = ud;
			
		}

		public int Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		public string Patente {
			get {
				return patente;
			}
			set {
				patente = value;
			}
		}

		public string Marca {
			get {
				return marca;
			}
			set {
				marca = value;
			}
		}

		public int Anio {
			get {
				return anio;
			}
			set {
				anio = value;
			}
		}

		public string Detalles {
			get {
				return detalles;
			}
			set {
				detalles = value;
			}
		}

		public UltimoDuenio Ud {
			get {
				return ud;
			}
			set {
				ud = value;
			}
		}
		
		
	}
}
