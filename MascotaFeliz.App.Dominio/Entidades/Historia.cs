using System;                         // using = es para hacer importaciones
using System.Collections.Generic;     // Importa la librería necesaria para que funcione una lista.
namespace MascotaFeliz.App.Dominio   // namespace = es para hacer importaciones de paquetes
{
    public class Historia
    {
        public int Id {get;set;}
        public DateTime FechaInicial {get;set;}
        public List<VisitaPyP> VisitasPyP {get;set;}
    }
}