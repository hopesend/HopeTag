using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HopeTag
{

    /// <summary>
    /// Clase para la obtencion del album del artista
    /// </summary>
    [System.Serializable]
    public class Album
    {
        private string pathAlbum;
        /// <summary>
        /// Obtiene la Ruta del Directorio donde esta albergado el Album
        /// </summary>
        /// <value>
        /// el path del album
        /// </value>
        public string PathAlbum
        {
            get { return pathAlbum; }
            set { pathAlbum = value; }
        }

        private string nombreArtista;
        /// <summary>
        /// Obtiene el nombre del Artista del Album
        /// </summary>
        /// <value>
        /// valor string con el nombre del artista
        /// </value>
        public string NombreArtista
        {
            get { return nombreArtista; }
            set { nombreArtista = value; }
        }

        private int anyoAlbum;
        /// <summary>
        /// Obtiene el año de grabacion del Album
        /// </summary>
        /// <value>
        /// valor entero con el año de grabacion
        /// </value>
        public int AnyoAlbum
        {
            get { return anyoAlbum; }
            set { anyoAlbum = value; }
        }

        private string nombreAlbum;
        /// <summary>
        /// Obtiene el nombre del Album
        /// </summary>
        /// <value>
        /// valor string con el nombre del album
        /// </value>
        public string NombreAlbum
        {
            get { return nombreAlbum; }
            set { nombreAlbum = value; }
        }

        private string nombreCompletoAlbum;
        /// <summary>
        /// Obtiene el nombre Completo del Album con notacion (Nombre Album - año de grabacion - Titulo del Album)
        /// </summary>
        /// <value>
        /// Obtiene el nombre del album completo
        /// </value>
        public string NombreCompletoAlbum
        {
            get { return nombreCompletoAlbum; }
            set { nombreCompletoAlbum = value; }
        }

        private List<Cancion> listaCanciones;
        internal List<Cancion> ListaCanciones
        {
            get { return listaCanciones; }
            set { listaCanciones = value; }
        }

        public Album()
        {
            listaCanciones = new List<Cancion>();
        }

        public Album(string pathDir)
        {
            listaCanciones = new List<Cancion>();
            Obtener_Datos(pathDir);
        }

        public Album(string pathDir, bool colgante = true)
        {
            listaCanciones = new List<Cancion>();
            Obtener_Datos(pathDir, colgante);
        }

        private void Obtener_Datos(string pathDir)
        {
            pathAlbum = pathDir;
            string nombreDirectorio = Path.GetFileName(pathDir);
            string[] nombres = nombreDirectorio.Split(new string[] {" - "}, StringSplitOptions.None);

            if(nombres.Count().Equals(3))
            {
                NombreArtista = nombres[0];
                AnyoAlbum = int.Parse(nombres[1]);
                NombreAlbum = nombres[2];

                NombreCompletoAlbum = NombreArtista + " - " + AnyoAlbum + " - " + NombreAlbum;
            }
            else
            {
                NombreCompletoAlbum = nombreDirectorio;
            }
        }

        private void Obtener_Datos(string pathDir, bool colgante = true)
        {
            pathAlbum = pathDir;
            string nombreDirectorio = Path.GetFileName(Path.GetDirectoryName(pathDir)) + "/" + Path.GetFileName(pathDir);
            string[] nombres = nombreDirectorio.Split(new string[] { " - " }, StringSplitOptions.None);

            if (nombres.Count().Equals(3))
            {
                NombreArtista = nombres[0];
                AnyoAlbum = int.Parse(nombres[1]);
                NombreAlbum = nombres[2];

                NombreCompletoAlbum = NombreArtista + " - " + AnyoAlbum + " - " + NombreAlbum;
            }
            else
            {
                NombreCompletoAlbum = nombreDirectorio;
            }
        }

        public void Refrescar()
        {
            NombreCompletoAlbum = NombreArtista + " - " + AnyoAlbum + " - " + NombreAlbum;
        }
    }
}
