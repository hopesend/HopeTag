using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;
using TagLib;

namespace HopeTag
{
    [System.Serializable]
    class Cancion
    {
        #region Variables
        private int numeroPista;
        public int NumeroPista
        {
            get { return numeroPista; }
            set { numeroPista = value; }
        }

        private string nombrePista;
        public string NombrePista
        {
            get { return nombrePista; }
            set { nombrePista = value; }
        }

        private string nombreCompletoPista;
        public string NombreCompletoPista
        {
            get { return nombreCompletoPista; }
            set { nombreCompletoPista = value; }
        }

        private string pathArchivo;
        public string PathArchivo
        {
            get { return pathArchivo; }
            set { pathArchivo = value; }
        }

        private string tagArtista;
        public string TagArtista
        {
            get { return tagArtista; }
            set { tagArtista = value; }
        }

        private string tagAlbum;
        public string TagAlbum
        {
            get { return tagAlbum; }
            set { tagAlbum = value; }
        }

        private int tagAnyo;
        public int TagAnyo
        {
            get { return tagAnyo; }
            set { tagAnyo = value; }
        }

        private int bitrate;
        public int Bitrate
        {
            get { return bitrate; }
            set { bitrate = value; }
        }

        private List<Bitmap> tagCaratula;
        public List<Bitmap> TagCaratula
        {
            get { return tagCaratula; }
            set { tagCaratula = value; }
        }

        private Bitmap tagCaratulaPrincipal;
        public Bitmap TagCaratulaPrincipal
        {
            get { return tagCaratulaPrincipal; }
            set { tagCaratulaPrincipal = value; }
        }

        #endregion

        #region Constructores
        public Cancion()
        {
            TagCaratula = new List<Bitmap>();
        }

        public Cancion(string ruta)
        {
            TagCaratula = new List<Bitmap>();
            Capturar_Tags(ruta);
        }

        #endregion

        #region Metodos Publicos

        public void Grabar_Datos_Tag()
        {
            using (TagLib.File file = TagLib.File.Create(PathArchivo))
            {
                Vaciar_Tags(file);

                file.Tag.AlbumArtists = new string[] { TagArtista };
                file.Tag.Performers = new string[] { TagArtista };
                file.Tag.Album = TagAlbum;
                file.Tag.Year = Convert.ToUInt16(TagAnyo);
                file.Tag.Track = Convert.ToUInt16(NumeroPista);
                file.Tag.Title = NombrePista;
                file.Tag.Comment = "Candarian Demon";

                TagLib.Picture caratulaPrincipal = new TagLib.Picture();
                caratulaPrincipal.Type = TagLib.PictureType.FrontCover;
                caratulaPrincipal.MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg;
                caratulaPrincipal.Description = "Cover";
                MemoryStream ms = new MemoryStream();
                TagCaratulaPrincipal.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ms.Position = 0;
                caratulaPrincipal.Data = TagLib.ByteVector.FromStream(ms);
                file.Tag.Pictures = new TagLib.IPicture[1] { caratulaPrincipal };
                ms.Close();

                file.Save();
                file.Dispose();
            }

            string nuevoPath = Path.Combine(Path.GetDirectoryName(PathArchivo), NombreCompletoPista);
            if(!nuevoPath.Equals(PathArchivo))
                System.IO.File.Move(PathArchivo, nuevoPath);
        }

        #endregion

        #region Metodos Internos

        private void Capturar_Tags(string ruta)
        {
            TagArtista = string.Empty;
            TagAlbum = string.Empty;
            TagAnyo = 0;

            PathArchivo = ruta;
            NombreCompletoPista = Path.GetFileName(PathArchivo);
            TagLib.File file = TagLib.File.Create(ruta);

            //Buscar Artista
            if (file.Tag.AlbumArtists.Count().Equals(0))
            {
                if (file.Tag.Artists.Count() > 0)
                    TagArtista = file.Tag.Artists[0];
            }
            else
            {
                if (file.Tag.AlbumArtists.Count() > 0)
                    TagArtista = file.Tag.AlbumArtists[0];
            }

            //Buscar Nombre Album
            if (file.Tag.Album != null)
                TagAlbum = file.Tag.Album;

            //Buscar Año de grabacion
            TagAnyo = (int)file.Tag.Year;

            //Buscar Numero de Pista
            NumeroPista = (int)file.Tag.Track;

            //Buscar Titulo de la pista
            if (file.Tag.Title != null)
                NombrePista = file.Tag.Title;

            //Buscar Bitrate de la pista
            Bitrate = (int)file.Properties.AudioBitrate;

            //Insertamos las imagenes a los picturebox si existieran
            foreach (IPicture picture in file.Tag.Pictures)
            {
                Bitmap caratulaAux;
                MemoryStream memStream = new MemoryStream(picture.Data.Data);

                caratulaAux = (Bitmap)Image.FromStream(memStream);
                caratulaAux.Tag = picture.Type.ToString();
                tagCaratula.Add(caratulaAux);

                memStream.Close();
            }

            file.Dispose();
        }

        private void Vaciar_Tags(TagLib.File file)
        {
            file.Tag.Album = string.Empty;
            file.Tag.AlbumArtists  = new string[] {};
            file.Tag.AlbumArtistsSort  = new string[] {};
            file.Tag.AlbumSort = string.Empty;
            file.Tag.BeatsPerMinute = 0;
            file.Tag.Comment = string.Empty;
            file.Tag.Composers  = new string[] {};
            file.Tag.ComposersSort  = new string[] {};
            file.Tag.Conductor = string.Empty;
            file.Tag.Copyright = string.Empty;
            file.Tag.Disc = 0;
            file.Tag.DiscCount = 0;
            file.Tag.Genres  = new string[] {};
            file.Tag.Grouping = string.Empty;
            file.Tag.Lyrics = string.Empty;
            file.Tag.Performers  = new string[] {};
            file.Tag.PerformersSort  = new string[] {};
            file.Tag.Title = string.Empty;
            file.Tag.TitleSort = string.Empty;
            file.Tag.Track = 0;
            file.Tag.TrackCount = 0;
            file.Tag.Year = 0;
        }

        #endregion
    }
}
