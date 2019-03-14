﻿using System;
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

        Table form;
        public ChangeRequest(Table f)
        {
            InitializeComponent();
            form = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Deactivate(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
