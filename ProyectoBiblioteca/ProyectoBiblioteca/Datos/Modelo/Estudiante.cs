﻿namespace ProyectoBiblioteca.Datos.Modelo
{
	public class Estudiante
	{
		[Key]
		public int Identificacion { get; set; }

		public string Nombre { get; set; }

		public string Categoria { get; set; }

		public string Autor { get; set; }

		public int NumeroPagina { get; set; }
	}
}
