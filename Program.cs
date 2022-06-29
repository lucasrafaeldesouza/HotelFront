using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace ExemploTela
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
            this.lblCadastro.Click += new EventHandler(this.handleConfirmClickCadastro);


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

            //this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);
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
        private void handleConfirmClickCadastro(object sender, EventArgs e)
        {

        }
    }
}


