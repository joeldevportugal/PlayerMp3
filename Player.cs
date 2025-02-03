using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Player
{
    public partial class Player : Form
    {
        private string selectedFile;
        private List<string> musicList = new List<string>();
        private AudioFileReader audioFile;
        public WaveOutEvent outputDevice; // Tornar público
        private Timer timer;
        private TimeSpan elapsedTime;
        private TimeSpan totalTime;
        private bool isRepeating = false; // Variável para controlar o estado de repetição
        private string firstMusic; // Variável para armazenar a primeira música

        public Player()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += Timer_Tick;

            // Adicionar o evento SelectedIndexChanged para Lstmusica
            Lstmusica.SelectedIndexChanged += Lstmusica_SelectedIndexChanged;
        }

        private void Lstmusica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lstmusica.SelectedItem != null)
            {
                string selectedFile = Lstmusica.SelectedItem.ToString();
                audioFile = new AudioFileReader(selectedFile);
                TimeSpan duration = audioFile.TotalTime;
                LblMusica.Text = $"{duration.ToString(@"mm\:ss")}";
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            play();
        }

        private void play()
        {
            if (Lstmusica.SelectedItem != null)
            {
                // Armazenar a primeira música selecionada
                if (firstMusic == null)
                {
                    firstMusic = Lstmusica.SelectedItem.ToString();
                }

                // Se a música estiver pausada, continuar de onde parou
                if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Paused)
                {
                    outputDevice.Play();
                    timer.Start();
                    LblEstado.Text = "A tocar: " + System.IO.Path.GetFileNameWithoutExtension(Lstmusica.SelectedItem.ToString());
                }
                else
                {
                    // Parar a música atual, se houver
                    if (outputDevice != null)
                    {
                        outputDevice.Stop();
                        outputDevice.Dispose();
                        audioFile.Dispose();
                    }

                    string selectedFile = Lstmusica.SelectedItem.ToString();
                    audioFile = new AudioFileReader(selectedFile);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    // Iniciar contagem de tempo
                    elapsedTime = TimeSpan.Zero; // Iniciar do zero
                    totalTime = audioFile.TotalTime;
                    Lbltempo_Decorrido.Text = elapsedTime.ToString(@"mm\:ss");
                    trtempo.Maximum = (int)totalTime.TotalSeconds;
                    trtempo.Value = (int)elapsedTime.TotalSeconds;
                    timer.Start();

                    // Atualizar a duração da música
                    LblMusica.Text = $"{totalTime.ToString(@"mm\:ss")}";

                    // Exibir "A tocar" e o nome da música
                    LblEstado.Text = "A tocar: " + System.IO.Path.GetFileNameWithoutExtension(selectedFile);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (elapsedTime < totalTime)
            {
                elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));
                Lbltempo_Decorrido.Text = elapsedTime.ToString(@"mm\:ss");

                // Verificar se o valor está dentro dos limites antes de definir o valor do trtempo
                int newValue = (int)elapsedTime.TotalSeconds;
                if (newValue >= trtempo.Minimum && newValue <= trtempo.Maximum)
                {
                    trtempo.Value = newValue;
                }
            }
            else
            {
                timer.Stop();
                if (isRepeating)
                {
                    LblEstado.Text = "Repetição ativada";
                    play();
                }
            }
        }

        private void trtempo_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                outputDevice.Pause();
                audioFile.CurrentTime = TimeSpan.FromSeconds(trtempo.Value);
                elapsedTime = audioFile.CurrentTime;
                Lbltempo_Decorrido.Text = elapsedTime.ToString(@"mm\:ss");
                outputDevice.Play();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    musicList.Add(filePath);
                    Lstmusica.Items.Add(filePath);

                    // Manter a primeira posição selecionada
                    Lstmusica.SelectedIndex = 0;

                    // Obter a duração da música e exibir em lblMusica
                    audioFile = new AudioFileReader(filePath);
                    TimeSpan duration = audioFile.TotalTime;
                    LblMusica.Text = $"{duration.ToString(@"mm\:ss")}";
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair Do Programa?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            Anterior();
        }

        private void Anterior()
        {
            if (Lstmusica.SelectedIndex > 0)
            {
                // Parar a música atual
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    audioFile.Dispose();
                }

                Lstmusica.SelectedIndex--;
                BtnPlay_Click(null, EventArgs.Empty);
            }
        }

        private void BtnAvançar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (audioFile != null)
            {
                // Avançar 10 segundos
                TimeSpan newTime = audioFile.CurrentTime.Add(TimeSpan.FromSeconds(10));
                if (newTime < audioFile.TotalTime)
                {
                    audioFile.CurrentTime = newTime;
                    elapsedTime = audioFile.CurrentTime;
                    Lbltempo_Decorrido.Text = elapsedTime.ToString(@"mm\:ss");
                    trtempo.Value = (int)elapsedTime.TotalSeconds;
                }
                else
                {
                    // Se o novo tempo exceder a duração total da música, parar a música
                    outputDevice.Stop();
                    timer.Stop();
                }
            }
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            proximo();
        }

        private void proximo()
        {
            if (Lstmusica.SelectedIndex < Lstmusica.Items.Count - 1)
            {
                // Parar a música atual
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    audioFile.Dispose();
                }

                Lstmusica.SelectedIndex++;
                BtnPlay_Click(null, EventArgs.Empty);
            }
        }

        private void BtnRecuar_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (audioFile != null)
            {
                // Retroceder 10 segundos
                TimeSpan newTime = audioFile.CurrentTime.Subtract(TimeSpan.FromSeconds(10));
                if (newTime > TimeSpan.Zero)
                {
                    audioFile.CurrentTime = newTime;
                    elapsedTime = audioFile.CurrentTime;
                    Lbltempo_Decorrido.Text = elapsedTime.ToString(@"mm\:ss");
                    trtempo.Value = (int)elapsedTime.TotalSeconds;
                }
                else
                {
                    // Se o novo tempo for menor que zero, definir o tempo como zero
                    audioFile.CurrentTime = TimeSpan.Zero;
                    elapsedTime = audioFile.CurrentTime;
                    Lbltempo_Decorrido.Text = elapsedTime.ToString(@"mm\:ss");
                    trtempo.Value = 0;
                }
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            stop();
        }

        private void stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                audioFile.Dispose();
                timer.Stop();
                elapsedTime = TimeSpan.Zero;
                Lbltempo_Decorrido.Text = elapsedTime.ToString(@"mm\:ss");
                trtempo.Value = 0;

            }
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            pause();
        }

        private void pause()
        {
            if (outputDevice != null)
            {
                outputDevice.Pause();
                timer.Stop();
            }
        }   



        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            play();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void anterioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anterior();
        }

        private void seguinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proximo();
        }

        private void BtnVolume_Click(object sender, EventArgs e)
        {
            frVolume f = new frVolume(this);
            f.ShowDialog();
        }

        private void repetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repetir();
        }


        private void selecionarArquivo(string caminhoDoArquivo)
        {
            selectedFile = caminhoDoArquivo;
            LblEstado.Text = "A tocar: " + System.IO.Path.GetFileNameWithoutExtension(selectedFile);
        }

        private void repetir()
        {
            isRepeating = !isRepeating;
            repetirToolStripMenuItem.Checked = isRepeating;

            // Exemplo de caminho de arquivo
            string caminhoDoArquivo = Lstmusica.Text;
            selecionarArquivo(caminhoDoArquivo);

            if (isRepeating)
            {
                LblEstado.Text = "Repetição ativada. A tocar: " + System.IO.Path.GetFileNameWithoutExtension(selectedFile);
            }
            else
            {
                LblEstado.Text = "Repetição desativada. A tocar: " + System.IO.Path.GetFileNameWithoutExtension(selectedFile);
            }
        }

        private void btnRepetir_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            repetir();
            
        }
    }
}
