using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        List<Usuario> listaUsuarios = new List<Usuario>();
        private void Login_Load(object sender, EventArgs e)
        {
            Usuario user1 = new Usuario();
            user1.user = "FaLLen";
            user1.senha = "senha";

            Usuario user2 = new Usuario();
            user2.user = "Simpl3";
            user2.senha = "simples";

            Usuario user3 = new Usuario();
            user3.user = "Coldzera";
            user3.senha = "12345";

            listaUsuarios.Add (user1);
            listaUsuarios.Add (user2);
            listaUsuarios.Add (user3);
        }

        public static string userLogado;
        private void Entrar_Click(object sender, EventArgs e)
        {
            string user = User.Text;
            string senha = Senha.Text;

            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.user == user)
                {
                    if (usuario.senha == senha)
                    {
                        if(robo.Checked)
                        {
                            userLogado = usuario.user;
                            MessageBox.Show("Bem vindo " + userLogado, "Seja bem-vindo " + userLogado);
                            this.DialogResult = DialogResult.OK;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Captcha não foi marcado!", "Captcha invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        erro.Visible = true;
                    }
                }

            }

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
