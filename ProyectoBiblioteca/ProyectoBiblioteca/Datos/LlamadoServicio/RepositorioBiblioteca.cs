using Microsoft.EntityFrameworkCore;
using ProyectoBiblioteca.Datos.Modelo;

namespace ProyectoBiblioteca.Datos.LlamadoServicio
{
	public class RepositorioBiblioteca : DbContext
	{
		public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options) : base(options);
		{
			
		}
	public DbSet<Libro> Libros { get; set; }
	public DbSet<Estudiante> Estudiantes { get; set; }
	public DbSet<Autor> Autor { get; set; }
	public DbSet<Prestamo> Prestamos { get; set; }
	}
}
