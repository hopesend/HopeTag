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
        private IWavePlayer waveOutDevice;
        private WaveStream mp3Reader;
        private WaveStream waveReader;

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
            Play(listaReproduccion[0]);
        }

        public void Play(string pathCancion)
        {
            mp3Reader = new AudioFileReader(pathCancion);
            waveOutDevice.Init(mp3Reader);
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
        }
    }
}
