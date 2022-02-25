using Newtonsoft.Json;
using Quartz;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TP_Final.DAL;
using TP_Final.DAL.EntityFramework;
using TP_Final.Domain;
using TP_Final.IO;

namespace TP_Final.Jobs
{
    public class ReportePorVencerJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            using (IUnitOfWork bUoW = new UnitOfWork(new AccountManagerDbContext()))
            {
                List<EjemplarDTO> listaDTO = new List<EjemplarDTO>();
                List<Prestamo> listaPrestamos = bUoW.PrestamoRepository.prestamosADevolverEn(7);
                foreach (var prestamo in listaPrestamos)
                {
                    EjemplarDTO ejDTO = new EjemplarDTO();
                    ejDTO.ID = prestamo.Ejemplar.ID;
                    ejDTO.ISBN = prestamo.Ejemplar.Libro.ISBN;
                    listaDTO.Add(ejDTO);
                }

                var path = @".\Reporte.json";
                string json1 = JsonConvert.SerializeObject(listaDTO);
                File.WriteAllText(path, json1);
            }
            return null;
        }
    }
}
