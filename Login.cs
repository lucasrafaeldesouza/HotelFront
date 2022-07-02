using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace TelaLogin
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
    public class Login : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Label lblPass;
        MaskedTextBox txtUser;
        TextBox txtPass;
        Button btnConfirm;
        PictureBox pbImagem;
        Label lblCadastro;
        LinkLabel linkCadastro;
        Label lblCriarConta;
        Button btnCriarConta;
        public Login()
        {

            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(800, 350);
            this.lblUser.Size = new Size(100, 30);
            this.lblUser.ForeColor = Color.Black;
            this.lblUser.Font = new Font("Roboto", 13, FontStyle.Bold);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(800, 415);
            this.lblPass.ForeColor = Color.Black;
            this.lblPass.Font = new Font("Roboto", 13, FontStyle.Bold);

            this.lblCriarConta = new Label();
            this.lblCriarConta.Text = "Ainda não tem conta?";
            this.lblCriarConta.Location = new Point(800, 550);
            this.lblCriarConta.Size = new Size(190, 30);
            this.lblCriarConta.ForeColor = Color.DarkGreen;
            this.lblCriarConta.Font = new Font("Roboto", 10);

            this.txtUser = new MaskedTextBox();
            this.txtUser.Location = new Point(800, 380);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(800, 445);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Font = new Font("Roboto", 13);
            this.btnConfirm.Location = new Point(800, 500);
            this.btnConfirm.Size = new Size(280, 30);
            //this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.pbImagem = new PictureBox();
            this.pbImagem.Size = new Size(150, 150);
            this.pbImagem.Location = new Point(860, 180);
            this.pbImagem.ClientSize = new Size(150, 150);
            this.pbImagem.Load("image.png");
            this.pbImagem.SizeMode = PictureBoxSizeMode.Zoom;

            this.btnCriarConta = new Button();
            this.btnCriarConta.Text = "Cadastrar-se";
            this.btnCriarConta.Font = new Font("Roboto", 9);
            this.btnCriarConta.Location = new Point(990, 545);
            this.btnCriarConta.Size = new Size(90, 30);
            this.btnCriarConta.Click += new EventHandler(this.handleCadastro);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.lblCriarConta);

            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(pbImagem);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.btnCriarConta);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(213, 255, 222);
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void handleCadastro(object sender, EventArgs e)
        {
            Cliente form = new Cliente();
            form.Show();

        }
    }

    public class Cliente : Form
    {

        Label lblTitulo;
        Label lblPessoais;
        Label lblCartao;
        Label lblNome;
        Label lblMae;
        Label lblCpf;
        Label lblDataNascimento;
        Label lblEmpresa;
        Label lblCidade;
        Label lblEstado;
        Label lblSenhaUser;
        TextBox txtNome;
        TextBox txtMae;
        MaskedTextBox txtCpf;
        MaskedTextBox txtDataAniversario;
        PictureBox pbImagem;
        Label lblNumeroCartao;
        Label lblCvv;
        Label lblValidade;
        Label lblSenha;
        TextBox txtNumeroCartao;
        TextBox txtSenhaUser;
        Button btnSenhaUser;
        TextBox txtCvv;
        MaskedTextBox txtValidade;
        Label lblSenhaCartao;
        TextBox txtSenhaCartao;


        public Cliente()
        {
            //LABEL
            this.lblTitulo = new Label();
            this.lblTitulo.Text = "Cadastro de Usuario";
            this.lblTitulo.Location = new Point(20, 20);
            this.lblTitulo.Size = new Size(200, 30);
            this.lblTitulo.ForeColor = Color.Green;
            this.lblTitulo.Font = new Font("Roboto", 14);

            //LABEL
            //PRIMEIRA FILEIRA
            this.lblPessoais = new Label();
            this.lblPessoais.Text = "Dados pessoais";
            this.lblPessoais.Location = new Point(550, 100);
            this.lblPessoais.Size = new Size(200, 30);
            this.lblPessoais.ForeColor = Color.Green;
            this.lblPessoais.Font = new Font("Roboto", 14);

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(600, 150);
            this.lblNome.Size = new Size(60, 30);
            this.lblNome.ForeColor = Color.Black;
            this.lblNome.Font = new Font("Roboto", 14);

            this.lblMae = new Label();
            this.lblMae.Text = "Nome da mãe";
            this.lblMae.Location = new Point(920, 150);
            this.lblMae.Size = new Size(130, 30);
            this.lblMae.ForeColor = Color.Black;
            this.lblMae.Font = new Font("Roboto", 14);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(1160, 150);
            this.lblCpf.Size = new Size(50, 25);
            this.lblCpf.ForeColor = Color.Black;
            this.lblCpf.Font = new Font("Roboto", 14);


            //SEGUNDA FILEIRA
            this.lblDataNascimento = new Label();
            this.lblDataNascimento.Text = "Data de nascimento";
            this.lblDataNascimento.Location = new Point(600, 220);
            this.lblDataNascimento.Size = new Size(250, 30);
            this.lblDataNascimento.ForeColor = Color.Black;
            this.lblDataNascimento.Font = new Font("Roboto", 15);

            this.lblSenhaUser = new Label();
            this.lblSenhaUser.Text = "Crie uma senha";
            this.lblSenhaUser.Location = new Point(920, 220);
            this.lblSenhaUser.Size = new Size(400, 30);
            this.lblSenhaUser.ForeColor = Color.Black;
            this.lblSenhaUser.Font = new Font("Roboto", 15);

            pbImagem = new PictureBox();
            pbImagem.Size = new Size(150, 150);
            pbImagem.Location = new Point(560, 260);
            pbImagem.ClientSize = new Size(750, 150);
            pbImagem.Load("barra.png");
            pbImagem.SizeMode = PictureBoxSizeMode.Zoom;

            //INPUT
            //PRIMEIRA FILEIRA
            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(600, 180);
            this.txtNome.Size = new Size(280, 30);
            this.txtNome.Text = "Digite seu nome...";
            this.txtNome.ForeColor = Color.Black;

            this.txtMae = new TextBox();
            this.txtMae.Location = new Point(920, 180);
            this.txtMae.Size = new Size(200, 30);
            this.txtMae.Text = "Digite o nome da sua mãe";
            this.txtMae.ForeColor = Color.Black;

            this.txtCpf = new MaskedTextBox();
            this.txtCpf.Location = new Point(1160, 180);
            this.txtCpf.Size = new Size(100, 30);
            this.txtCpf.Text = "Digite seu CPF...";
            this.txtCpf.ForeColor = Color.Black;
            this.txtCpf.Mask = "000,000,000-00";

            //SEGUNDA FILEIRA
            this.txtDataAniversario = new MaskedTextBox();
            this.txtDataAniversario.Location = new Point(600, 250);
            this.txtDataAniversario.Size = new Size(70, 30);
            this.txtDataAniversario.Text = "Digite seu telefone...";
            this.txtDataAniversario.ForeColor = Color.Black;
            this.txtDataAniversario.Mask = "00/00/0000";

            this.txtSenhaUser = new TextBox();
            this.txtSenhaUser.Location = new Point(920, 250);
            this.txtSenhaUser.Size = new Size(100, 30);
            this.txtSenhaUser.ForeColor = Color.Black;
            this.txtSenhaUser.PasswordChar = '*';

            this.lblCartao = new Label();
            this.lblCartao.Text = "Dados do cartão";
            this.lblCartao.Location = new Point(550, 390);
            this.lblCartao.Size = new Size(200, 30);
            this.lblCartao.ForeColor = Color.Green;
            this.lblCartao.Font = new Font("Roboto", 15);

            this.lblNumeroCartao = new Label();
            this.lblNumeroCartao.Text = "N° do Cartão";
            this.lblNumeroCartao.Location = new Point(600, 440);
            this.lblNumeroCartao.Size = new Size(300, 30);
            this.lblNumeroCartao.ForeColor = Color.Black;
            this.lblNumeroCartao.Font = new Font("Roboto", 15);

            this.lblCvv = new Label();
            this.lblCvv.Text = "CVV";
            this.lblCvv.Location = new Point(920, 440);
            this.lblCvv.Size = new Size(100, 30);
            this.lblCvv.ForeColor = Color.Black;
            this.lblCvv.Font = new Font("Roboto", 15);

            this.lblValidade = new Label();
            this.lblValidade.Text = "Validade";
            this.lblValidade.Location = new Point(1160, 440);
            this.lblValidade.Size = new Size(300, 30);
            this.lblValidade.ForeColor = Color.Black;
            this.lblValidade.Font = new Font("Roboto", 15);

            this.lblSenhaCartao = new Label();
            this.lblSenhaCartao.Text = "Digite a senha do cartão";
            this.lblSenhaCartao.Location = new Point(600, 520);
            this.lblSenhaCartao.Size = new Size(300, 30);
            this.lblSenhaCartao.ForeColor = Color.Black;
            this.lblSenhaCartao.Font = new Font("Roboto", 15);

            this.btnSenhaUser = new Button();
            this.btnSenhaUser.Location = new Point(1110, 800);
            this.btnSenhaUser.Size = new Size(120, 30);
            this.btnSenhaUser.Text = "Confirmar";
            this.btnSenhaUser.ForeColor = Color.Black;

            this.txtNumeroCartao = new TextBox();
            this.txtNumeroCartao.Location = new Point(600, 480);
            this.txtNumeroCartao.Size = new Size(180, 30);
            this.txtNumeroCartao.ForeColor = Color.Black;

            this.txtCvv = new TextBox();
            this.txtCvv.Location = new Point(920, 480);
            this.txtCvv.Size = new Size(50, 30);
            this.txtCvv.ForeColor = Color.Black;

            this.txtValidade = new MaskedTextBox();
            this.txtValidade.Location = new Point(1160, 480);
            this.txtValidade.Size = new Size(50, 30);
            this.txtValidade.ForeColor = Color.Black;
            this.txtValidade.Mask = "00/00";

            this.txtSenhaCartao = new TextBox();
            this.txtSenhaCartao.Location = new Point(600, 560);
            this.txtSenhaCartao.Size = new Size(180, 30);
            this.txtSenhaCartao.ForeColor = Color.Black;

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMae);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblPessoais);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.lblNumeroCartao);
            this.Controls.Add(this.lblSenhaUser);
            this.Controls.Add(this.lblCvv);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblSenhaCartao);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtDataAniversario);
            this.Controls.Add(this.txtNumeroCartao);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtCvv);
            this.Controls.Add(this.txtValidade);
            this.Controls.Add(this.txtSenhaCartao);
            this.Controls.Add(this.btnSenhaUser);
            this.Controls.Add(pbImagem);

            this.WindowState = FormWindowState.Maximized;
        }
        private void handleConfirmCadastro(object sender, EventArgs e)
        {
            if (txtSenhaUser.Text.Length < 8)
            {
                MessageBox.Show("A senha precisa ter no minimo 8 caracteres.");
                return;
            }
            else
            {
                MessageBox.Show("Dados cadastrados com sucesso");
                return;

            }

        }
    }
}