using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class EditarVisitasPyPModel : PageModel
    {
        private readonly IRepositorioVisitaPyP _repoVisitaPyP;
        [BindProperty]
        public VisitaPyP visitapyp {get;set;}

        public EditarVisitasPyPModel()
        {
            this._repoVisitaPyP = new RepositorioVisitaPyP(new Persistencia.AppContext());
        }
        
        public IActionResult OnGet(int? visitapypId)
        {
            if (visitapypId.HasValue)
            {
                visitapyp = _repoVisitaPyP.GetVisitaPyP(visitapypId.Value);
            }
            else
            {
                visitapyp = new VisitaPyP();
            }
            if (visitapyp == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (visitapyp.Id > 0)
            {
                visitapyp = _repoVisitaPyP.UpdateVisitaPyP(visitapyp);
            }
            else
            {
                _repoVisitaPyP.AddVisitaPyP(visitapyp);
            }
            return Page();
        }
    }
}
