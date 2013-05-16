using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VMSPD_server
{
    /// <summary>
    /// Перечисление классов излучения
    /// </summary>
    public enum Class_RPDU : int
    {
        None = 0,
        A1A_50 = 72,
        A1A_100 = 73,
        M1B = 151,
        H3E = 6,
        R3E = 5,
        J3E = 4,
        F3E = 64,
        F1B_20_10 = 111,
        F1B_125_50 = 122,
        F1B_125_100 = 123,
        F1B_200_50 = 132,
        F1B_200_100 = 133,
        F1B_500_50 = 142,
        F1B_500_100 = 143,
        F1B_500_150 = 144,
        F1B_500_300 = 145,
        F1B_1000_100 = 153,
        F1B_1000_300 = 155,
        F1B_1000_500 = 156,
        F1B_6000_1200 = 167,
        F1B_6000_2400 = 168,
        G1B_100 = 33,
        G1B_300 = 35,
        G1B_500 = 36,
        G1B_600 = 169,
        SF1B_20_10 = 911,
        ISG1B_500 = 26,
        Vnesh = 90
    };
    /// <summary>
    /// Состояние РПДУ
    /// </summary>
    public enum State_RPDU : int
    {
        OFFLINE = 0,
        RPDU_OFF = 1,
        RPDU_ISPRAVEN = 2,
        RPDU_GOTOV = 3,
        RPDU_IZL = 4,
        RPDU_ERR = 5
    };

    /// <summary>
    /// Мощность РПДУ
    /// </summary>
    public enum Power_RPDU : int
    {
        None = 0,
        P_10 = 1,
        P_20 = 2,
        P_30 = 3,
        P_40 = 4,
        P_50 = 5,
        P_60 = 6, 
        P_70 = 7,
        P_80 = 8,
        P_90 = 9,
        P_100 = 10

    };

    /// <summary>
    /// класс описания РПДУ
    /// Все формы общаются с РПДУ через этот класс
    /// </summary>
    /// <example>
    /// Надо передать параметр - записываем параметр в класс RPDU
    /// Полям формы присваиваются значения свойств класса.
    /// </example>
    public class RPDU
    {
        private string state_rpdu = null;
        private string class_rpdu = null;
        private string freq_rpdu = null;
        private string power_rpdu = null;

        /// <summary>
        /// Номер РПДУ
        /// </summary>
        public int RPDU_Numb { set; get; }
        
        
        /// <summary>
        /// Конструкторы
        /// </summary>
        public RPDU(int R_numb, int state_RPDU, int class_RPDU, int freq, int power_RPDU)
        {
            // TODO: Complete member initialization
            this.RPDU_Numb = R_numb;
            this.State_R = state_RPDU;
            this.Class_R = class_RPDU;
            this.Freq_R = freq;
            this.Power_R = power_RPDU;
        }
        #region Состояние РПДУ
        /// <summary>
        /// Состояние РПДУ
        /// Параметры брать из перечисления <c> State_RPDU</c>
        /// </summary>
        /// <example>
        /// <c> State_R = State_RPDU.RPDU_OFF</c>
        /// </example>
        public int  State_R{ set; get; }

        /// <summary>
        /// Состояние РПДУ представлено в виде строки
        /// На основе <c>int State_R{set;get;}</c>
        /// </summary>
        /// <returns>Состояние РПДУ: "ГОТОВ К ДУ"</returns>
        public string State_Text_R()
        {
            string st = null;
            switch (State_R)
            {
                case 0:
                    st = String.Empty;
                    break;
                case 1:
                    st = "ГОТОВ К ДУ";
                    break;
                case 2:
                    st = "ИСПРАВНО";
                    break;
                case 3:
                    st = "ГОТОВ";
                    break;
                case 4:
                    st = "ИЗЛУЧЕНИЕ";
                    break;
                case 5:
                    st = "НЕИСПРАВЕН";
                    break;

            }
            if (st == null)
                throw new ArgumentNullException();
            state_rpdu = st;
            return state_rpdu;
        }
        /// <summary>
        /// Цвет для бекграунда текста
        /// На основе <c>int State_R{set;get;}</c>
        /// </summary>
        /// <returns>
        /// Возвращает цвет фона - тусклый-выключен, исправно- зеленый, неисправно - красный
        /// </returns>
        public Color State_Text_Color()
        {
            Color cl = SystemColors.Control;
            switch ((int)State_R)
            {
                case 0:
                case 1:
                    cl = SystemColors.Control;
                    break;
                case 2:
                case 3:
                case 4:
                    cl = Color.PaleGreen;
                    break;
                case 5:
                    cl = Color.Crimson;
                    break;
            }
            return cl;
        }

        #endregion
        #region Класс излучения РПДУ
        /// <summary>
        /// Класс излучения
        /// Параметры брать из перечисления <c> Class_RPDU</c>
        /// </summary>
       
        /// <example>Установить класс F3E : 
        /// <c>Class_R=Class_RPDU.F3E;</c>
        /// </example>
        ///
        public int Class_R { set; get; }

        /// <summary>
        /// Класс излучения представлен в виде строки
        /// На основе <c> int Class_R {set; get;}</c>
        /// </summary>
        /// <returns> 
        /// Возвращает название текущего установленного класса излучения "A1A- 50 Бод"
        /// </returns>
        public string Class_Text_R()
        {
            StringBuilder str = new StringBuilder();
            string st = null;
            switch ((int)Class_R)
            {
                case 0:
                    st = String.Empty;
                    break;
                case 72:
                    st = "A1A- 50 Бод";
                    break;
                case 73:
                    st = "A1A- 100 Бод";
                    break;
                case 151:
                    st = "M1B";
                    break;
                case 6:
                    st = "H3E";
                    break;
                case 5:
                    st = "R3E";
                    break;
                case 4:
                    st = "J3E";
                    break;
                case 64:
                    st = "F3E";
                    break;
                case 111:
                    st = "F1B-20 Гц- 10 Бод";
                    break;
                case 122:
                    st = "F1B-125 Гц- 50 Бод";
                    break;
                case 123:
                    st = "F1B-125 Гц- 100 Бод";
                    break;
                case 132:
                    st = "F1B-200 Гц- 50 Бод";
                    break;
                case 133:
                    st = "F1B-200 Гц- 100 Бод";
                    break;
                case 142:
                    st = "F1B-500 Гц- 50 Бод";
                    break;
                case 143:
                    st = "F1B-500 Гц- 100 Бод";
                    break;
                case 144:
                    st = "F1B-500 Гц- 150 Бод";
                    break;
                case 145:
                    st = "F1B-500 Гц- 300 Бод";
                    break;
                case 153:
                    st = "F1B-1000 Гц- 100 Бод";
                    break;
                case 155:
                    st = "F1B-1000 Гц- 300 Бод";
                    break;
                case 156:
                    st = "F1B-1000 Гц- 500 Бод";
                    break;
                case 167:
                    st = "F1B-6000 Гц- 1200 Бод";
                    break;
                case 168:
                    st = "F1B-6000 Гц- 2400 Бод";
                    break;
                case 33:
                    st = "G1B- 100 Бод";
                    break;
                case 35:
                    st = "G1B- 300 Бод";
                    break;
                case 36:
                    st = "G1B- 500 Бод";
                    break;
                case 169:
                    st = "G1B- 600 Бод";
                    break;
                case 911:
                    st = "5F1B-20 Гц- 10 Бод";
                    break;
                case 26:
                    st = "15G1B- 500 Бод";
                    break;
                case 90:
                    st = "Внешняя ПЧ";
                    break;


            }
            if ((int)Class_R != 0)
                str.Append("E= ");
            str.Append(st);
            if (str == null)
                throw new ArgumentNullException();
            class_rpdu = str.ToString();
            return class_rpdu;

        }
        #endregion 
        #region Частота излучения РПДУ
        /// <summary>
        /// Частота РПДУ
        /// </summary>
        /// <example>Формат: 100000 = 10000,00 kHz; 299800 = 2998,00 kHz
        /// Установить 8000,32 : 
        /// <c> Freq_R(800032);</c>
        /// </example>
        public int Freq_R { set; get; }

        /// <summary>
        /// Частота, представленная ввиде строки
        /// (на основе свойства <c>Freq{set;get;}</c>)
        /// </summary>
        /// <returns>Строка с частотой : "10000,00 kHz"</returns>
        /// 

        public string Get_Text_Freq()
        {
            StringBuilder st = new StringBuilder();
            if ((int)Freq_R != 0)
            {
                int temp1 = (int)Freq_R / 100;
                int temp2 = (int)Freq_R % 100;
                st.Append("F=");
                st.Append(temp1);
                st.Append(",");
                st.Append(temp2);
                st.Append(" kHz ");
            }
            else
            {
                st.Append(String.Empty);
            }

            if (st == null)
                throw new ArgumentNullException();
            freq_rpdu = st.ToString();           
            return freq_rpdu;
        }
        #endregion
        #region Мощность излучения РПДУ
        /// <summary>
        /// Мощность РПДУ 
        /// </summary>
        /// <example>
        /// <c> Power_R = Power_RPDU.P_10</c> Мощность 10%
        /// </example>
        public int Power_R { set; get; }

        /// <summary>
        /// Мощность, представленна ввиде строки
        /// </summary>
        /// <returns>Строка мощность : "10 %"</returns>
        public string Power_Text_R()
        {
            StringBuilder st = new StringBuilder();
            if (Power_R != 0)
            {
                st.Append("P= ");
                st.Append((int)Power_R * 10);
                st.Append(" %");
            }
            else
            {
                st.Append(String.Empty);
            }

            if (st == null)
               throw new ArgumentNullException();
            power_rpdu = st.ToString();
            return power_rpdu;
        }
        #endregion

    }
}
