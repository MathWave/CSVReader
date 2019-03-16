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
    public partial class AmountRequest : Form
    {

        Table form; //ссылка на главную форму

        public AmountRequest(Table f) //конструктор
        {
            InitializeComponent();
            form = f;
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
                MessageBox.Show("Некорректные данные!", "Ошибка!");
                return;
            }
            if (num > form.dispansers.Count || num < 0)
            {
                MessageBox.Show($"Некорректное число!\nДопустимые значения: от 0 до {form.dispansers.Count}", "Ошибка!");
                return;
            }
            Close();
            List<Dispanser> newlist = new List<Dispanser>();
            for (int i = 0; i < num; i++)
                newlist.Add(form.dispansers[i]);
            form.dispansers = newlist;
            Close();
            form.ShowOnGrid();
        }
    }
}
