using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP : IRepositorioVisitaPyP // : = Implementar o Heredar
    {
        /// <summary>
        /// Referencia al contexto de Dueno
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioVisitaPyP(AppContext appContext)
        {
            _appContext = appContext;
        }

        public VisitaPyP AddVisitaPyP(VisitaPyP visitapyp)
        {
            var visitapypAdicionado = _appContext.VisitasPyP.Add(visitapyp);
            _appContext.SaveChanges();
            return visitapypAdicionado.Entity;
        }

        public void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitapypEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
            if (visitapypEncontrado == null)
                return;
            _appContext.VisitasPyP.Remove(visitapypEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<VisitaPyP> GetAllVisitasPyP()
        {
            return _appContext.VisitasPyP;
        }

        public IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(string filtro)
        {
            var visitaspyp = GetAllVisitasPyP(); // Obtiene todos los saludos
            if (visitaspyp != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    visitaspyp = visitaspyp.Where(s => s.Recomendaciones.Contains(filtro));
                }
            }
            return visitaspyp;
        }

        public VisitaPyP GetVisitaPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
        }

        public VisitaPyP UpdateVisitaPyP(VisitaPyP visitapyp)
        {
            var visitapypEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == visitapyp.Id);
            if (visitapypEncontrado != null)
            {
                visitapypEncontrado.Temperatura = visitapyp.Temperatura;
                visitapypEncontrado.Peso = visitapyp.Peso;
                visitapypEncontrado.FrecuenciaRespiratoria = visitapyp.FrecuenciaRespiratoria;
                visitapypEncontrado.FrecuenciaCardiaca = visitapyp.FrecuenciaCardiaca;
                visitapypEncontrado.EstadoAnimo = visitapyp.EstadoAnimo;
                visitapypEncontrado.FechaVisita = visitapyp.FechaVisita;
                visitapypEncontrado.Recomendaciones = visitapyp.Recomendaciones;
                _appContext.SaveChanges();
            }
            return visitapypEncontrado;
        }
    }
}