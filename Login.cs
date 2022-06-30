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
        TextBox txtUser;
        TextBox txtPass;
        Button btnConfirm;
        Button btnCancel;
        PictureBox pbImagem;
        Label lblCadastro;

        public Login()
        {

            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(700, 350);
            this.lblUser.Size = new Size(100, 30);
            this.lblUser.ForeColor = Color.Green;
            this.lblUser.Font = new Font("Calibri", 15);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(700, 400);
            this.lblPass.ForeColor = Color.Green;
            this.lblPass.Font = new Font("Calibri", 15);

            this.lblCadastro = new Label();
            this.lblCadastro.Text = "Realizar Cadastro";
            this.lblCadastro.Location = new Point(880, 500);
            this.lblCadastro.Size = new Size(300, 30);
            this.lblCadastro.ForeColor = Color.Green;
            //this.lblCadastro.Font = new Font("Calibri", 15);
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(800, 350);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(800, 400);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';


            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(845, 450);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(945, 450);
            this.btnCancel.Size = new Size(80, 30);
            //this.btnCancel.Click += new EventHandler(this.handleCancelClick);
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            pbImagem = new PictureBox();
            pbImagem.Size = new Size(150, 150);
            pbImagem.Location = new Point(860, 180);
            pbImagem.ClientSize = new Size(150, 150);
            pbImagem.Load("image.png");
            pbImagem.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblCadastro);

            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);

            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);

            this.Controls.Add(pbImagem);


            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "Login";
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        private void handleConfirmClick(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "user" && this.txtPass.Text == "123")
            {
                Cliente form = new Cliente();
                form.Show();
            }
            else
            {
                Funcionario form = new Funcionario();
                form.Show();

            }

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
        Label lblFone;
        Label lblEndereço;
        Label lblEmpresa;
        Label lblCidade;
        Label lblEstado;
        Label lblCep;
        Label lblSenhaUser;
        TextBox txtNome;
        TextBox txtMae;
        TextBox txtCpf;
        TextBox txtFone;
        TextBox txtEndereco;
        TextBox txtCep;

        Label lblNumeroCartao;
        Label lblCvv;
        Label lblValidade;
        Label lblSenha;



        public Cliente()
        {
            //LABEL
            this.lblTitulo = new Label();
            this.lblTitulo.Text = "Cadastro de Usuario";
            this.lblTitulo.Location = new Point(20, 20);
            this.lblTitulo.Size = new Size(200, 30);
            this.lblTitulo.ForeColor = Color.Green;
            this.lblTitulo.Font = new Font("Calibri", 15);

            //LABEL
            //PRIMEIRA FILEIRA

            this.lblPessoais = new Label();
            this.lblPessoais.Text = "Dados pessoais";
            this.lblPessoais.Location = new Point(550, 100);
            this.lblPessoais.Size = new Size(200, 30);
            this.lblPessoais.ForeColor = Color.Green;
            this.lblPessoais.Font = new Font("Calibri", 15);
            
            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(550, 150);
            this.lblNome.Size = new Size(60, 30);
            this.lblNome.ForeColor = Color.Black;
            this.lblNome.Font = new Font("Calibri", 15);
            

            this.lblMae = new Label();
            this.lblMae.Text = "Nome da mãe";
            this.lblMae.Location = new Point(870, 150);
            this.lblMae.Size = new Size(130, 30);
            this.lblMae.ForeColor = Color.Black;
            this.lblMae.Font = new Font("Calibri", 15);
            

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(1110, 150);
            this.lblCpf.Size = new Size(40, 25);
            this.lblCpf.ForeColor = Color.Black;
            this.lblCpf.Font = new Font("Calibri", 15);
            

            //SEGUNDA FILEIRA

            this.lblFone = new Label();
            this.lblFone.Text = "Fone";
            this.lblFone.Location = new Point(550, 220);
            this.lblFone.Size = new Size(60, 30);
            this.lblFone.ForeColor = Color.Black;
            this.lblFone.Font = new Font("Calibri", 15);

            this.lblEndereço = new Label();
            this.lblEndereço.Text = "End.";
            this.lblEndereço.Location = new Point(750, 220);
            this.lblEndereço.Size = new Size(60, 30);
            this.lblEndereço.ForeColor = Color.Black;
            this.lblEndereço.Font = new Font("Calibri", 15);

            this.lblCep = new Label();
            this.lblCep.Text = "CEP";
            this.lblCep.Location = new Point(1110, 220);
            this.lblCep.Size = new Size(40, 30);
            this.lblCep.ForeColor = Color.Black;
            this.lblCep.Font = new Font("Calibri", 15);

            this.lblSenhaUser = new Label();
            this.lblSenhaUser.Text = "Crie uma senha para acesso";
            this.lblSenhaUser.Location = new Point(550, 300);
            this.lblSenhaUser.Size = new Size(400, 30);
            this.lblSenhaUser.ForeColor = Color.Black;
            this.lblSenhaUser.Font = new Font("Calibri", 15);
            

            //INPUT

            //PRIMEIRA FILEIRA
            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(550, 180);
            this.txtNome.Size = new Size(280, 30);
            this.txtNome.Text = "Digite seu nome...";
            this.txtNome.ForeColor = Color.Black;

            this.txtMae = new TextBox();
            this.txtMae.Location = new Point(870, 180);
            this.txtMae.Size = new Size(200, 30);
            this.txtMae.Text = "Digite o nome da sua mãe";
            this.txtMae.ForeColor = Color.Black;

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(1110, 180);
            this.txtCpf.Size = new Size(100, 30);
            this.txtCpf.Text = "Digite seu CPF...";
            this.txtCpf.ForeColor = Color.Black;


            //SEGUNDA FILEIRA
            this.txtFone = new TextBox();
            this.txtFone.Location = new Point(550, 250);
            this.txtFone.Size = new Size(120, 30);
            this.txtFone.Text = "Digite seu telefone...";
            this.txtFone.ForeColor = Color.Black;

            this.txtEndereco = new TextBox();
            this.txtEndereco.Location = new Point(750, 250);
            this.txtEndereco.Size = new Size(280, 30);
            this.txtEndereco.Text = "Digite seu endereço...";
            this.txtEndereco.ForeColor = Color.Black;

            this.txtCep = new TextBox();
            this.txtCep.Location = new Point(1110, 250);
            this.txtCep.Size = new Size(100, 30);
            this.txtCep.Text = "Digite seu cep...";
            this.txtCep.ForeColor = Color.Black;

            this.lblCartao = new Label();
            this.lblCartao.Text = "Dados do cartão";
            this.lblCartao.Location = new Point(550, 420);
            this.lblCartao.Size = new Size(200, 30);
            this.lblCartao.ForeColor = Color.Green;
            this.lblCartao.Font = new Font("Calibri", 15);

            this.lblNumeroCartao = new Label();
            this.lblNumeroCartao.Text = "N° do Cartão";
            this.lblNumeroCartao.Location = new Point(550, 470);
            this.lblNumeroCartao.Size = new Size(120, 30);
            this.lblNumeroCartao.ForeColor = Color.Black;
            this.lblNumeroCartao.Font = new Font("Calibri", 15);

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMae);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblPessoais);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.lblNumeroCartao);
            this.Controls.Add(this.lblSenhaUser);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtFone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCep);


            this.WindowState = FormWindowState.Maximized;

        }

    }

    public class Funcionario : Form
    {

        public Funcionario()
        {

        }

    }

}