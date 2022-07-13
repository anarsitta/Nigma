using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Nigma
{
    public partial class MainForm : MaterialForm
    {


        public MainForm()
        {
            InitializeComponent();

            Settings s = new Settings(this);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            if (s.themeToggle.Checked)
            {
                s.ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                s.ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            if (s.materialRadioButton1.Checked == true)
            {
                s.ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
            }
            else if (s.materialRadioButton2.Checked == true)
            {
                s.ThemeManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
            }
            else if (s.materialRadioButton3.Checked == true)
            {
                s.ThemeManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.WHITE);
            }

        }
        
        void MainForm_Load(object sender, EventArgs e)
        {
            #region [Eng_data]
            //Создание и занесение данных в Английский ротор
            rr = new Rotor_Eng("BDFHJLCPRTXVZNYEIWGAKMUSQO", lblRotor1, 'A');
            rm = new Rotor_Eng("AJDKSIRUXBLHWTMCQGZNPYFVOE", lblRotor2, 'B');
            rl = new Rotor_Eng("EKMFLGDQVZNTOWYHXUSPAIBRCJ", lblRotor3, 'C');
            reflector = new Rotor_Eng("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');

            rr.SetNextRotor(rm);
            rm.SetNextRotor(rl);
            rl.SetNextRotor(reflector);
            rm.SetPreviousRotor(rr);
            rl.SetPreviousRotor(rm);
            reflector.SetPreviousRotor(rl);
            #endregion

            #region [Ru_data]
            //Создание и занесение данных в Русский ротор
            rr_1 = new Rotor_Ru("ВШЭМСРЬТЫЗКДЯЕЪЮНЦЩАЛУИГПЧЙФБХЖО", lblRotor1_1, 'А');
            rm_1 = new Rotor_Ru("ЯЧФЫЭВЪМЬУХЗНШСДАЖПЕБЦЩИЛЙТГЮКРО", lblRotor2_1, 'Б');
            rl_1 = new Rotor_Ru("ШЫЩПЖЮЙЧВГКХАЪФУЬЦЛТРЕНДМЯБЭСЗОИ", lblRotor3_1, 'В');
            reflector_1 = new Rotor_Ru("ЮЙВЫБУХПИНЗЛРДКФСЩГЭЧОЯШТАЕЪМЬЦЖ", null, '\0');

            rr_1.SetNextRotor(rm_1);
            rm_1.SetNextRotor(rl_1);
            rl_1.SetNextRotor(reflector_1);
            rm_1.SetPreviousRotor(rr_1);
            rl_1.SetPreviousRotor(rm_1);
            reflector_1.SetPreviousRotor(rl_1);
            #endregion

        }

        #region [Rotor_eng]

        #region [Buttons_eng]
        //Обработка нажатия на кнопку шифрования [eng]
        private void button1_Click(object sender, EventArgs e)
        {
            //Считывание
            char[] chIn = txtInit.Text.ToUpper().ToCharArray();
            //Очистка данных
            txtFinal.Text = "";
            //Шифрация/Дешифрация
            for (int i = 0; i < chIn.Length; i++)
            {
                if (chIn[i] >= 65 && chIn[i] <= 90)
                {
                    rr.Move();
                    rr.PutDataIn(chIn[i]);
                    txtFinal.AppendText("" + rr.GetDataOut());
                }
            }

        }

        //Сохранение данных в исходном текст-боксе [eng]
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(txtInit.Text);
                    sw.Close();
                }
            }
        }

        //Загрузка данных в исходный текстбокс [eng]
        private void button9_Click(object sender, EventArgs e)
        {
            txtInit.Clear();
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr;
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtInit.Text = File.ReadAllText(o.FileName, System.Text.Encoding.UTF8);
            }
        }

        //Сохранение данных в финальном текст-боксе [eng]
        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(txtFinal.Text);
                    sw.Close();
                }
            }
        }

        //Загрузка данных в финальный текстбокс [eng]
        private void button12_Click(object sender, EventArgs e)
        {
            txtFinal.Clear();
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr;
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtFinal.Text = File.ReadAllText(o.FileName, System.Text.Encoding.UTF8);
            }
        }
        #endregion

        #region [open_form_eng]
        //Обработка нажатия на кнопку о программе [eng]
        private void btnDespre_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"help.chm");
        }

        //Обработка нажатия на кнопку настроек [eng]
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(this);
            this.Hide();
            s.Show();
        }
        #endregion

        #region [rotor_move_eng]
        //Прокрутка 3-го ротора вверх [eng]
        private void btnRotor1Up_Click(object sender, EventArgs e)
        {
            rr.Move();
        }

        //Прокрутка 3-го ротора вниз [eng]
        private void btnRotor1Down_Click(object sender, EventArgs e)
        {
            rr.MoveBack();
        }

        //Прокрутка 2-го ротора вверх [eng]
        private void btnRotor2Up_Click(object sender, EventArgs e)
        {
            rm.Move();
        }

        //Прокрутка 2-го ротора вниз [eng]
        private void btnRotor2Down_Click(object sender, EventArgs e)
        {
            rm.MoveBack();
        }

        //Прокрутка 1-го ротора вверх [eng]
        private void btnRotor3Up_Click(object sender, EventArgs e)
        {
            rl.Move();
        }

        //Прокрутка 1-го ротора вниз [eng]
        private void btnRotor3Down_Click(object sender, EventArgs e)
        {
            rl.MoveBack();
        }
        #endregion

        #region [get_data_eng]
        //Получить выбранный рефлектор [eng]
        public string GetReflector()
        {
            return reflector.GetLayout();
        }

        //Получение значения 3-го ротора [eng]
        public string GetRightRotor()
        {
            return rr.GetLayout();
        }

        //Получение значения 2-го ротора [eng]
        public string GetMiddleRotor()
        {
            return rm.GetLayout();
        }

        //Получение значения 1-го ротора [eng]
        public string GetLeftRotor()
        {
            return rl.GetLayout();
        }

        //Очистка поля ввода [eng]
        private void button3_Click(object sender, EventArgs e)
        {
            txtInit.Clear();
        }

        //Очистка поля вывода [eng]
        private void button4_Click(object sender, EventArgs e)
        {
            txtFinal.Clear();
        }
        #endregion

        //Метод изменения роторов [eng]
        public void ChangeRotors(string rot1, string rotName1, char rotNotch1,
                                 string rot2, string rotName2, char rotNotch2,
                                 string rot3, string rotName3, char rotNotch3)
        {
            lblRotorS.Text = rotName1;
            lblRotorM.Text = rotName2;
            lblRotorD.Text = rotName3;
            rr = null;
            rm = null;
            rl = null;

            rr = new Rotor_Eng(rot3, lblRotor1, rotNotch3);
            rm = new Rotor_Eng(rot2, lblRotor2, rotNotch2);
            rl = new Rotor_Eng(rot1, lblRotor3, rotNotch1);

            rr.ResetOffset();
            rm.ResetOffset();
            rl.ResetOffset();

            rr.SetNextRotor(rm);
            rm.SetNextRotor(rl);
            rl.SetNextRotor(reflector);
            rm.SetPreviousRotor(rr);
            rl.SetPreviousRotor(rm);
            reflector.SetPreviousRotor(rl);

            lblRotor1.Text = "A";
            lblRotor2.Text = "A";
            lblRotor3.Text = "A";
        }

        //Метод изменения рефлектора [eng]
        public void SetReflector(string refl)
        {
            reflector = new Rotor_Eng(refl, null, '\0');
            reflector.SetPreviousRotor(rl);
            rl.SetNextRotor(reflector);
        }

        #endregion

        #region [Rotor_ru]

        #region [Buttons_ru]
        //Шифрование
        private void button6_Click_1(object sender, EventArgs e)
        {
            //Считывание
            char[] chIn = txtInit_1.Text.ToUpper().ToCharArray();
            //Очистка данных
            txtFinal_1.Text = "";
            //Шифрация/Дешифрация
            for (int i = 0; i < chIn.Length; i++)
            {
                if (chIn[i] >= 1040 && chIn[i] <= 1071)
                {
                    rr_1.Move();
                    rr_1.PutDataIn(chIn[i]);
                    txtFinal_1.AppendText("" + rr_1.GetDataOut());
                }
            }

        }

        //Очистка
        private void button7_Click(object sender, EventArgs e)
        {
            txtInit_1.Clear();
        }

        //Сохранение данных в начальном текстбоксе
        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(txtInit_1.Text);
                    sw.Close();
                }
            }
        }

        //Загрузка данных в начальный текстбокс
        private void button23_Click(object sender, EventArgs e)
        {
            txtInit.Clear();
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr;
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtInit_1.Text = File.ReadAllText(o.FileName, System.Text.Encoding.UTF8);
            }
        }

        //Очистка финального текстбокса
        private void button10_Click(object sender, EventArgs e)
        {
            txtFinal_1.Clear();
        }

        //Сохранение финального текстбокса
        private void button11_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine(txtFinal_1.Text);
                    sw.Close();
                }
            }
        }

        //Загрузка в финальный текстбокс
        private void button26_Click(object sender, EventArgs e)
        {
            txtFinal_1.Clear();
            Encoding enc = Encoding.GetEncoding(1251);
            StreamReader sr;
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtFinal_1.Text = File.ReadAllText(o.FileName, System.Text.Encoding.UTF8);
            }
        }

        #endregion

        #region [open_form_ru]

        //Обработка нажатия кнопку дополнительно [ru]
        private void btnDespre_1_Click(object sender, EventArgs e)
        {

        }

        //Обработка нажатия на кнопку настроек [ru]
        private void btnSettings_1_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(this);
            s.ShowDialog();
        }

        #endregion

        #region [rotor_move_ru]

        private void btnRotor1Up_1_Click(object sender, EventArgs e)
        {
            rr_1.Move();
        }

        private void btnRotor1Down_1_Click(object sender, EventArgs e)
        {
            rr_1.MoveBack();
        }

        private void btnRotor2Up_1_Click(object sender, EventArgs e)
        {
            rm_1.Move();
        }

        private void btnRotor2Down_1_Click(object sender, EventArgs e)
        {
            rm_1.MoveBack();
        }

        private void btnRotor3Up_1_Click(object sender, EventArgs e)
        {
            rl_1.Move();
        }

        private void btnRotor3Down_1_Click(object sender, EventArgs e)
        {
            rl_1.MoveBack();
        }

        #endregion

        #region [get_data_ru]

        //Получить выбранный рефлектор
        public string GetReflector_1()
        {
            return reflector_1.GetLayout();
        }

        //Получение значения 3-го ротора
        public string GetRightRotor_1()
        {
            return rr_1.GetLayout();
        }

        //Получение значения 2-го ротора
        public string GetMiddleRotor_1()
        {
            return rm_1.GetLayout();
        }

        //Получение значения 1-го ротора
        public string GetLeftRotor_1()
        {
            return rl_1.GetLayout();
        }

        #endregion

        //Метод изменения роторов [ru]
        public void ChangeRotors_1(string rot1, string rotName1, char rotNotch1,
                                 string rot2, string rotName2, char rotNotch2,
                                 string rot3, string rotName3, char rotNotch3)
        {
            lblRotorS_1.Text = rotName1;
            lblRotorM_1.Text = rotName2;
            lblRotorD_1.Text = rotName3;

            rr_1 = null;
            rm_1 = null;
            rl_1 = null;

            rr_1 = new Rotor_Ru(rot3, lblRotor1_1, rotNotch3);
            rm_1 = new Rotor_Ru(rot2, lblRotor2_1, rotNotch2);
            rl_1 = new Rotor_Ru(rot1, lblRotor3_1, rotNotch1);

            rr_1.ResetOffset();
            rm_1.ResetOffset();
            rl_1.ResetOffset();

            rr_1.SetNextRotor(rm_1);
            rm_1.SetNextRotor(rl_1);
            rl_1.SetNextRotor(reflector_1);
            rm_1.SetPreviousRotor(rr_1);
            rl_1.SetPreviousRotor(rm_1);
            reflector_1.SetPreviousRotor(rl_1);

            lblRotor1_1.Text = "А";
            lblRotor2_1.Text = "А";
            lblRotor3_1.Text = "А";
        }

        //Метод изменения рефлектора
        public void SetReflector_1(string refl)
        {
            reflector_1 = new Rotor_Ru(refl, null, '\0');
            reflector_1.SetPreviousRotor(rl_1);
            rl_1.SetNextRotor(reflector_1);
        }

        #endregion

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                System.Diagnostics.Process.Start(@"help.chm");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
