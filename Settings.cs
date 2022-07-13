using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Nigma
{

    public partial class Settings : MaterialForm
	{

		public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
		public Settings(MainForm mf)
        {

            InitializeComponent();
			this.mf = mf;

			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);

			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

			if (themeToggle.Checked)
			{
				ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
			}
			else
			{
				ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
			}

			if (materialRadioButton1.Checked == true)
			{
				ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
			}
			else if (materialRadioButton2.Checked == true)
			{
				ThemeManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
			}
			else if (materialRadioButton3.Checked == true)
			{
				ThemeManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.WHITE);
			}
		}

		

		//Прогрузка компонентов
		private void Settings_Load(object sender, EventArgs e)
        {
            #region [Opt_Eng]
            //Создание списков
            al1 = new ArrayList();
			al2 = new ArrayList();
			al3 = new ArrayList();

			//Заполнение роторов
			al1.Add("Rotor I");
			al1.Add("Rotor II");
			al1.Add("Rotor III");
			al1.Add("Rotor IV");
			al1.Add("Rotor V");
			rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
			rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
			rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
			rotor4 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
			rotor5 = "VZBRGITYUPSDNHLXAWMJQOFECK";

			//Добавление роторов
			al2.Add(rotor1);
			al2.Add(rotor2);
			al2.Add(rotor3);
			al2.Add(rotor4);
			al2.Add(rotor5);
			al3.Add("Q");
			al3.Add("E");
			al3.Add("V");
			al3.Add("J");
			al3.Add("Z");

			//Очистка
			lstAvailableRotors.Items.Clear();

			//Выбор роторов
			for (int i = 0; i < al1.Count; i++)
			{
				lstAvailableRotors.Items.Add(al1[i]);
			}
			ttSelect.SetToolTip(btnSelect, "Select rotor");
			ttDeselect.SetToolTip(btnDeselect, "Deselect rotor");
			ttUp.SetToolTip(btnUp, "Raise the rotor");
			ttDown.SetToolTip(btnDown, "Lower the rotor");

			//Заполнение ротора
			for (int i = 0; i < cmbReflector.Items.Count; i++)
			{
				if (cmbReflector.Items[i].ToString().EndsWith(mf.GetReflector()))
				{
					cmbReflector.SelectedIndex = i;
				}
			}
			//Заполнение ротора
			for (int i = 0; i < al2.Count; i++)
			{
				if (al2[i].ToString() == mf.GetLeftRotor())
				{
					lstAvailableRotors.Items.Remove(al1[i].ToString());
					lstSelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
			//Заполнение ротора
			for (int i = 0; i < al2.Count; i++)
			{
				if (al2[i].ToString() == mf.GetMiddleRotor())
				{
					lstAvailableRotors.Items.Remove(al1[i].ToString());
					lstSelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
			//Заполнение ротора
			for (int i = 0; i < al2.Count; i++)
			{
				if (al2[i].ToString() == mf.GetRightRotor())
				{
					lstAvailableRotors.Items.Remove(al1[i].ToString());
					lstSelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
			#endregion

			#region [Opt_Ru]

			//Создание списков
			al1_1 = new ArrayList();
			al2_1 = new ArrayList();
			al3_1 = new ArrayList();

			//Заполнение роторов
			al1_1.Add("Rotor I");
			al1_1.Add("Rotor II");
			al1_1.Add("Rotor III");
			al1_1.Add("Rotor IV");
			al1_1.Add("Rotor V");
			rotor1_1 = "ШЫЩПЖЮЙЧВГКХАЪФУЬЦЛТРЕНДМЯБЭСЗОИ";
			rotor2_1 = "ЯЧФЫЭВЪМЬУХЗНШСДАЖПЕБЦЩИЛЙТГЮКРО";
			rotor3_1 = "ВШЭМСРЬТЫЗКДЯЕЪЮНЦЩАЛУИГПЧЙФБХЖО";
			rotor4_1 = "ЫЭЧФЙЯЛШДЕЩПЬЦНЗИВГМБОУРТСЪЖКЮАХ";
			rotor5_1 = "ЭЦГМЖЮЬЪРЛЯВКУПСЫИЕЩЧНОХФБТДШАЗЙ";

			//Добавление роторов
			al2_1.Add(rotor1_1);
			al2_1.Add(rotor2_1);
			al2_1.Add(rotor3_1);
			al2_1.Add(rotor4_1);
			al2_1.Add(rotor5_1);
			al3_1.Add("А");
			al3_1.Add("Х");
			al3_1.Add("Ч");
			al3_1.Add("Д");
			al3_1.Add("Е");

			//Очистка
			lstAvailableRotors_1.Items.Clear();

			//Выбор роторов
			for (int i = 0; i < al1_1.Count; i++)
			{
				lstAvailableRotors_1.Items.Add(al1_1[i]);
			}
			ttSelect_1.SetToolTip(btnSelect_1, "Выбрать ротор");
			ttDeselect_1.SetToolTip(btnDeselect_1, "Убрать ротор");
			ttUp_1.SetToolTip(btnUp_1, "Поднять ротор");
			ttDown_1.SetToolTip(btnDown_1, "Опустить ротор");


			//Заполнение ротора
			for (int i = 0; i < cmbReflector_1.Items.Count; i++)
			{
				if (cmbReflector_1.Items[i].ToString().EndsWith(mf.GetReflector_1()))
				{
					cmbReflector_1.SelectedIndex = i;
				}
			}

			cmbReflector_1.SelectedIndex = 0;
			//Заполнение ротора
			for (int i = 0; i < al2_1.Count; i++)
			{
				if (al2_1[i].ToString() == mf.GetLeftRotor_1())
				{
					lstAvailableRotors_1.Items.Remove(al1_1[i].ToString());
					lstSelectedRotors_1.Items.Add(al1_1[i].ToString());
					break;
				}
			}
			//Заполнение ротора
			for (int i = 0; i < al2_1.Count; i++)
			{
				if (al2_1[i].ToString() == mf.GetMiddleRotor_1())
				{
					lstAvailableRotors_1.Items.Remove(al1_1[i].ToString());
					lstSelectedRotors_1.Items.Add(al1_1[i].ToString());
					break;
				}
			}
			//Заполнение ротора
			for (int i = 0; i < al2_1.Count; i++)
			{
				if (al2_1[i].ToString() == mf.GetRightRotor_1())
				{
					lstAvailableRotors_1.Items.Remove(al1_1[i].ToString());
					lstSelectedRotors_1.Items.Add(al1_1[i].ToString());
					break;
				}
			}

			#endregion
		}

        #region [Управление роторами_Eng]
        //Выбранный ротор
        void LstAvailableRotorsSelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lstAvailableRotors.SelectedIndex < 0)
			{
				return;
			}
			for (int i = 0; i < al1.Count; i++)
			{
				if (lstAvailableRotors.SelectedItem.ToString() == "" + al1[i])
				{
					lblRotorStructure.Text = "" + al2[i];
					return;
				}
			}
			lblRotorStructure.Text = "";
		}

		// Установка ротора
		private void lstSelectedRotors_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstSelectedRotors.SelectedIndex < 0)
			{
				return;
			}
			for (int i = 0; i < al1.Count; i++)
			{
				if (lstSelectedRotors.SelectedItem.ToString() == "" + al1[i])
				{
					lblRotorStructure.Text = "" + al2[i];
					return;
				}
			}
			lblRotorStructure.Text = "";
		}

		//Добавить ротор
		private void btnSelect_Click(object sender, EventArgs e)
		{
			if (lstAvailableRotors.SelectedIndex < 0)
			{
				MessageBox.Show(this, "Select a rotor first!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			lstSelectedRotors.Items.Add(lstAvailableRotors.SelectedItem);
			lstAvailableRotors.Items.Remove(lstAvailableRotors.SelectedItem);
			lblRotorStructure.Text = "";
		}

		//Убрать ротор
		private void btnDeselect_Click(object sender, EventArgs e)
		{
			if (lstSelectedRotors.SelectedIndex < 0)
			{
				MessageBox.Show(this, "Select a rotor first!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			lstAvailableRotors.Items.Add(lstSelectedRotors.SelectedItem);
			lstSelectedRotors.Items.Remove(lstSelectedRotors.SelectedItem);
		}

		//Поднять ротор
		private void btnUp_Click(object sender, EventArgs e)
		{
			if (lstSelectedRotors.SelectedIndex <= 0)
			{
				return;
			}

			string strTemp = "" + lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex - 1];
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex - 1] = lstSelectedRotors.SelectedItem;
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
			lstSelectedRotors.SelectedIndex = lstSelectedRotors.SelectedIndex - 1;
		}

		//Опустить ротор
		private void btnDown_Click(object sender, EventArgs e)
		{
			if (lstSelectedRotors.SelectedIndex < 0 || lstSelectedRotors.SelectedIndex == lstSelectedRotors.Items.Count - 1)
			{
				return;
			}

			string strTemp = "" + lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex + 1];
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex + 1] = lstSelectedRotors.SelectedItem;
			lstSelectedRotors.Items[lstSelectedRotors.SelectedIndex] = strTemp;
			lstSelectedRotors.SelectedIndex = lstSelectedRotors.SelectedIndex + 1;
		}

		//Сохранение настроек и закрытие
		private void btnOk_Click(object sender, EventArgs e)
		{
			//Проверка количества роторов
			if (lstSelectedRotors.Items.Count != 3)
			{
				MessageBox.Show(this, "The required number of rotors is missing!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			//Создание массивов
			ArrayList alRot = new ArrayList();
			ArrayList alRotName = new ArrayList();
			ArrayList alRotNotch = new ArrayList();
			//Перебор установленных ротором
			for (int j = 0; j < lstSelectedRotors.Items.Count; j++)
			{
				for (int i = 0; i < al1.Count; i++)
				{
					if (lstSelectedRotors.Items[j].ToString() == "" + al1[i])
					{
						alRot.Add(al2[i]);
						alRotName.Add(al1[i].ToString().Substring(al1[i].ToString().LastIndexOf(" ")).Trim());
						alRotNotch.Add(al3[i]);
						break;
					}
				}
			}
			//Изменение в соответствии с перебором
			mf.ChangeRotors(alRot[0].ToString(),
							alRotName[0].ToString(),
							alRotNotch[0].ToString().ToCharArray()[0],
							alRot[1].ToString(),
							alRotName[1].ToString(),
							alRotNotch[1].ToString().ToCharArray()[0],
							alRot[2].ToString(),
							alRotName[2].ToString(),
							alRotNotch[2].ToString().ToCharArray()[0]);

			if (cmbReflector.SelectedIndex > -0)
			{
				mf.SetReflector(cmbReflector.SelectedItem.ToString().Substring(cmbReflector.SelectedItem.ToString().LastIndexOf("=") + 2).Trim());
			}
			//Вывод окна с параметрами изменённых настроек
			MessageBox.Show(
			   "There was a change of the reflector.\nCurrent reflector:\n\"" + mf.GetReflector() + "\"",
			   "Information message",
			   MessageBoxButtons.YesNo,
			   MessageBoxIcon.Information,
			   MessageBoxDefaultButton.Button1);

			Close();
		}

		//Выход из настроек
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
        #endregion

        #region [Управление роторами_Ru]
        //Выбор ротора
        private void lstAvailableRotors_1_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (lstAvailableRotors_1.SelectedIndex < 0)
			{
				return;
			}
			for (int i = 0; i < al1_1.Count; i++)
			{
				if (lstAvailableRotors_1.SelectedItem.ToString() == "" + al1_1[i])
				{
					lblRotorStructure_1.Text = "" + al2_1[i];
					return;
				}
			}
			lblRotorStructure_1.Text = "";
		}

		//Закрытие формы
        private void btnCancel_1_Click(object sender, EventArgs e)
        {
			Close();
        }

		//Сохранение изменение
        private void btnOk_1_Click(object sender, EventArgs e)
        {
			if (lstSelectedRotors_1.Items.Count != 3)
			{
				MessageBox.Show(this, "Отсутствует требуемое количество роторов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			ArrayList alRot = new ArrayList();
			ArrayList alRotName = new ArrayList();
			ArrayList alRotNotch = new ArrayList();

			for (int j = 0; j < lstSelectedRotors_1.Items.Count; j++)
			{
				for (int i = 0; i < al1_1.Count; i++)
				{
					if (lstSelectedRotors_1.Items[j].ToString() == "" + al1_1[i])
					{
						alRot.Add(al2_1[i]);
						alRotName.Add(al1_1[i].ToString().Substring(al1_1[i].ToString().LastIndexOf(" ")).Trim());
						alRotNotch.Add(al3_1[i]);
						break;
					}
				}
			}

			mf.ChangeRotors_1(alRot[0].ToString(),
							alRotName[0].ToString(),
							alRotNotch[0].ToString().ToCharArray()[0],
							alRot[1].ToString(),
							alRotName[1].ToString(),
							alRotNotch[1].ToString().ToCharArray()[0],
							alRot[2].ToString(),
							alRotName[2].ToString(),
							alRotNotch[2].ToString().ToCharArray()[0]);

			if (cmbReflector_1.SelectedIndex > -0)
			{
				mf.SetReflector_1(cmbReflector_1.SelectedItem.ToString().Substring(cmbReflector_1.SelectedItem.ToString().LastIndexOf("=") + 2).Trim());
			}
			MessageBox.Show(
			   "Отражатель изменен.\nТекущий отражатель:\n\"" + mf.GetReflector_1() + "\"",
			   "Информационное сообщение",
			   MessageBoxButtons.YesNo,
			   MessageBoxIcon.Information,
			   MessageBoxDefaultButton.Button1);

			Close();
		}

		//Выбрать ротор
        private void btnSelect_1_Click(object sender, EventArgs e)
        {
			if (lstAvailableRotors_1.SelectedIndex < 0)
			{
				MessageBox.Show(this, "Сначала выберите ротор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			lstSelectedRotors_1.Items.Add(lstAvailableRotors_1.SelectedItem);
			lstAvailableRotors_1.Items.Remove(lstAvailableRotors_1.SelectedItem);
			lblRotorStructure_1.Text = "";
		}

		//Убрать ротор
        private void btnDeselect_1_Click(object sender, EventArgs e)
        {
			if (lstSelectedRotors_1.SelectedIndex < 0)
			{
				MessageBox.Show(this, "Сначала выберите ротор!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			lstAvailableRotors_1.Items.Add(lstSelectedRotors_1.SelectedItem);
			lstSelectedRotors_1.Items.Remove(lstSelectedRotors_1.SelectedItem);
		}

		//Поднять ротор
        private void btnUp_1_Click(object sender, EventArgs e)
        {
			if (lstSelectedRotors_1.SelectedIndex <= 0)
			{
				return;
			}

			string strTemp = "" + lstSelectedRotors_1.Items[lstSelectedRotors_1.SelectedIndex - 1];
			lstSelectedRotors_1.Items[lstSelectedRotors_1.SelectedIndex - 1] = lstSelectedRotors_1.SelectedItem;
			lstSelectedRotors_1.Items[lstSelectedRotors_1.SelectedIndex] = strTemp;
			lstSelectedRotors_1.SelectedIndex = lstSelectedRotors_1.SelectedIndex - 1;
		}

		//Опустить ротор
        private void btnDown_1_Click(object sender, EventArgs e)
        {
			if (lstSelectedRotors_1.SelectedIndex < 0 || lstSelectedRotors_1.SelectedIndex == lstSelectedRotors_1.Items.Count - 1)
			{
				return;
			}

			string strTemp = "" + lstSelectedRotors_1.Items[lstSelectedRotors_1.SelectedIndex + 1];
			lstSelectedRotors_1.Items[lstSelectedRotors_1.SelectedIndex + 1] = lstSelectedRotors_1.SelectedItem;
			lstSelectedRotors_1.Items[lstSelectedRotors_1.SelectedIndex] = strTemp;
			lstSelectedRotors_1.SelectedIndex = lstSelectedRotors_1.SelectedIndex + 1;
		}

		// Установка ротора
		private void lstSelectedRotors_1_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (lstSelectedRotors_1.SelectedIndex < 0)
			{
				return;
			}
			for (int i = 0; i < al1.Count; i++)
			{
				if (lstSelectedRotors_1.SelectedItem.ToString() == "" + al1_1[i])
				{
					lblRotorStructure_1.Text = "" + al2_1[i];
					return;
				}
			}
			lblRotorStructure_1.Text = "";
		}

#endregion

        //Вывод справки
        private void Settings_KeyUp(object sender, KeyEventArgs e)
        {

			if (e.KeyCode == Keys.F1)
			{
				System.Diagnostics.Process.Start(@"help.chm");
			}

		}
		//Изменение темы
        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
			//Проверка на нажатие
			if (themeToggle.Checked)
			{
				ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
			}
			else
			{
				ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
			}
		}
		//Выбор и установка зеленого цвета
        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
			//Проверка на нажатие
			if (materialRadioButton1.Checked == true)
			{
				ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
			}
			else
			{
				ThemeManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			}
		}
		//Выбор и установка синего цвета
        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
			//Проверка на нажатие
			if (materialRadioButton2.Checked == true)
			{ 
				ThemeManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);

			}
			else
			{
				ThemeManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			}
		}
		//Выбор и установка оранжевого цвета
        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
			//Проверка на нажатие
			if (materialRadioButton3.Checked == true)
			{ 
				ThemeManager.ColorScheme = new ColorScheme(Primary.Amber700, Primary.Amber900, Primary.Amber500, Accent.Amber400, TextShade.WHITE);

			}
            else
            {
				ThemeManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
			}
		}

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
			this.mf.Show();
        }
    }
}
