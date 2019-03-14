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
    public partial class FilterSpecialization : Form
    {

        Table form;

        public FilterSpecialization(Table f)
        {
            InitializeComponent();
            form = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string subs = textBox1.Text;
            List<Dispanser> list = new List<Dispanser>();
            foreach (Dispanser d in form.dispansers)
                if (d.Specialization.ToLower().Contains(subs.ToLower()))
                    list.Add(d);
            Close();
            form.dispansers = list;
            form.ShowOnGrid();
            form.button1.Visible = true;
            form.reserved = true;
        }

    }
}
