using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TagLib;

namespace HopeTag
{
    public partial class fmHopeTag : Form
    {
        #region Variables publicas

        public List<Album> listaAlbumes;
        public string directorioConfiguracion = string.Empty;

        #endregion

        #region Constructores
        public fmHopeTag()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos Formulario Padre

        private void fmHopeTag_Load(object sender, EventArgs e)
        {
            listaAlbumes = new List<Album>();

            directorioConfiguracion = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "config.xml");
            if(System.IO.File.Exists(directorioConfiguracion))
            {
                cXML nuevoXml = new cXML();
                listaAlbumes = nuevoXml.Cargar_Clase_Serializable<List<Album>>(directorioConfiguracion, listaAlbumes);
                Insertar_Lista_Albumes();
                nuevoXml.Cerrar();
            }
        }

        private void fmHopeTag_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(listaAlbumes.Count > 0)
            {
                cXML nuevoXml = new cXML();
                nuevoXml.Guardar_Clase_Serializable<List<Album>>(directorioConfiguracion, listaAlbumes);
                nuevoXml.Cerrar();
            }
            else
            {
                System.IO.File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "config.xml"));
            }
        }

        #endregion

        #region Eventos TabControl

        private void tcBarraTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tcBarraTareas.SelectedIndex)
            {
                case 0: //Directorio
                    break;

                case 1: //Canciones
                    {
                        if(lvAlbumes.SelectedItems.Count > 0)
                            Completar_Tag(Buscar_Album(lvAlbumes.SelectedItems[0].Text));

                        break;
                    }
            }
        }

        #endregion

        #region Barra de Tareas

        private void btObtenerAlbumes_Click(object sender, EventArgs e)
        {
            if(fbdDirectorioTrabajo.ShowDialog() == DialogResult.OK)
            {
                Capturar_Albumes(fbdDirectorioTrabajo.SelectedPath);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            switch (tcBarraTareas.SelectedIndex)
            {
                case 0: //Directorio
                    {
                        foreach (ListViewItem itemSeleccionado in lvAlbumes.SelectedItems)
                        {
                            System.IO.Directory.Delete(Buscar_Cancion(Buscar_Album(lvAlbumes.SelectedItems[0].Text), itemSeleccionado.Text).PathArchivo, true);
                            listaAlbumes.Remove(Buscar_Album(lvAlbumes.SelectedItems[0].Text));
                            lvAlbumes.Items.Remove(itemSeleccionado);
                        }

                        break;
                    }

                case 1: //Canciones
                    {
                        foreach(ListViewItem itemSeleccionado in lvCanciones.SelectedItems)
                        {
                            System.IO.File.Delete(Buscar_Cancion(Buscar_Album(lvAlbumes.SelectedItems[0].Text), itemSeleccionado.Text).PathArchivo);
                            Buscar_Album(lvAlbumes.SelectedItems[0].Text).ListaCanciones.Remove(Buscar_Cancion(Buscar_Album(lvAlbumes.SelectedItems[0].Text), itemSeleccionado.Text));
                            lvCanciones.Items.Remove(itemSeleccionado);
                        }

                        break;
                    }
            }
        }

        #endregion

        #region Pestaña Directorio

        private void lvAlbumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAlbumes.SelectedItems.Count > 0)
            {
                Album albumSeleccionado = Buscar_Album(lvAlbumes.SelectedItems[0].Text);

                if (albumSeleccionado == null)
                {
                    tbAlbum.Text = "Error";
                    tbAnyo.Text = "Error";
                    tbArtista.Text = "Error";
                }
                else
                {
                    tbArtista.Text = albumSeleccionado.NombreArtista;
                    tbAnyo.Text = albumSeleccionado.AnyoAlbum.ToString();
                    tbAlbum.Text = albumSeleccionado.NombreAlbum;

                    Apagar_RadioButtons();
                    rbCD.Checked = true;

                    if (tbAlbum.Text.Contains("EP"))
                    {
                        Apagar_RadioButtons();
                        rbEP.Checked = true;
                    }
                    
                    if (tbAlbum.Text.Contains("Single"))
                    {
                        Apagar_RadioButtons();
                        rbSingle.Checked = true;
                    }
                    
                    if (tbAlbum.Text.Contains("Split"))
                    {
                        Apagar_RadioButtons();
                        rbSplit.Checked = true;
                    }

                    if (tbAlbum.Text.Contains("(With"))
                    {
                        lvSplit.Items.Clear();
                        lvSplit.Enabled = true;
                        string[] datos = tbAlbum.Text.Split(new string[] { "With " }, StringSplitOptions.None);
                        string[] grupos = datos[1].Split(new string[] {" & "}, StringSplitOptions.None);
                        foreach (string grupo in grupos)
                        {
                            lvSplit.Items.Add(grupo.Trim(')'));
                        }
                    }
                    else
                    {
                        lvSplit.Items.Clear();
                        lvSplit.Enabled = false;
                    }
                }

                if (tbAlbum.Text.Equals(string.Empty) && tbArtista.Text.Equals(string.Empty) && tbAnyo.Text.Equals("0"))
                    btPropuesta.Enabled = true;
                else
                    btPropuesta.Enabled = false;

                lvCanciones.Clear();
                lvCanciones.Items.AddRange(Obtener_Canciones(albumSeleccionado));
            }
        }

        private void btPropuesta_Click(object sender, EventArgs e)
        {
            string[] datos = lvAlbumes.SelectedItems[0].Text.Split(new string[] { " - " }, StringSplitOptions.None);
            int aux = 0;

            foreach (string dato in datos)
            {
                if (int.TryParse(dato, out aux))
                    tbAnyo.Text = dato;
                else
                {
                    if (tbArtista.Text.Equals(string.Empty))
                        tbArtista.Text = dato;
                    else
                    {
                        if (tbAlbum.Text.Equals(string.Empty))
                            tbAlbum.Text = dato;
                    }
                }
            }

            if(tbAnyo.Text.Equals(string.Empty))
            {
                //Buscar dentro de los tags de las canciones
            }
        }

        private void btGuardarDirectorio_Click(object sender, EventArgs e)
        {
            if (tbAlbum.Text.Equals(string.Empty) || tbArtista.Text.Equals(string.Empty) || tbAnyo.Text.Equals(string.Empty))
                MessageBox.Show("Los campos no pueden estar vacios para renombrar un directorio....", "ERROR");
            else
            {
                Album albumCorregido = Buscar_Album(lvAlbumes.SelectedItems[0].Text);
                string pathAntiguo = albumCorregido.PathAlbum;
                string pathNuevo = string.Empty;

                if(tbAlbum.Text.Contains("/"))
                {
                    //obtener ruta antes del cd
                    string aux = Path.GetFileName(Path.GetDirectoryName(pathAntiguo));
                    string aux2 = pathAntiguo.Remove(pathAntiguo.IndexOf(aux));
                    //añadir a esa ruta los nuevos nombres de cd
                    pathNuevo = Path.Combine(aux2, tbArtista.Text + " - " + tbAnyo.Text + " - " + tbAlbum.Text);
                    //añadir al final el cd
                    pathNuevo = pathNuevo.Replace("/", "\\");
                }
                else
                    pathNuevo = Path.Combine(Path.GetDirectoryName(pathAntiguo), tbArtista.Text + " - " + tbAnyo.Text + " - " + tbAlbum.Text);

                Directory.Move(pathAntiguo, pathNuevo);

                lvAlbumes.SelectedItems[0].Text = tbArtista.Text + " - " + tbAnyo.Text + " - " + tbAlbum.Text;
                lvAlbumes.SelectedItems[0].ForeColor = Color.Green;
                lvAlbumes.Refresh();

                albumCorregido.NombreArtista = tbArtista.Text;
                albumCorregido.NombreAlbum = tbAlbum.Text;
                albumCorregido.AnyoAlbum = int.Parse(tbAnyo.Text);
                albumCorregido.Refrescar();
            }
        }

        private void vaciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvAlbumes.Clear();
            listaAlbumes = new List<Album>();
        }

        #endregion

        #region Pestaña Canciones

        private void lvCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCanciones.SelectedItems.Count > 0)
            {
                Album albumSeleccionado = Buscar_Album(lvAlbumes.SelectedItems[0].Text);
                Cancion cancionSeleccionada = Buscar_Cancion(albumSeleccionado, lvCanciones.SelectedItems[0].Text);

                tbNumeroPista.Text = cancionSeleccionada.NumeroPista.ToString();
                tbTituloPista.Text = cancionSeleccionada.NombrePista;
                tbArchivoMp3.Text = lvCanciones.SelectedItems[0].Text;
                lbBitrate.Text = cancionSeleccionada.Bitrate.ToString();
            }
        }

        private void btPropuestaAlbum_Click(object sender, EventArgs e)
        {
            tbArtistaTag.Text = tbArtista.Text;
            tbAnyoTag.Text = tbAnyo.Text;
            tbAlbumTag.Text = tbAlbum.Text;
        }

        private void btPropuestaPista_Click(object sender, EventArgs e)
        {
            if(lvCanciones.SelectedItems.Count > 0)
            {
                Cancion cancionSeleccionada = Buscar_Cancion(Buscar_Album(lvAlbumes.SelectedItems[0].Text), lvCanciones.SelectedItems[0].Text);

                if(Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Contains('.'))
                {
                    if (Es_Numerico(Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('.')[0].Trim()))
                        tbNumeroPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('.')[0].Trim();
                    else
                        tbNumeroPista.Text = "0";
                    cancionSeleccionada.NumeroPista = int.Parse(tbNumeroPista.Text);

                    if (Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('.')[1].Contains('_'))
                        tbTituloPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('.')[1].Replace('_', ' ');
                    else
                        tbTituloPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('.')[1];
                    cancionSeleccionada.NombrePista = tbTituloPista.Text;

                    return;
                }

                if (Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Contains('-'))
                {
                    if (Es_Numerico(Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('-')[0].Trim()))
                        tbNumeroPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('-')[0].Trim();
                    else
                        tbNumeroPista.Text = "0";
                    cancionSeleccionada.NumeroPista = int.Parse(tbNumeroPista.Text);

                    if (Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('-')[1].Contains('_'))
                        tbTituloPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('-')[1].Replace('_', ' ');
                    else
                        tbTituloPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('-')[1];
                    cancionSeleccionada.NombrePista = tbTituloPista.Text;

                    return;
                }

                if (Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Contains('_'))
                {
                    if (Es_Numerico(Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('_')[0].Trim()))
                        tbNumeroPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('_')[0].Trim();
                    else
                        tbNumeroPista.Text = "0";
                    cancionSeleccionada.NumeroPista = int.Parse(tbNumeroPista.Text);

                    tbTituloPista.Text = Path.GetFileNameWithoutExtension(cancionSeleccionada.NombreCompletoPista).Split('_')[1];
                    cancionSeleccionada.NombrePista = tbTituloPista.Text;

                    return;
                }
            }
        }

        private void btCambiarCaracteres_Click(object sender, EventArgs e)
        {
            if (tbCaracteresAntes.Text.Equals(string.Empty) || tbCaracteresDespues.Text.Equals(string.Empty))
                MessageBox.Show("Debe de introducir como minimo un caracter a cambiar", "ERROR");
            else
            {
                foreach(ListViewItem cancion in lvCanciones.Items)
                {
                    Cancion cancionSeleccionada = Buscar_Cancion(Buscar_Album(lvAlbumes.SelectedItems[0].Text), cancion.Text);
                    cancion.Text = cancion.Text.Replace(tbCaracteresAntes.Text, tbCaracteresDespues.Text);
                    cancionSeleccionada.NombreCompletoPista = cancion.Text;
                }
            }
        }

        private void btModificarNombre_Click(object sender, EventArgs e)
        {
            if(lvCanciones.SelectedItems.Count > 0)
            {
                Buscar_Cancion(Buscar_Album(lvAlbumes.SelectedItems[0].Text), lvCanciones.SelectedItems[0].Text).NombreCompletoPista = tbArchivoMp3.Text;
                lvCanciones.SelectedItems[0].Text = tbArchivoMp3.Text;              
            }
        }

        private void btTransformar_Click(object sender, EventArgs e)
        {
            //Poner Punto
            foreach(ListViewItem item in lvCanciones.Items)
            {
                Cancion cancionSeleccionada = Buscar_Cancion(Buscar_Album(lvAlbumes.SelectedItems[0].Text), item.Text);

                if (item.Text[2] != '.')
                    item.Text = item.Text.Insert(2, ".");

                for (int cont = 0; cont < item.Text.Length; cont++)
                {
                    switch (item.Text[cont])
                    {
                        case ' ':
                        case '(':
                        case '[':
                        case '-':
                            {
                                char[] a = item.Text.ToCharArray();
                                a[cont + 1] = char.ToUpper(a[cont + 1]);
                                item.Text = new string(a);
                                break;
                            }
                    }
                }

                cancionSeleccionada.NombreCompletoPista = item.Text;
            }
        }

        #endregion

        #region Metodos

        private void Capturar_Albumes(string pathDirectorioTrabajo)
        {
            lvAlbumes.Clear();
            listaAlbumes = new List<Album>();

            Inicializar_BarraAlbumes(Directory.EnumerateDirectories(pathDirectorioTrabajo).Count());

            foreach(string directorioCapturado in Directory.EnumerateDirectories(pathDirectorioTrabajo))
            {
                if (Es_Directorio_Mp3(directorioCapturado))
                {
                    Album nuevoAlbum = new Album(directorioCapturado);
                    listaAlbumes.Add(nuevoAlbum);

                    ListViewItem nuevoItem = new ListViewItem();

                    nuevoItem.ForeColor = nuevoAlbum.NombreArtista == null ? Color.Red : Color.Green;
                    nuevoItem.Text = nuevoAlbum.NombreCompletoAlbum;

                    lvAlbumes.Items.Add(nuevoItem);
                }
                else
                {
                    Capturar_Subniveles_Album(directorioCapturado);
                }

                Progreso_BarraAlbumes();
            }

            Finalizar_BarraAlbumes();
        }

        private void Insertar_Lista_Albumes()
        {
            Inicializar_BarraAlbumes(listaAlbumes.Count);

            foreach(Album albumSeleccionado in listaAlbumes)
            {
                ListViewItem nuevoItem = new ListViewItem();

                nuevoItem.ForeColor = albumSeleccionado.NombreArtista == null ? Color.Red : Color.Green;
                nuevoItem.Text = albumSeleccionado.NombreCompletoAlbum;

                lvAlbumes.Items.Add(nuevoItem);

                Progreso_BarraAlbumes();
            }

            Finalizar_BarraAlbumes();
        }

        private Album Buscar_Album(string nombreCompletoAlbum)
        {
            foreach(Album albumSeleccionado in listaAlbumes)
            {
                if (albumSeleccionado.NombreCompletoAlbum.Equals(nombreCompletoAlbum))
                    return albumSeleccionado;
            }

            return null;
        }

        private Cancion Buscar_Cancion(Album albumSeleccionado, string pista)
        {
            foreach(Cancion cancion in albumSeleccionado.ListaCanciones)
            {
                if (cancion.NombreCompletoPista.Equals(pista))
                    return cancion;
            }

            return null;
        }

        private void Apagar_RadioButtons()
        {
            rbCD.Checked = false;
            rbEP.Checked = false;
            rbSingle.Checked = false;
            rbSplit.Checked = false;
        }

        private bool Es_Directorio_Mp3(string pathDir)
        {
            foreach(string archivo in Directory.GetFiles(pathDir))
            {
                if (Archivo_Permitido(archivo))
                    return true;
            }

            return false;
        }

        private bool Archivo_Permitido(string pathArchivo)
        {
            switch(Path.GetExtension(pathArchivo))
            {
                case ".mp3":
                case ".flac":
                case ".wav":    
                    return true;
                           
                default:
                    return false;
            }
        }

        private void Capturar_Subniveles_Album(string pathDir)
        {
            foreach(string directorioColgante in Directory.EnumerateDirectories(pathDir))
            {
                if (Es_Directorio_Mp3(directorioColgante))
                {
                    Album nuevoAlbum = new Album(directorioColgante, true);
                    listaAlbumes.Add(nuevoAlbum);

                    ListViewItem nuevoItem = new ListViewItem();

                    nuevoItem.ForeColor = nuevoAlbum.NombreArtista == null ? Color.Red : Color.Green;
                    nuevoItem.Text = nuevoAlbum.NombreCompletoAlbum;

                    lvAlbumes.Items.Add(nuevoItem);
                }
            }
        }

        private ListViewItem[] Obtener_Canciones(Album albumSeleccionado)
        {
            List<ListViewItem> listaItems = new List<ListViewItem>();

            foreach(string rutaArchivo in Directory.GetFiles(albumSeleccionado.PathAlbum))
            {
                if (Es_Archivo_Musical(rutaArchivo))
                {
                    Cancion nuevaCancion = new Cancion(rutaArchivo);

                    ListViewItem nuevoItem = new ListViewItem(nuevaCancion.NombreCompletoPista);
                    albumSeleccionado.ListaCanciones.Add(nuevaCancion);
                    listaItems.Add(nuevoItem);
                }
            }

            return listaItems.ToArray();
        }

        private void Completar_Tag(Album albumSeleccionado)
        {
            string artista = string.Empty;
            string anyo = string.Empty;
            string album = string.Empty;

            foreach(Cancion cancion in albumSeleccionado.ListaCanciones)
            {
                if (artista.Equals(string.Empty))
                    artista = cancion.TagArtista;
                else if (!artista.Equals(cancion.TagArtista))
                        artista = "[Diferente]";

                if (anyo.Equals(string.Empty))
                    anyo = cancion.TagAnyo.ToString();
                else if (!anyo.Equals(cancion.TagAnyo.ToString()))
                    anyo = "[Diferente]";

                if (album.Equals(string.Empty))
                    album = cancion.TagAlbum;
                else if (!album.Equals(cancion.TagAlbum))
                    album = "[Diferente]";
            }

            tbArtistaTag.Text = artista;
            tbAnyoTag.Text = anyo;
            tbAlbumTag.Text = album;
        }

        private bool Es_Archivo_Musical(string pathArchivo)
        {
            switch(Path.GetExtension(pathArchivo))
            {
                case ".mp3":
                case ".wav":
                    return true;

                default:
                    return false;
            }
        }

        private void Inicializar_BarraAlbumes(int total)
        {
            tspbBarraAlbumes.Maximum = total;
            tspbBarraAlbumes.Step = 1;
            tspbBarraAlbumes.Value = 0;
        }

        private void Progreso_BarraAlbumes()
        {
            tspbBarraAlbumes.PerformStep();
        }

        private void Finalizar_BarraAlbumes()
        {
            tspbBarraAlbumes.Value = 0;
        }

        private bool Es_Numerico(string cadena)
        {
            for (byte cont = 0; cont < cadena.Length; cont++)
            {
                if (!char.IsDigit(cadena[cont]))
                {
                    if (cadena[cont] != '.' && cadena[cont] != ',')
                        return false;
                }
            }

            return true;
        }

        #endregion                
    }
}
