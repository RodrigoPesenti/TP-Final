using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Final.IO;

namespace TP_Final.Domain
{
    public class Libro
    {
        public Int64 ID { get; set; }

        public Int64 ISBN { get; set; }

        public virtual List<Ejemplar> Ejemplares { get; set; } = new List<Ejemplar>();

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public List<EjemplarDTO> EjemplaresDisponibles()
        {
            List<EjemplarDTO> listaEjemplaresDTO = new List<EjemplarDTO>();
            foreach (var ejemplar in Ejemplares)
            {
                if (ejemplar.disponible())
                {
                    EjemplarDTO ejemplarDTO = new EjemplarDTO
                    {
                        ID = ejemplar.ID,
                        ISBN = ejemplar.Libro.ISBN
                    };
                    listaEjemplaresDTO.Add(ejemplarDTO);
                }
            }
            return listaEjemplaresDTO;
        }
    }
}
