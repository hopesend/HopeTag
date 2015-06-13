using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NAudio;
using NAudio.Wave;

namespace HopeTag
{
    public enum formatoAudio
    {
        mp3,
        wav
    }
    public class Reproduccion
    {
        private Thread Hilo;
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;

        private List<string> listaReproduccion;
        public List<string> ListaReproduccion
        {
            get { return listaReproduccion; }
            set { listaReproduccion = value; }
        }

        public Reproduccion()
        {
            waveOutDevice = new WaveOut();
            ListaReproduccion = new List<string>();
        }

        public Reproduccion(string[] pathCanciones)
        {
            ListaReproduccion = new List<string>();
            waveOutDevice = new WaveOut();

            ListaReproduccion.AddRange(pathCanciones);
        }

        public void Play()
        {
            Hilo = new Thread(new ThreadStart(Hilo_Reproduccion));
            Hilo.Start();
        }

        public void Play(string pathCancion)
        {
            audioFileReader = new AudioFileReader(pathCancion);
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void Vaciar_Lista_Reproduccion()
        {
            ListaReproduccion = new List<string>();
        }

        public void Add_Cancion_Lista_Reproduccion(string[] canciones)
        {
            ListaReproduccion.AddRange(canciones);
        }

        public void Add_Cancion_Lista_Reproduccion(string cancion)
        {
            ListaReproduccion.Add(cancion);
        }

        private void Hilo_Reproduccion()
        {
            foreach (string pathCancion in ListaReproduccion)
            {
                Play(pathCancion);
                do
                {
                } 
                while (waveOutDevice.PlaybackState == PlaybackState.Playing);
            }
        }

        public void Cerrar()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            //if (mainOutputStream != null)
            //{
            //    audioFileReader.Dispose();
            //    audioFileReader = null;
            //}
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }

            if(Hilo != null)
            {
                Hilo.Abort();
            }
        }
    }
}
