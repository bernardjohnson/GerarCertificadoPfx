
namespace GerarCertificadoPfx
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_key = new System.Windows.Forms.Button();
            this.btn_crt = new System.Windows.Forms.Button();
            this.lbl_key = new System.Windows.Forms.Label();
            this.lbl_crt = new System.Windows.Forms.Label();
            this.btn_gerarPfx = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nomeArquivo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_caminho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o arquivo .key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecione o arquivo .crt";
            // 
            // btn_key
            // 
            this.btn_key.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_key.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_key.Location = new System.Drawing.Point(389, 68);
            this.btn_key.Name = "btn_key";
            this.btn_key.Size = new System.Drawing.Size(195, 26);
            this.btn_key.TabIndex = 2;
            this.btn_key.Text = "Selecionar";
            this.btn_key.UseVisualStyleBackColor = false;
            this.btn_key.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // btn_crt
            // 
            this.btn_crt.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_crt.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btn_crt.Location = new System.Drawing.Point(389, 140);
            this.btn_crt.Name = "btn_crt";
            this.btn_crt.Size = new System.Drawing.Size(195, 26);
            this.btn_crt.TabIndex = 3;
            this.btn_crt.Text = "Selecionar";
            this.btn_crt.UseVisualStyleBackColor = false;
            this.btn_crt.Click += new System.EventHandler(this.btn_crt_Click);
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_key.Location = new System.Drawing.Point(389, 97);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(0, 16);
            this.lbl_key.TabIndex = 4;
            // 
            // lbl_crt
            // 
            this.lbl_crt.AutoSize = true;
            this.lbl_crt.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_crt.Location = new System.Drawing.Point(392, 169);
            this.lbl_crt.Name = "lbl_crt";
            this.lbl_crt.Size = new System.Drawing.Size(0, 16);
            this.lbl_crt.TabIndex = 5;
            // 
            // btn_gerarPfx
            // 
            this.btn_gerarPfx.Location = new System.Drawing.Point(305, 343);
            this.btn_gerarPfx.Name = "btn_gerarPfx";
            this.btn_gerarPfx.Size = new System.Drawing.Size(159, 25);
            this.btn_gerarPfx.TabIndex = 6;
            this.btn_gerarPfx.Text = "Gerar .pfx";
            this.btn_gerarPfx.UseVisualStyleBackColor = true;
            this.btn_gerarPfx.Click += new System.EventHandler(this.btn_gerarPfx_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome do Arquivo .pfx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Digite o caminho p/ salvar o .pfx";
            // 
            // txt_nomeArquivo
            // 
            this.txt_nomeArquivo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nomeArquivo.Location = new System.Drawing.Point(389, 207);
            this.txt_nomeArquivo.Name = "txt_nomeArquivo";
            this.txt_nomeArquivo.Size = new System.Drawing.Size(195, 26);
            this.txt_nomeArquivo.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_caminho
            // 
            this.txt_caminho.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_caminho.Location = new System.Drawing.Point(426, 273);
            this.txt_caminho.Name = "txt_caminho";
            this.txt_caminho.Size = new System.Drawing.Size(295, 26);
            this.txt_caminho.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_caminho);
            this.Controls.Add(this.txt_nomeArquivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_gerarPfx);
            this.Controls.Add(this.lbl_crt);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.btn_crt);
            this.Controls.Add(this.btn_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Gerar certificado .pfx";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_key;
        private System.Windows.Forms.Button btn_crt;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.Label lbl_crt;
        private System.Windows.Forms.Button btn_gerarPfx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nomeArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_caminho;
    }
}

