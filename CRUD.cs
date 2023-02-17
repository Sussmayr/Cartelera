using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartelera
{
    class CRUD
    {
        public Municipios municipioEntidad { get; set; }
        public Estados estadoEntidad { get; set; }
        public Peliculas peliculasEntidad { get; set; }
        public Clasificacion clasificacionesEntidad { get; set; }
        public Genero generosEntidad { get; set; }

        public CRUD()
        {
        }

        //Insertar 
        public bool Insertar()
        {
            using (var context = new CarteleraEntities())
            {
                context.Peliculas.Add(peliculasEntidad);
                return context.SaveChanges() > 0;
            }
        }

        //Actualizar Registros
        public bool Actualizar()
        {
            using (var context = new CarteleraEntities())
            {
                var registro = context.Peliculas.Find(peliculasEntidad.ID);
                if (registro == null)
                {
                    return Insertar();
                }
                context.Entry(registro).CurrentValues.SetValues(peliculasEntidad);
                return context.SaveChanges() > 0;
            }
        }

        //seleccionar en DataGridView
        public Peliculas[] Seleccionar()
        {
            using (var context = new CarteleraEntities())
            {
                return context.Peliculas.ToArray();
            }
        }


    }
}
