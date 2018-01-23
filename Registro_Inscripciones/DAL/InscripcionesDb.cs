using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Registro_Inscripciones.Entidades;

namespace Registro_Inscripciones.DAL
{
    public class InscripcionesDb: DbContext
    {
        public InscripcionesDb() : base("ConStr")
        {
                
        }

        public DbSet<Inscripciones> Inscripcion { set; get; }
    }
}
