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

        public Login()
        {
            this.lblUser = new Label();
            this.lblUser.Text = "Usuário";
            this.lblUser.Location = new Point(700, 350);
            this.lblUser.Size = new Size(50, 30);

            this.lblPass = new Label();
            this.lblPass.Text = "Senha";
            this.lblPass.Location = new Point(700, 400);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(800, 350);
            this.txtUser.Size = new Size(280, 30);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(800, 400);
            this.txtPass.Size = new Size(280, 30);
            this.txtPass.PasswordChar = '*';

            this.btnConfirm = new Button();
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.Location = new Point(940, 180);
            this.btnConfirm.Size = new Size(80, 30);
            
            //this.btnConfirm.Click += new EventHandler(this.handleConfirmClick);

            this.btnCancel = new Button();
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Location = new Point(840, 180);
            this.btnCancel.Size = new Size(80, 30);
            //this.btnCancel.Click += new EventHandler(this.handleCancelClick);
            //FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            pbImagem = new PictureBox();
			pbImagem.Size = new Size(100,100);
			pbImagem.Location = new Point(870,240);
			pbImagem.ClientSize = new Size(100,100);
			pbImagem.Load("image.png");
			pbImagem.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);

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
    }
}


