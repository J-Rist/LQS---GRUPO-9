using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        //Veterinario UpdateVeterinario(Veterinario veterinario);
        //void DeleteVeterinario(int idVeterinario);
        Mascota GetMascota(int idMascota);
        //IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro);
        
    }
}