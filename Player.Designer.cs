namespace Player
{
    partial class Player
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anterioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguinteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picimagem = new System.Windows.Forms.PictureBox();
            this.Lstmusica = new System.Windows.Forms.ListBox();
            this.trtempo = new System.Windows.Forms.TrackBar();
            this.Lbltempo_Decorrido = new System.Windows.Forms.Label();
            this.LblMusica = new System.Windows.Forms.Label();
            this.BtnAnterior = new System.Windows.Forms.Button();
            this.BtnRecuar = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnAvançar = new System.Windows.Forms.Button();
            this.BtnProximo = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.BtnVolume = new System.Windows.Forms.Button();
            this.LblEstado = new System.Windows.Forms.Label();
            this.btnRepetir = new System.Windows.Forms.Button();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trtempo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.controlesToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.openToolStripMenuItem.Text = "Open ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // controlesToolStripMenuItem
            // 
            this.controlesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.anterioToolStripMenuItem,
            this.seguinteToolStripMenuItem});
            this.controlesToolStripMenuItem.Name = "controlesToolStripMenuItem";
            this.controlesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.controlesToolStripMenuItem.Text = "Controles";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.playToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // anterioToolStripMenuItem
            // 
            this.anterioToolStripMenuItem.Name = "anterioToolStripMenuItem";
            this.anterioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.anterioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.anterioToolStripMenuItem.Text = "Anterio";
            this.anterioToolStripMenuItem.Click += new System.EventHandler(this.anterioToolStripMenuItem_Click);
            // 
            // seguinteToolStripMenuItem
            // 
            this.seguinteToolStripMenuItem.Name = "seguinteToolStripMenuItem";
            this.seguinteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.seguinteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.seguinteToolStripMenuItem.Text = "Seguinte ";
            this.seguinteToolStripMenuItem.Click += new System.EventHandler(this.seguinteToolStripMenuItem_Click);
            // 
            // picimagem
            // 
            this.picimagem.Image = ((System.Drawing.Image)(resources.GetObject("picimagem.Image")));
            this.picimagem.Location = new System.Drawing.Point(12, 31);
            this.picimagem.Name = "picimagem";
            this.picimagem.Size = new System.Drawing.Size(581, 453);
            this.picimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picimagem.TabIndex = 1;
            this.picimagem.TabStop = false;
            // 
            // Lstmusica
            // 
            this.Lstmusica.FormattingEnabled = true;
            this.Lstmusica.ItemHeight = 16;
            this.Lstmusica.Location = new System.Drawing.Point(600, 32);
            this.Lstmusica.Name = "Lstmusica";
            this.Lstmusica.ScrollAlwaysVisible = true;
            this.Lstmusica.Size = new System.Drawing.Size(257, 452);
            this.Lstmusica.TabIndex = 2;
            // 
            // trtempo
            // 
            this.trtempo.Location = new System.Drawing.Point(13, 526);
            this.trtempo.Name = "trtempo";
            this.trtempo.Size = new System.Drawing.Size(844, 56);
            this.trtempo.TabIndex = 3;
            this.trtempo.Scroll += new System.EventHandler(this.trtempo_Scroll);
            // 
            // Lbltempo_Decorrido
            // 
            this.Lbltempo_Decorrido.AutoSize = true;
            this.Lbltempo_Decorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltempo_Decorrido.Location = new System.Drawing.Point(24, 491);
            this.Lbltempo_Decorrido.Name = "Lbltempo_Decorrido";
            this.Lbltempo_Decorrido.Size = new System.Drawing.Size(76, 29);
            this.Lbltempo_Decorrido.TabIndex = 4;
            this.Lbltempo_Decorrido.Text = "00:00";
            // 
            // LblMusica
            // 
            this.LblMusica.AutoSize = true;
            this.LblMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMusica.Location = new System.Drawing.Point(786, 491);
            this.LblMusica.Name = "LblMusica";
            this.LblMusica.Size = new System.Drawing.Size(71, 29);
            this.LblMusica.TabIndex = 5;
            this.LblMusica.Text = "00:00";
            // 
            // BtnAnterior
            // 
            this.BtnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAnterior.FlatAppearance.BorderSize = 0;
            this.BtnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnterior.Image")));
            this.BtnAnterior.Location = new System.Drawing.Point(13, 588);
            this.BtnAnterior.Name = "BtnAnterior";
            this.BtnAnterior.Size = new System.Drawing.Size(87, 44);
            this.BtnAnterior.TabIndex = 6;
            this.BtnAnterior.UseVisualStyleBackColor = true;
            this.BtnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // BtnRecuar
            // 
            this.BtnRecuar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnRecuar.FlatAppearance.BorderSize = 0;
            this.BtnRecuar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnRecuar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRecuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecuar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRecuar.Image")));
            this.BtnRecuar.Location = new System.Drawing.Point(106, 588);
            this.BtnRecuar.Name = "BtnRecuar";
            this.BtnRecuar.Size = new System.Drawing.Size(87, 44);
            this.BtnRecuar.TabIndex = 7;
            this.BtnRecuar.UseVisualStyleBackColor = true;
            this.BtnRecuar.Click += new System.EventHandler(this.BtnRecuar_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.Image = ((System.Drawing.Image)(resources.GetObject("BtnPlay.Image")));
            this.BtnPlay.Location = new System.Drawing.Point(199, 588);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(87, 44);
            this.BtnPlay.TabIndex = 8;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnAvançar
            // 
            this.BtnAvançar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAvançar.FlatAppearance.BorderSize = 0;
            this.BtnAvançar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAvançar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAvançar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvançar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAvançar.Image")));
            this.BtnAvançar.Location = new System.Drawing.Point(292, 588);
            this.BtnAvançar.Name = "BtnAvançar";
            this.BtnAvançar.Size = new System.Drawing.Size(87, 44);
            this.BtnAvançar.TabIndex = 9;
            this.BtnAvançar.UseVisualStyleBackColor = true;
            this.BtnAvançar.Click += new System.EventHandler(this.BtnAvançar_Click);
            // 
            // BtnProximo
            // 
            this.BtnProximo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnProximo.FlatAppearance.BorderSize = 0;
            this.BtnProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProximo.Image = ((System.Drawing.Image)(resources.GetObject("BtnProximo.Image")));
            this.BtnProximo.Location = new System.Drawing.Point(385, 588);
            this.BtnProximo.Name = "BtnProximo";
            this.BtnProximo.Size = new System.Drawing.Size(87, 44);
            this.BtnProximo.TabIndex = 10;
            this.BtnProximo.UseVisualStyleBackColor = true;
            this.BtnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
            this.BtnStop.Location = new System.Drawing.Point(478, 588);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(87, 44);
            this.BtnStop.TabIndex = 11;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnpause
            // 
            this.btnpause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnpause.FlatAppearance.BorderSize = 0;
            this.btnpause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnpause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnpause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpause.Image = ((System.Drawing.Image)(resources.GetObject("btnpause.Image")));
            this.btnpause.Location = new System.Drawing.Point(571, 588);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(87, 44);
            this.btnpause.TabIndex = 12;
            this.btnpause.UseVisualStyleBackColor = true;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // BtnVolume
            // 
            this.BtnVolume.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVolume.FlatAppearance.BorderSize = 0;
            this.BtnVolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnVolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolume.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolume.Image")));
            this.BtnVolume.Location = new System.Drawing.Point(748, 588);
            this.BtnVolume.Name = "BtnVolume";
            this.BtnVolume.Size = new System.Drawing.Size(87, 44);
            this.BtnVolume.TabIndex = 13;
            this.BtnVolume.UseVisualStyleBackColor = true;
            this.BtnVolume.Click += new System.EventHandler(this.BtnVolume_Click);
            // 
            // LblEstado
            // 
            this.LblEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(13, 639);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(844, 38);
            this.LblEstado.TabIndex = 14;
            this.LblEstado.Text = "Estado!...";
            this.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRepetir
            // 
            this.btnRepetir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRepetir.FlatAppearance.BorderSize = 0;
            this.btnRepetir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRepetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRepetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepetir.Image = ((System.Drawing.Image)(resources.GetObject("btnRepetir.Image")));
            this.btnRepetir.Location = new System.Drawing.Point(645, 588);
            this.btnRepetir.Name = "btnRepetir";
            this.btnRepetir.Size = new System.Drawing.Size(90, 44);
            this.btnRepetir.TabIndex = 15;
            this.btnRepetir.UseVisualStyleBackColor = true;
            this.btnRepetir.Click += new System.EventHandler(this.btnRepetir_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repetirToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // repetirToolStripMenuItem
            // 
            this.repetirToolStripMenuItem.Name = "repetirToolStripMenuItem";
            this.repetirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.repetirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.repetirToolStripMenuItem.Text = "Repetir";
            this.repetirToolStripMenuItem.Click += new System.EventHandler(this.repetirToolStripMenuItem_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(869, 682);
            this.Controls.Add(this.btnRepetir);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.BtnVolume);
            this.Controls.Add(this.btnpause);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnProximo);
            this.Controls.Add(this.BtnAvançar);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnRecuar);
            this.Controls.Add(this.BtnAnterior);
            this.Controls.Add(this.LblMusica);
            this.Controls.Add(this.Lbltempo_Decorrido);
            this.Controls.Add(this.trtempo);
            this.Controls.Add(this.Lstmusica);
            this.Controls.Add(this.picimagem);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Player";
            this.Text = "Player Dev Joel 2025© Portugal ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trtempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anterioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguinteToolStripMenuItem;
        private System.Windows.Forms.PictureBox picimagem;
        private System.Windows.Forms.ListBox Lstmusica;
        private System.Windows.Forms.TrackBar trtempo;
        private System.Windows.Forms.Label Lbltempo_Decorrido;
        private System.Windows.Forms.Label LblMusica;
        private System.Windows.Forms.Button BtnAnterior;
        private System.Windows.Forms.Button BtnRecuar;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnAvançar;
        private System.Windows.Forms.Button BtnProximo;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button BtnVolume;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Button btnRepetir;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repetirToolStripMenuItem;
    }
}

