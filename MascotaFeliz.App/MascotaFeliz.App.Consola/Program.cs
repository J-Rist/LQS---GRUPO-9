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
            //BuscarDueno(1);
            //BuscarMascota(1);
            //ListarMascotasFiltro();
            BuscarMascotas();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                Nombres = "Felipe",
                Apellidos = "Sin Miedo",
                Direccion = "Bajo un puente",
                Telefono = "1234567891",
                Correo = "Felipesinmiedo@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                Nombres = "Brayan",
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
                Nombre = "Moon",
                Color = "Gris",
                Especie = "Perro",
                Raza = "Lobo ciberiano",
            };
            _repoMascota.AddMascota(mascota);
        }

         private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo + " ");
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine("================== MARCOTA POR ID ==================");
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza + " " );
            Console.WriteLine("====================================================");
        }

        private static void ListarMascotasFiltro()
        {
            var mascotasM = _repoMascota.GetMascotasPorFiltro("o");
            Console.WriteLine("================== MARCOTAS POR FILTRO ==================");
            foreach (Mascota p in mascotasM)
            {
                Console.WriteLine(p.Nombre + " " + p.Color + " " + p.Especie + " " + p.Raza + " ");
            }
            Console.WriteLine("========================================================");

        }

        private static void BuscarMascotas()
        {
            var mascotasA = _repoMascota.GetAllMascotas();
            Console.WriteLine("================== TODAS LAS MARCOTAS ==================");
            foreach (Mascota m in mascotasA)
            { 
                Console.WriteLine(m.Nombre + " " + m.Color + " " + m.Especie + " " + m.Raza + " "); 
            }
            Console.WriteLine("========================================================");
        }
    }
}
