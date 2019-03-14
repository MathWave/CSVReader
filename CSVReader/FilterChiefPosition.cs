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
    public partial class FilterChiefPosition : Form
    {

        Table form;

        public FilterChiefPosition(Table f)
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
            string pos = textBox1.Text;
            List<Dispanser> list = new List<Dispanser>();
            foreach (Dispanser d in form.dispansers)
                if (d.ChiefPosition.ToLower().Contains(pos.ToLower()))
                    list.Add(d);
            Close();
            form.dispansers = list;
            form.ShowOnGrid();
            form.button1.Visible = true;
            form.reserved = true;
        }
    }
}