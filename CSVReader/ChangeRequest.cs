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
    public partial class ChangeRequest : Form
    {

        Table form; //ссылка на главную форму
        public ChangeRequest(Table f) //конструктор
        {
            InitializeComponent();
            form = f;
            MinimumSize = Size;
            MaximumSize = Size;
        }

        private void button1_Click(object sender, EventArgs e) //отменить
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e) //применить
        {
            int num;
            try
            {
                num = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Некорректный номер диспансера!", "Ошибка!");
                return;
            }
            if (num > form.dispansers.Count || num < 1)
            {
                MessageBox.Show("Дискпансера с таким номером нет!", "Ошибка!");
                return;
            }
            Close();
            Change f = new Change(form, num);
            f.Show();
        }
    }
}
