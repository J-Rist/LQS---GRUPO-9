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
        private static IRepositorioVisitaPyP _repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            //AddVisitaPyP();
            //AddHistoria();
            //BuscarDueno(1);
            //BuscarMascota(1);
            //ListarMascotasFiltro();
            //BuscarMascotas();
        }


        // AGREGAR DUEÑO
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

        // AGREGAR VETERINARIO
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

        // AGREGAR MASCOTA
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

        // AGREGAR VISITAPYP
        private static void AddVisitaPyP()
        {
            var visitapyp = new VisitaPyP
            {
                Temperatura = 34,
                Peso = 20,
                FrecuenciaRespiratoria = 30,
                FrecuenciaCardiaca = 70,
                EstadoAnimo = "Feliz",
                FechaVisita = new DateTime(2014 ,12 ,2, 3, 30, 40),
                Recomendaciones = "Sacarlo a pasear",
            };
            _repoVisitaPyP.AddVisitaPyP(visitapyp);
        }

        // AGREGAR HISTORIA
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                FechaInicial = new DateTime(2014 ,12 ,2, 3, 30, 40),
            };
            _repoHistoria.AddHistoria(historia);
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

        // ASIGNAR UN VETERINARIO
        private static void AsignarVeterinario()
        {
            var veterinario = _repoMascota.AsignarVeterinario(1,15)
            console.WriteLine(veterinario.Nombres + " " +veterinario.Apellidos);
        }

        // ASIGNAR UN DUEÑO
        private static void AsignarDueno()
        {
            var dueno = _repoDueno.AsignarDueno(1,15)
            console.WriteLine(Dueno.Nombres + " " +Dueno.Apellidos);
        }
    }
}
