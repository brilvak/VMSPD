using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VMSPD_server
{
    public partial class BSK_form : Form
    {
        public BSK_form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_BSK_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
