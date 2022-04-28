using Microsoft.AspNetCore.Mvc;

namespace ProyectoBiblioteca.Controllers
{
	[ApiController]
	[Route("[Controller]/[action]")]

	public class BibliotecaController: ControllerBase
	{
		public string PropiedadesBilbioteca { get; set; }

		public BibliotecaController()
		{
			//Constructor
		}
		[HttpGet]

		public string ObtenerLibro() 
		{ 
			return "Eche no joda mmburra";
		}
		public string ObtenerAutor() 
		{ 
			return "Eche no joda mmburra";
		}
		public string ObtenerEstudiante() 
		{ 
			return "Eche no joda mmburra";
		}
		public string ObtenerPrestamo() 
		{ 
			return "Eche no joda mmburra";
		}
		[HttpPut]

		public string ActualizarLibro()
		{
			return "Eche no joda mmburra";
		}
		public string ActualizarAutor()
		{
			return "Eche no joda mmburra";
		}
		public string ActualizarEstudiante()
		{
			return "Eche no joda mmburra";
		}
		public string ActualizarPrestamo()
		{
			return "Eche no joda mmburra";
		}
		[HttpPost]

		public string AgregarLibro()
		{
			return "Eche no joda mmburra";
		}
		public string AgregarEstudiante()
		{
			return "Eche no joda mmburra";
		}public string AgregarAutor()
		{
			return "Eche no joda mmburra";
		}public string AgregarPrestamo()
		{
			return "Eche no joda mmburra";
		}
	}
}
