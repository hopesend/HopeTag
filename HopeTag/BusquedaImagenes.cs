using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Net;

namespace TagMp3
{
    class BusquedaImagenes
    {
        public List<Image> Google(String PatronBusqueda)
        {
            WebClient client = new WebClient();
            List<string> UrlImagenes = new List<string>();
            List<Image> ImagenesRescatadas = new List<Image>();

            PatronBusqueda = PatronBusqueda.Replace(' ', '+');

            string htmlString = client.DownloadString("https://www.google.es/search?q=" + PatronBusqueda + "&hl=es&prmd=imvns&tbm=isch&tbo=u&source=univ&sa=X&ei=xUiGUJDeEeLB0QW4zoDYBA&ved=0CDYQsAQ");

            UrlImagenes = ObtenerImagenes(htmlString);

            foreach (string Url in UrlImagenes)
            {
                // Buscamos la url que enlaza con la imagen
                string UrlImagen = Url.Remove(0, Url.IndexOf("http"));
                UrlImagen = UrlImagen.Remove(UrlImagen.IndexOf("&amp"));
                try
                {
                    // La Añadimos al ImageList
                    ImagenesRescatadas.Add(new Bitmap(client.OpenRead(UrlImagen)));
                }
                catch
                {
                    // Lo que carga no es una imagen
                }
            }
            return ImagenesRescatadas;
        }

        public List<Image> Amazon(String PatronBusqueda)
        {
            WebClient client = new WebClient();
            List<string> UrlImagenes = new List<string>();
            List<Image> ImagenesRescatadas = new List<Image>();

            PatronBusqueda = PatronBusqueda.Replace(' ', '+');

            string htmlString = client.DownloadString("http://www.amazon.com/s/ref=nb_sb_noss?url=search-alias%3Dpopular&field-keywords=" + PatronBusqueda);

            UrlImagenes = ObtenerImagenes(htmlString);

            foreach (string Url in UrlImagenes)
            {
                // Buscamos la url que enlaza con la imagen
                string UrlImagen = Url.Remove(0, Url.IndexOf("http"));
                UrlImagen = UrlImagen.Remove(UrlImagen.IndexOf("&amp"));
                try
                {
                    // La Añadimos al ImageList
                    ImagenesRescatadas.Add(new Bitmap(client.OpenRead(UrlImagen)));
                }
                catch
                {
                    // Lo que carga no es una imagen
                }
            }
            return ImagenesRescatadas;
        }

        private List<string> ObtenerImagenes(string htmlString)
        {
            List<string> Imagenes = new List<string>();
            string PatronBusqueda = @"(imgurl).*?(&amp)";

            Regex rgx = new Regex(PatronBusqueda, RegexOptions.IgnoreCase);
            MatchCollection Coincidencias = rgx.Matches(htmlString);

            for (int i = 0, l = Coincidencias.Count; i < l; i++)
            {
                Imagenes.Add(Coincidencias[i].Value);
            }

            return Imagenes;
        }
    }
}
