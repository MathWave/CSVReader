using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVReader
{
    public partial class Change : Form
    {

        Table form; //ссылка на главную форму
        int num; //номер

        public Change(Table f, int n) //конструктор
        {
            InitializeComponent();
            form = f;
            num = n - 1;
            Dispanser d = form.dispansers[n - 1];
            fullname.Text = d.FullName;
            textBox2.Text = d.ShortName;
            textBox3.Text = d.location.AdmArea;
            textBox4.Text = d.location.District;
            textBox5.Text = d.PostalCode.ToString();
            textBox6.Text = d.Address;
            textBox7.Text = d.ChiefName;
            textBox8.Text = d.ChiefPosition;
            comboBox1.SelectedIndex = d.ChiefGender ? 0 : 1;
            textBox10.Text = d.ChiefPhone;
            textBox11.Text = d.PublicPhone;
            textBox12.Text = d.Fax;
            textBox13.Text = d.Email;
            comboBox2.SelectedIndex = d.CloseFlag ? 1 : 0;
            textBox15.Text = d.CloseReason;
            textBox16.Text = d.CloseDate;
            textBox17.Text = d.ReopenDate;
            textBox18.Text = d.WorkingHours;
            textBox19.Text = d.ClarificationOfWorkingHours;
            textBox20.Text = d.Specialization;
            textBox21.Text = d.BeneficialDrugPrescriptions;
            textBox22.Text = d.ExtraInfo;
            textBox23.Text = d.location.Coordinates.X.ToString();
            textBox24.Text = d.location.Coordinates.Y.ToString();
            textBox25.Text = d.GLOBALID.ToString();
            MinimumSize = Size;
        }

        private void button1_Click(object sender, EventArgs e) //отменить
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) //применить
        {
            if (fullname.Text == null || fullname.Text.Length == 0)
            {
                MessageBox.Show("Ошибка в FullName!", "Ошибка!");
                return;
            }
            string[] info = new string[]
            {
                "",
                fullname.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                comboBox1.Text,
                textBox10.Text,
                textBox11.Text,
                textBox12.Text,
                textBox13.Text,
                comboBox2.Text,
                textBox15.Text,
                textBox16.Text,
                textBox17.Text,
                textBox18.Text,
                textBox19.Text,
                textBox20.Text,
                textBox21.Text,
                textBox22.Text,
                textBox23.Text,
                textBox24.Text,
                textBox25.Text
            };
            if (!Filled)
            {
                MessageBox.Show("Обязательные поля для заполнения (выделены цветом):\nFullName\nPostalCode\nChiefName\nChiefGender\nCloseFlag\nPOINT_X\nPOINT_Y\nGLOBALID", "Ошибка!");
                return;
            }
            Dispanser d;
            try { d = new Dispanser(info); } catch { MessageBox.Show("Некорректно введены данные!", "Ошибка!"); return; }
            Dispanser res = form.dispansers[num];
            form.dispansers[num] = d;
            form.ShowOnGrid();
            Close();
        }

        bool Filled => //все поля заполнены
                fullname.Text.Length != 0 && textBox5.Text.Length != 0 &&
                textBox7.Text.Length != 0 && comboBox1.Text.Length != 0 && comboBox2.Text.Length != 0 &&
                textBox23.Text.Length != 0 && textBox24.Text.Length != 0 && textBox25.Text.Length != 0;
    }
}
