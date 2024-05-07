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
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(maquinaDeLavar.Checked || heteroTop.Checked)
            {
                if(dimenor.Checked || dimaior.Checked)
                {
                    if(Hsim.Checked || Hnão.Checked)
                    {
                        MessageBox.Show("Obrigado pela sua opnião!","FeedBack",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void MaquinaDeLavar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
