using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //AddDueno();
            //AddVeterinario();
            //AddMascota();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Juan",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "juansinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Camilo",
                Apellidos = "Con Miedo",
                Direccion = "Bajo de un puente",
                Telefono = "1234567892",
                TarjetaProfesional = "1234",
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                Nombre = "Neron",
                Color = "Amarillo",
                Especie = "Perro",
                Raza = "Pincher",
            };
            _repoMascota.AddMascota(mascota);
        }

    }
}
