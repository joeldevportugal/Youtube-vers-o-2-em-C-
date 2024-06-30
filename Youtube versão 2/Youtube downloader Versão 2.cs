using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using YoutubeExplode.Videos.Streams;

namespace Youtube_versão_2
{
    public partial class FrYoutube : Form
    {
        private readonly YoutubeClient youtubeClient;

        public FrYoutube()
        {
            InitializeComponent();
            youtubeClient = new YoutubeClient();
            cmbqualidade.Text = "Qualidade";
        }

        private async void BtnMostrar_Click(object sender, EventArgs e)
        {
            string url = txturl.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, insira uma URL.");
                return;
            }

            try
            {
                cmbqualidade.Items.Clear();
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                if (rdMp3.Checked)
                {
                    var audioStreams = streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate);
                    foreach (var streamInfo in audioStreams)
                    {
                        cmbqualidade.Items.Add($"{streamInfo.Bitrate.KiloBitsPerSecond:F2} Kbps");
                    }
                }
                else if (rdMp4.Checked)
                {
                    var videoStreams = streamManifest.GetMuxedStreams().OrderByDescending(s => s.VideoQuality);
                    foreach (var streamInfo in videoStreams)
                    {
                        cmbqualidade.Items.Add($"{streamInfo.VideoQuality.Label} - {streamInfo.Container.Name}");
                    }
                }

                if (cmbqualidade.Items.Count > 0)
                {
                    cmbqualidade.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nenhuma qualidade disponível encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private async void rdMp3_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdMp3.Checked) return;

            string url = txturl.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, insira uma URL.");
                return;
            }

            try
            {
                cmbqualidade.Items.Clear();
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                var audioStreams = streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate);
                foreach (var streamInfo in audioStreams)
                {
                    cmbqualidade.Items.Add($"{streamInfo.Bitrate.KiloBitsPerSecond:F2} Kbps");
                }

                if (cmbqualidade.Items.Count > 0)
                {
                    cmbqualidade.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nenhuma qualidade disponível encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private async void rdMp4_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdMp4.Checked) return;

            string url = txturl.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Por favor, insira uma URL.");
                return;
            }

            try
            {
                cmbqualidade.Items.Clear();
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                var videoStreams = streamManifest.GetMuxedStreams().OrderByDescending(s => s.VideoQuality);
                foreach (var streamInfo in videoStreams)
                {
                    cmbqualidade.Items.Add($"{streamInfo.VideoQuality.Label} - {streamInfo.Container.Name}");
                }

                if (cmbqualidade.Items.Count > 0)
                {
                    cmbqualidade.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Nenhuma qualidade disponível encontrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter informações do vídeo: {ex.Message}");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (rdMp3.Checked)
                {
                    saveFileDialog.Filter = "MP3 files (*.mp3)|*.mp3";
                }
                else if (rdMp4.Checked)
                {
                    saveFileDialog.Filter = "MP4 files (*.mp4)|*.mp4";
                }

                saveFileDialog.Title = "Escolha o local para salvar o arquivo";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtCaminho.Text = saveFileDialog.FileName;
                    MessageBox.Show($"Arquivo será salvo em: {saveFileDialog.FileName}");
                    // Aqui você pode adicionar o código para baixar e salvar o arquivo usando youtubeClient
                }
            }

        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            string url = txturl.Text;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(txtCaminho.Text))
            {
                MessageBox.Show("Por favor, insira uma URL e escolha o local para salvar o arquivo.");
                return;
            }

            try
            {
                LblFicheiro.Text = "Download em início...";
                Avanco.Value = 0;

                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                IStreamInfo streamInfo;

                if (rdMp3.Checked)
                {
                    streamInfo = streamManifest.GetAudioOnlyStreams().OrderByDescending(s => s.Bitrate).First();
                }
                else
                {
                    streamInfo = streamManifest.GetMuxedStreams().OrderByDescending(s => s.VideoQuality).First();
                }

                await DownloadVideoAsync(streamInfo, txtCaminho.Text);

                LblFicheiro.Text = "Download concluído!";
                Avanco.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fazer o download do vídeo: {ex.Message}");
            }
        }

        private async Task DownloadVideoAsync(IStreamInfo streamInfo, string filePath)
        {
            var progressHandler = new Progress<double>(progress =>
            {
                Avanco.Value = (int)(progress * 100);
            });

            await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, filePath, progressHandler);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txturl.Clear();
            txtCaminho.Clear();
            cmbqualidade.Items.Clear();
            rdMp3.Checked = false;
            rdMp4.Checked = false;
            Avanco.Value = 0;
            LblFicheiro.Text = "Ficheiro";
            cmbqualidade.Text = "Qualidade";
            MessageBox.Show("Dados Limpos Com sucesso!","Dados",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            sair();
        }
        private void sair()
        {
            if (MessageBox.Show("Deseja Sair do Programa?Sim/Não","Sair",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)return;
            Application.Exit();
        }
    }
}



