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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TrocarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login ObjLogin = new Login();
            ObjLogin.MdiParent = this;
            ObjLogin.Show();
        }

        private void ArquivoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userLogado.Text = Login.userLogado;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CalculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calc calculadora = new Calc();
            calculadora.MdiParent = this;
            calculadora.Show();
        }

        private void FEEDBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeixeSuaOpniãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback aaaaaa = new feedback();
            aaaaaa.MdiParent = this;
            aaaaaa.Show();
        }

        private void ListaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCombo hehe = new ListCombo();
            hehe.MdiParent = this;
            hehe.Show();
        }
    }
}
