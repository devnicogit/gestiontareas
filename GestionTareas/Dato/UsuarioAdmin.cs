using GestionTareas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionTareas.Dato
{
    public class UsuarioAdmin
    {
        public IEnumerable<usuarios> Consultar()
        {   
            
            using (BD_TAREASEntities contexto = new BD_TAREASEntities())
            {
                return contexto.usuarios.AsNoTracking().ToList();
            }
        }
    }
}