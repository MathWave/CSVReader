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
    public partial class Add : Form
    {

        Table f;
        public Add(Table sender)
        {
            InitializeComponent();
            f = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            f.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
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
            f.dispansers.Add(d);
            f.ShowOnGrid();
            Close();
        }

        bool Filled =>
                fullname.Text.Length != 0 && textBox5.Text.Length != 0 &&
                textBox7.Text.Length != 0 && comboBox1.Text.Length != 0 && comboBox2.Text.Length != 0 &&
                textBox23.Text.Length != 0 && textBox24.Text.Length != 0 && textBox25.Text.Length != 0;

    }
}
