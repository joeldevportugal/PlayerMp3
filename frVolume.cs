using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class frVolume : Form
    {
        private Player mainForm;

        public frVolume(Player form)
        {
            InitializeComponent();
            mainForm = form;
            // Define o valor do trVolume para 100 e define o volume para 100 ao carregar o formulário
            trVolume.Value = 100;
            lblVolume.Text = "Volume: 100"; // Atualiza o lblVolume com o valor inicial
            if (mainForm.outputDevice != null)
            {
                mainForm.outputDevice.Volume = 1.0f;
            }
        }

        // Método para iniciar a reprodução da música
        public void PlayMusic()
        {
            if (mainForm.outputDevice != null)
            {
                // Define o volume para 100 e o valor do trVolume para 100 ao iniciar a música
                mainForm.outputDevice.Volume = 1.0f;
                trVolume.Value = 100;
                lblVolume.Text = "Volume: 100"; // Atualiza o lblVolume com o valor atual do volume
                mainForm.outputDevice.Play();
            }
        }

        private void trVolume_Scroll(object sender, EventArgs e)
        {
            if (mainForm.outputDevice != null)
            {
                // Verifica se o controle está silenciado e define o volume para 0
                if (trVolume.Value == 0)
                {
                    mainForm.outputDevice.Volume = 0.0f; // Silencia a música
                }
                else
                {
                    mainForm.outputDevice.Volume = trVolume.Value / 100.0f; // Ajusta o volume conforme o valor do TrackBar
                }
                lblVolume.Text = "Volume: " + trVolume.Value.ToString(); // Atualiza o lblVolume com o valor atual do volume
                this.ActiveControl = null;
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            // Não altera o valor do trVolume ao clicar no botão
            // Não faz nada ao clicar no botão
        }
    }
}
