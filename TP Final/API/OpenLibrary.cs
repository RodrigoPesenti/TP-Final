using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using TP_Final.IO;

namespace TP_Final.API
{
    public class OpenLibrary : IApiConsultasBiblioteca
    {
        public List<LibroDTO> Consultar(string pTitulo)
        {
            // Establecimiento del protocolo ssl de transporte
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            // Url de busqueda
            var mUrl = "http://openlibrary.org/search.json?title=" + pTitulo.Replace(" ", "+");

            // Se crea el request http
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            try
            {
                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();

                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    //Creamos la lista a devolver
                    List<LibroDTO> librosDTO = new List<LibroDTO>();

                    // Se iteran cada uno de los resultados.
                    int i = 0;
                    int cantidad = mResponseJSON.docs.Count;
                    while ((i <= cantidad - 1) && (i < 10))
                    {
                        //Creamos el DTO
                        LibroDTO libroDTO = new LibroDTO();

                        // De esta manera se accede a los componentes de cada item
                        var bResponseItem = mResponseJSON.docs[i];

                        // Se decodifican algunos elementos HTML
                        libroDTO.Titulo = HttpUtility.HtmlDecode(bResponseItem.title.ToString());
                        if (bResponseItem.author_name != null)
                        {
                            libroDTO.Autor = HttpUtility.HtmlDecode(bResponseItem.author_name[0].ToString());
                        }
                        else
                        {
                            libroDTO.Autor = "Anonimo";
                        }
                        if (bResponseItem.isbn != null)
                        {
                            string isbn = HttpUtility.HtmlDecode(bResponseItem.isbn[0].ToString());
                            string isbnSinX = isbn.Replace("X", "");
                            libroDTO.ISBN = Int64.Parse(isbnSinX);
                        }
                        else
                        {
                            libroDTO.ISBN = 0;
                        }
                        librosDTO.Add(libroDTO);
                        i++;
                    }
                    return librosDTO;
                }
            }

            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();

                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
                return new List<LibroDTO>();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: {0}", ex.Message);
                return new List<LibroDTO>();
            }
        }

    }
}
