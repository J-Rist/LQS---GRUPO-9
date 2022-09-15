using System;
namespace MascotaFeliz.App.Dominio
{
    public class Mascota   
    {
        public int Id {get;set;}                    // Propiedad
        public string Nombre {get;set;}
        public string Color {get;set;}
        public string Especie {get;set;}
        public string Raza {get;set;}
        public Dueno Dueno {get;set;}                // 1st Dueno = clase y 2do Dueno = propiedad
        public Veterinario Veterianrio {get;set;}
        public Historia Historia {get;set;}
    }
}