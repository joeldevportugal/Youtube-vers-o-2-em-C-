namespace Youtube_versão_2
{
    partial class FrYoutube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrYoutube));
            this.txturl = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.rdMp3 = new System.Windows.Forms.RadioButton();
            this.rdMp4 = new System.Windows.Forms.RadioButton();
            this.cmbqualidade = new System.Windows.Forms.ComboBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnDownload = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.picontroles = new System.Windows.Forms.PictureBox();
            this.LblFicheiro = new System.Windows.Forms.Label();
            this.Avanco = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picontroles)).BeginInit();
            this.SuspendLayout();
            // 
            // txturl
            // 
            this.txturl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturl.Location = new System.Drawing.Point(13, 13);
            this.txturl.Multiline = true;
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(1011, 37);
            this.txturl.TabIndex = 0;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrar.Location = new System.Drawing.Point(1031, 13);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(109, 37);
            this.BtnMostrar.TabIndex = 1;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = false;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // rdMp3
            // 
            this.rdMp3.AutoSize = true;
            this.rdMp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp3.Location = new System.Drawing.Point(16, 65);
            this.rdMp3.Name = "rdMp3";
            this.rdMp3.Size = new System.Drawing.Size(177, 33);
            this.rdMp3.TabIndex = 2;
            this.rdMp3.TabStop = true;
            this.rdMp3.Text = "Formato Mp3";
            this.rdMp3.UseVisualStyleBackColor = true;
            // 
            // rdMp4
            // 
            this.rdMp4.AutoSize = true;
            this.rdMp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMp4.Location = new System.Drawing.Point(261, 65);
            this.rdMp4.Name = "rdMp4";
            this.rdMp4.Size = new System.Drawing.Size(177, 33);
            this.rdMp4.TabIndex = 3;
            this.rdMp4.TabStop = true;
            this.rdMp4.Text = "Formato Mp4";
            this.rdMp4.UseVisualStyleBackColor = true;
            // 
            // cmbqualidade
            // 
            this.cmbqualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbqualidade.FormattingEnabled = true;
            this.cmbqualidade.Location = new System.Drawing.Point(476, 65);
            this.cmbqualidade.Name = "cmbqualidade";
            this.cmbqualidade.Size = new System.Drawing.Size(213, 37);
            this.cmbqualidade.TabIndex = 4;
            // 
            // txtCaminho
            // 
            this.txtCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.Location = new System.Drawing.Point(13, 114);
            this.txtCaminho.Multiline = true;
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Size = new System.Drawing.Size(1011, 37);
            this.txtCaminho.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(1031, 114);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(109, 37);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnDownload
            // 
            this.BtnDownload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDownload.Location = new System.Drawing.Point(12, 170);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(121, 41);
            this.BtnDownload.TabIndex = 7;
            this.BtnDownload.Text = "Download";
            this.BtnDownload.UseVisualStyleBackColor = false;
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(140, 170);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(120, 41);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(267, 170);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(142, 41);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // picontroles
            // 
            this.picontroles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picontroles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picontroles.Location = new System.Drawing.Point(12, 219);
            this.picontroles.Name = "picontroles";
            this.picontroles.Size = new System.Drawing.Size(1128, 100);
            this.picontroles.TabIndex = 10;
            this.picontroles.TabStop = false;
            // 
            // LblFicheiro
            // 
            this.LblFicheiro.AutoSize = true;
            this.LblFicheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFicheiro.Location = new System.Drawing.Point(38, 272);
            this.LblFicheiro.Name = "LblFicheiro";
            this.LblFicheiro.Size = new System.Drawing.Size(116, 32);
            this.LblFicheiro.TabIndex = 11;
            this.LblFicheiro.Text = "Ficheiro";
            // 
            // Avanco
            // 
            this.Avanco.Location = new System.Drawing.Point(37, 234);
            this.Avanco.Name = "Avanco";
            this.Avanco.Size = new System.Drawing.Size(1090, 31);
            this.Avanco.TabIndex = 12;
            // 
            // FrYoutube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1152, 330);
            this.Controls.Add(this.Avanco);
            this.Controls.Add(this.LblFicheiro);
            this.Controls.Add(this.picontroles);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.cmbqualidade);
            this.Controls.Add(this.rdMp4);
            this.Controls.Add(this.rdMp3);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.txturl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrYoutube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Downloader Versão 2 © DevJoel Portugal ";
            ((System.ComponentModel.ISupportInitialize)(this.picontroles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.RadioButton rdMp3;
        private System.Windows.Forms.RadioButton rdMp4;
        private System.Windows.Forms.ComboBox cmbqualidade;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnDownload;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.PictureBox picontroles;
        private System.Windows.Forms.Label LblFicheiro;
        private System.Windows.Forms.ProgressBar Avanco;
    }
}

