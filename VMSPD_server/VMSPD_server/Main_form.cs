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
     
    public partial class Main_form : Form
    {

        public RPDU[] RPDU_list = new RPDU[4]
        {
            new RPDU(1, (int)State_RPDU.RPDU_ISPRAVEN, (int)Class_RPDU.F1B_6000_2400, 1000023, (int)Power_RPDU.P_10),
            new RPDU(2, (int)State_RPDU.RPDU_ISPRAVEN, (int)Class_RPDU.F1B_6000_2400, 1000023, (int)Power_RPDU.P_10),
            new RPDU(3, (int)State_RPDU.RPDU_ISPRAVEN, (int)Class_RPDU.F1B_6000_2400, 1000023, (int)Power_RPDU.P_10),
            new RPDU(4, (int)State_RPDU.RPDU_ISPRAVEN, (int)Class_RPDU.F1B_6000_2400, 1000023, (int)Power_RPDU.P_10)
        };
       
        public Main_form()
        {
            
            InitializeComponent();

            label_time.Text = DateTime.Now.ToString();


            //Инициализация РПДУ
            for (int i = 0; i < 4; i++)
            {
                FM_RPDU_State(RPDU_list[i], 0);
                FM_RPDU_Freq(RPDU_list[i], 0);
                FM_RPDU_Power(RPDU_list[i], 0);
                FM_RPDU_Izl_Class(RPDU_list[i], 0);
            }
            

            
        }

        #region Методы для работы с элементами формы
        #region РПДУ

        /// <summary>
        /// Установка частоты для РПДУ и вывод на  элементы <c>Main_form</c>
        /// </summary>
        /// <param name="rpdu"> РПДУ</param>
        /// <param name="freq"> устанавливаемая частота : 150000 - 1,5 MHz 2900099 - 29,99 MHz</param>
        private void FM_RPDU_Freq(RPDU rpdu, int freq)
        {
            if ((freq < 150000 || freq >= 3000000) && freq != 0)
                throw new ArgumentException();
            else 
                rpdu.Freq_R = freq;
            
            if (rpdu == RPDU_list[0])
                label_RPDU1_freq.Text = RPDU_list[0].Get_Text_Freq();
            else if (rpdu == RPDU_list[1])
                label_RPDU2_freq.Text = RPDU_list[1].Get_Text_Freq();
            else if (rpdu ==RPDU_list[2])
                label_RPDU3_freq.Text = RPDU_list[2].Get_Text_Freq();
            else if (rpdu == RPDU_list[3])
                label_RPDU4_freq.Text = RPDU_list[3].Get_Text_Freq();
            else
                throw new ArgumentException();

            

        }

        /// <summary>
        /// Установка класса излучения для РПДУ и вывод на <c>Main_form</c>
        /// </summary>
        /// <param name="rpdu"> РПДУ</param>
        /// <param name="cl">Устанавливаемый класс -<c>(int)Class_RPDU.класс</c></param>
        private void FM_RPDU_Izl_Class(RPDU rpdu, int cl)
        {
            try
            {
                rpdu.Class_R = cl;
            }
            catch (ArgumentException ex)
            {
            }

            if (rpdu == RPDU_list[0])
                label_RPDU1_class.Text = RPDU_list[0].Class_Text_R();
            else if (rpdu == RPDU_list[1])
                label_RPDU2_class.Text = RPDU_list[1].Class_Text_R();
            else if (rpdu == RPDU_list[2])
                label_RPDU3_class.Text = RPDU_list[2].Class_Text_R();
            else if (rpdu == RPDU_list[3])
                label_RPDU4_class.Text = RPDU_list[3].Class_Text_R();
            else
                throw new ArgumentException();
        }
        /// <summary>
        /// Установка состояния РПДУ и вывод на <c>Main_form</c>
        /// </summary>
        /// <param name="rpdu"> РПДУ</param>
        /// <param name="state">Состояние -<c>(int)State_RPDU.состояние</c></param>
        private void FM_RPDU_State(RPDU rpdu, int state)
        {
            try
            {
                rpdu.State_R = state;
            }
            catch (ArgumentException ex)
            {
            }

            if (rpdu == RPDU_list[0])
            {
                label_RPDU1_state.BackColor = RPDU_list[0].State_Text_Color();
                label_RPDU1_state.Text = RPDU_list[0].State_Text_R();
            }
            else if (rpdu == RPDU_list[1])
            {
                label_RPDU2_state.BackColor = RPDU_list[1].State_Text_Color();
                label_RPDU2_state.Text = RPDU_list[1].State_Text_R();
            }
            else if (rpdu == RPDU_list[2])
            {
                label_RPDU3_state.BackColor = RPDU_list[2].State_Text_Color();
                label_RPDU3_state.Text = RPDU_list[2].State_Text_R();
            }
            else if (rpdu == RPDU_list[3])
            {
                label_RPDU4_state.BackColor = RPDU_list[3].State_Text_Color();
                label_RPDU4_state.Text = RPDU_list[3].State_Text_R();
            }
            else
                throw new ArgumentException();
        }

        /// <summary>
        /// Установка мощности излучения для РПДУ и вывод на <c>Main_form</c>
        /// </summary>
        /// <param name="rpdu"> РПДУ</param>
        /// <param name="cl">Мощность -<c>(int)Power_RPDU.мощность</c></param>
        private void FM_RPDU_Power(RPDU rpdu, int power)
        {
            try
            {
                rpdu.Power_R = power;
            }
            catch (ArgumentException ex)
            {
            }

            if (rpdu == RPDU_list[0])
                label_RPDU1_power.Text = RPDU_list[0].Power_Text_R();
            else if (rpdu == RPDU_list[1])
                label_RPDU2_power.Text = RPDU_list[1].Power_Text_R();
            else if (rpdu == RPDU_list[2])
                label_RPDU3_power.Text = RPDU_list[2].Power_Text_R();
            else if (rpdu == RPDU_list[3])
                label_RPDU4_power.Text = RPDU_list[3].Power_Text_R();
            else
                throw new ArgumentException();
        }
        #endregion

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToString();
        }

        private void label_time_Click(object sender, EventArgs e)
        {

        }

        private void button_RPDU1_Click(object sender, EventArgs e)
        {
            RPDU_form rpdu_f = new RPDU_form(RPDU_list[0]);
            rpdu_f.ShowDialog();

            FM_RPDU_State(RPDU_list[0], RPDU_list[0].State_R);
            FM_RPDU_Freq(RPDU_list[0], RPDU_list[0].Freq_R);
            FM_RPDU_Power(RPDU_list[0], RPDU_list[0].Power_R);
            FM_RPDU_Izl_Class(RPDU_list[0], RPDU_list[0].Class_R);
        }

        private void button_BSK_Click(object sender, EventArgs e)
        {
            BSK_form BSK_form = new BSK_form();
            BSK_form.Show();
        }

        private void button_BPS_Click(object sender, EventArgs e)
        {
            BPS_form BPS_form = new BPS_form();
            BPS_form.Show();
        }
    }
}
