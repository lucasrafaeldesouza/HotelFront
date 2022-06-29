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
            this.btnConfirm.Location = new Point(945, 450);
            this.btnConfirm.Size = new Size(80, 30);
            this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(845, 450);
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

        /*
        private void handleConfirmClick(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "user" && this.txtPass.Text == "123")
        {
            Produtos form = new Produtos();
            this.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        else
        {
            //Tags form = new Tags();
            //form.Show();

        }
         */   

        }
    }

    public class Cliente : Form
        {

        Label lblTitulo;
        Label lblNome;
        Label lblEmail;
        Label lblCpf;
        Label lblFone;
        Label lblEndereço;
        Label lblEmpresa;
        Label lblCidade;
        Label lblEstado;
        Label lblCep;

        TextBox txtNome;
        TextBox txtEmail;
        TextBox txtCpf;
        TextBox txtFone;
        TextBox txtEndereco;
        TextBox txtCep;

        public Cliente()
        {
            this.lblTitulo = new Label();
            this.lblTitulo.Text = "Cadastro de Reserva";
            this.lblTitulo.Location = new Point(20, 20);
            this.lblTitulo.Size = new Size(200, 30);
            this.lblTitulo.ForeColor = Color.Green;
            this.lblTitulo.Font = new Font("Calibri", 15);

            this.lblNome = new Label();
            this.lblNome.Text = "Nome";
            this.lblNome.Location = new Point(20, 80);
            this.lblNome.Size = new Size(60, 30);
            this.lblNome.ForeColor = Color.Black;
            this.lblNome.Font = new Font("Calibri", 15);

            this.lblEmail = new Label();
            this.lblEmail.Text = "Email";
            this.lblEmail.Location = new Point(400, 80);
            this.lblEmail.Size = new Size(60, 30);
            this.lblEmail.ForeColor = Color.Black;
            this.lblEmail.Font = new Font("Calibri", 15);

            this.lblCpf = new Label();
            this.lblCpf.Text = "CPF";
            this.lblCpf.Location = new Point(770, 80);
            this.lblCpf.Size = new Size(40, 30);
            this.lblCpf.ForeColor = Color.Black;
            this.lblCpf.Font = new Font("Calibri", 15);

            this.lblFone = new Label();
            this.lblFone.Text = "Fone";
            this.lblFone.Location = new Point(20, 150);
            this.lblFone.Size = new Size(60, 30);
            this.lblFone.ForeColor = Color.Black;
            this.lblFone.Font = new Font("Calibri", 15);

            this.lblEndereço = new Label();
            this.lblEndereço.Text = "End.";
            this.lblEndereço.Location = new Point(400, 150);
            this.lblEndereço.Size = new Size(60, 30);
            this.lblEndereço.ForeColor = Color.Black;
            this.lblEndereço.Font = new Font("Calibri", 15);

            this.lblCep = new Label();
            this.lblCep.Text = "CEP";
            this.lblCep.Location = new Point(770, 150);
            this.lblCep.Size = new Size(40, 30);
            this.lblCep.ForeColor = Color.Black;
            this.lblCep.Font = new Font("Calibri", 15);

            this.txtNome = new TextBox();
            this.txtNome.Location = new Point(80, 80);
            this.txtNome.Size = new Size(280, 30);

            this.txtEmail = new TextBox();
            this.txtEmail.Location = new Point(460, 80);
            this.txtEmail.Size = new Size(200, 30);

            this.txtCpf = new TextBox();
            this.txtCpf.Location = new Point(815, 80);
            this.txtCpf.Size = new Size(100, 30);

            this.txtFone = new TextBox();
            this.txtFone.Location = new Point(80, 150);
            this.txtFone.Size = new Size(120, 30);

            this.txtEndereco = new TextBox();
            this.txtEndereco.Location = new Point(460, 150);
            this.txtEndereco.Size = new Size(280, 30);

            this.txtCep = new TextBox();
            this.txtCep.Location = new Point(815, 150);
            this.txtCep.Size = new Size(100, 30);

            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblFone);
            this.Controls.Add(this.lblEndereço);
            this.Controls.Add(this.lblCep);

            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
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

    
    /*Inicio da tela de Produtos
     public class Produtos : Form
        {

        ListView listView;
        Label lblProdutos;


        public Produtos()
        {

            this.lblProdutos = new Label();
            this.lblProdutos.Text = "Produtos";
            this.lblProdutos.Location = new Point(500, 50);
            this.lblProdutos.Size = new Size(180, 50);
            this.lblProdutos.ForeColor = Color.Green;
            this.lblProdutos.Font = new Font("Calibri", 26);

            listView = new ListView();
			listView.Location = new Point(500, 180);
			listView.Size = new Size(525,200);
			listView.View = View.Details;

			ListViewItem PrimeiroItem = new ListViewItem("X-Salada completo");
			PrimeiroItem.SubItems.Add("Sanduiche com bastando gordura");
            PrimeiroItem.SubItems.Add("2");
			PrimeiroItem.SubItems.Add("R$10,00");
			PrimeiroItem.SubItems.Add("R$20,00");

			ListViewItem SegundoItem = new ListViewItem("Coca-Cola");
			SegundoItem.SubItems.Add("Refrigerante que tem muito açucar");	
			SegundoItem.SubItems.Add("2");	
            SegundoItem.SubItems.Add("R$7,00");	
			SegundoItem.SubItems.Add("R$14,00");	

			listView.Items.AddRange(new ListViewItem[]{PrimeiroItem, SegundoItem});
			listView.Columns.Add("Produto", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Quantidade", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Val Unitario", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Valor Total", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;


            this.Controls.Add(listView);
            this.Controls.Add(this.lblProdutos);
            this.WindowState = FormWindowState.Maximized;

        }
        
    }
    Fim da tela de Produtos
    */ 
    