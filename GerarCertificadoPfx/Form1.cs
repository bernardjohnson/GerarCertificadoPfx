using GerarCertificadoPfx.Utils;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace GerarCertificadoPfx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Alerta;

        private void btn_key_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbl_key.Text = openFileDialog1.FileName;
            }
        }

        private void btn_crt_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbl_crt.Text = openFileDialog1.FileName;
            }
        }

        private void btn_gerarPfx_Click(object sender, EventArgs e)
        {

            if (!ValidarCampos()) 
            {
                MessageBox.Show(Alerta);
                return;
            }

            var key = File.ReadAllText(lbl_key.Text);
            var crt = File.ReadAllText(lbl_crt.Text);


            RSA rsa = RSA.Create();
            rsa.ImportPkcs8PrivateKey(key.ConvertPK(), out _);

            var certificate = new X509Certificate2(crt.ConvertCRT(), string.Empty,
                                                    X509KeyStorageFlags.MachineKeySet |
                                                    X509KeyStorageFlags.PersistKeySet |
                                                    X509KeyStorageFlags.Exportable);

            X509Certificate2 cert = certificate.CopyWithPrivateKey(rsa);
            var result = cert.Export(X509ContentType.Pfx);


            var arquivo = $"{txt_caminho.Text}\\{txt_nomeArquivo.Text}.pfx";

            File.WriteAllBytes(arquivo, result);

            MessageBox.Show($"Arquivo salvo no caminho: {txt_caminho.Text}");

        }

        private bool ValidarCampos()
        {
            bool resposta = true;
            if (string.IsNullOrEmpty(lbl_crt.Text))
            {
                Alerta += "Selecione o .crt; ";
                resposta = false;
            }

            if (string.IsNullOrEmpty(lbl_key.Text))
            {
                Alerta += "Selecione o .key; ";
                resposta = false;
            }

            if (string.IsNullOrEmpty(txt_caminho.Text))
            {
                Alerta += "Digte o caminho em que o arquivo .pfx será salvo; ";
                resposta = false;
            }

            if (string.IsNullOrEmpty(txt_nomeArquivo.Text))
            {
                Alerta += "Digte o nome do arquivo; ";
                resposta = false;
            }

            if (!Directory.Exists(txt_caminho.Text))
            {
                Alerta += "O caminho especificado não existe; ";
                resposta = false;
            }

            return resposta;
        }

    }
}
