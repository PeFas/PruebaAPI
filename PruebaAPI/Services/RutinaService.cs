using PruebaAPI.Models;
namespace PruebaAPI.Services;

public class RutinaService
{
    static List<Rutina> Rutinas { get; }
    static int nextId = 8;
    static RutinaService()
    {
        Rutinas = new List<Rutina>
    {
        new Rutina { Id = 1, Name = "Joseph", Apellido="Murillo", Correo="Joseph@gmail.com", Descripcion="2 repeticiones de 20 flexiones", Materiales="Soga, Cuerda", Tipo="Pecho", Dia="Lunes" },
        new Rutina { Id = 2, Name = "Juan", Apellido="Medina", Correo="Juan@gmail.com", Descripcion="5 repeticiones de 20 abdominales", Materiales="Mancuerda", Tipo="Brazo", Dia="Martes" },
        new Rutina { Id = 3, Name = "Pedro", Apellido="Alvarez", Correo="pedro@gmail.com", Descripcion="10 repeticiones de 15 Polichilenos", Materiales="Vendas", Tipo="Cardio", Dia="Miercoles" },
        new Rutina { Id = 4, Name = "Andres", Apellido="Carrion", Correo="andres@gmail.com", Descripcion="7 repeticiones de 15 sentadillas ", Materiales="Pesa 15kg", Tipo="Pierna", Dia="Jueves" },
        new Rutina { Id = 5, Name = "Nicole", Apellido="Fajardo", Correo="nicole@gmail.com", Descripcion="2 repeticiones de levantar peso muerto 40kg", Materiales="Pesas", Tipo="Brazo", Dia="Viernes" },
        new Rutina { Id = 6, Name = "Julio", Apellido="Agosto", Correo="julio@gmail.com", Descripcion="6 repeticiones de 20 zancadas", Materiales="Pesa 20kg", Tipo="Brazo", Dia="Sabado" },
        new Rutina { Id = 7, Name = "Kevin", Apellido="Benavides", Correo="kevin@gmail.com", Descripcion="4 repeticiones de 12 aperturas de pectoral", Materiales="Pesas", Tipo="Pecho", Dia="Lunes" }


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
