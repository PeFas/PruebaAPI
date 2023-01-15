using PruebaAPI.Models;
namespace PruebaAPI.Services;

public class RutinaService
{
    static List<Rutina> Rutinas { get; }
    static int nextId = 3;
    static RutinaService()
    {
        Rutinas = new List<Rutina>
    {
        new Rutina { Id = 1, Name = "Joseph", Apellido="Murillo", Correo="Joseph@gmail.com", Descripcion="2 repeticiones de 20 flexiones", Materiales="Soga, Cuerda", Tipo="Pierna", Dia="Lunes" },
        new Rutina { Id = 2, Name = "Juan", Apellido="Medina", Correo="Juan@gmail.com", Descripcion="2 repeticiones de 20 abdominales", Materiales="Mancuerda", Tipo="Brazo", Dia="Martes" }
    };
    }

    public static List<Rutina> GetAll() => Rutinas;

    public static Rutina? Get(int id) => Rutinas.FirstOrDefault(p => p.Id == id);

    public static void Add(Rutina rutina)
    {
        rutina.Id = nextId++;
        Rutinas.Add(rutina);
    }

    public static void Delete(int id)
    {
        var rutina = Get(id);
        if (rutina is null)
            return;

        Rutinas.Remove(rutina);
    }

    public static void Update(Rutina rutina)
    {
        var index = Rutinas.FindIndex(p => p.Id == rutina.Id);
        if (index == -1)
            return;

        Rutinas[index] = rutina;
    }
}
