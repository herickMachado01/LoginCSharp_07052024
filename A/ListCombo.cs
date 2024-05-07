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
    public partial class ListCombo : Form
    {
        public string Texto;
        public ListCombo()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string Texto = nome.Text;
            produtos.Items.Add(Texto);
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir?","ALERTA",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Excluidos.Items.Add(produtos.SelectedItem);
                produtos.Items.Remove(produtos.SelectedItem);
            }
        }

        private void Excluidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
