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
    public partial class RPDU_form : Form
    {
        private RPDU rPDU;

        
        public RPDU_form(RPDU rPDU)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.rPDU = rPDU;
            label_rpduN.Text = rPDU.RPDU_Numb.ToString();
            label_freq.Text = rPDU.Get_Text_Freq();
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal static void ActiveForm()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button_RPDU_freq_Click(object sender, EventArgs e)
        {
            Freq_form Freq_form = new Freq_form();
            Freq_form.ShowDialog();
        }

        private void button_RPDU_class_Click(object sender, EventArgs e)
        {
            Class_form Class_form = new Class_form();
            Class_form.ShowDialog();
        }

        private void button_RPDU_ON_Click(object sender, EventArgs e)
        {
            if (button_RPDU_ON.Text == "RPDU OFF")
            {
                button_RPDU_ON.Text = "RPDU ON";
                rPDU.State_R = (int)State_RPDU.RPDU_ISPRAVEN; 
            }
            else
            {
                button_RPDU_ON.Text = "RPDU OFF";
                rPDU.State_R = (int)State_RPDU.RPDU_OFF;
            }
        }
    }
}
