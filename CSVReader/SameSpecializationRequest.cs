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
    public partial class SameSpecializationRequest : Form
    {

        Table form; //ссылка на главную форму

        public SameSpecializationRequest(Table f) //конструтор
        {
            InitializeComponent();
            form = f;
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
            List<Dispanser> list = new List<Dispanser>();
            foreach (Dispanser d in form.dispansers)
                if (form.dispansers[num - 1].Same(d))
                    list.Add(d);
            form.dispansers = list;
            form.ShowOnGrid();
            form.button1.Visible = true;
            form.reserved = true;
            form.DispanserToolStrip.Enabled = false;
        }
    }
}
