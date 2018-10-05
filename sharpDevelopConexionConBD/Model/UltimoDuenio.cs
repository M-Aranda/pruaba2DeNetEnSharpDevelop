/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 10/4/2018
 * Time: 9:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of UltimoDuenio.
	/// </summary>
	public class UltimoDuenio
	{
		String run;
		String nombreCompleto;
		String telefono;
		
		public UltimoDuenio()
		{
		}
		
		public UltimoDuenio(string run, string nombreCompleto, string telefono)
		{
			this.run = run;
			this.nombreCompleto = nombreCompleto;
			this.telefono = telefono;
			
		}

		public string Run {
			get {
				return run;
			}
			set {
				run = value;
			}
		}

		public string NombreCompleto {
			get {
				return nombreCompleto;
			}
			set {
				nombreCompleto = value;
			}
		}

		public string Telefono {
			get {
				return telefono;
			}
			set {
				telefono = value;
			}
		}
		
		
	}
}
