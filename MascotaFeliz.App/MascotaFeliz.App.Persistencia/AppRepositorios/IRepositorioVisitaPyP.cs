using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioVisitaPyP
    {
        IEnumerable<VisitaPyP> GetAllVisitasPyP();
        VisitaPyP AddVisitaPyP(VisitaPyP visitapyp);
        VisitaPyP UpdateVisitaPyP(VisitaPyP visitapyp);
        void DeleteVisitaPyP(int idVisitaPyP);
        VisitaPyP GetVisitaPyP(int idVisitaPyP);
        IEnumerable<VisitaPyP> GetVisitasPyPPorFiltro(string filtro);    
    }
}