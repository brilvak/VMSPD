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

 
    public partial class BPS_form : Form
    {
        

        public BPS_form()
        {
            InitializeComponent();
        }

        private void button_BPS_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #region Buttons
        /// <summary>
        /// First channel power is on/off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///<remarks>
        ///</remarks>
        ///<permission cref="kkk"></permission>
        private void button_BPS_ON1_Click(object sender, EventArgs e)
        {
            


        }
        #endregion
    }
}
