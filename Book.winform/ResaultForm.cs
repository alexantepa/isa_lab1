using Book.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book.winform
{
    public partial class ResaultForm : Form
    {
        public ResaultForm(int sum, List<string> items)
        {
            InitializeComponent();
            busketItems.Text = string.Join("\n", items) + "\n\n\n";
            busketItems.Text += $"Итог: {sum} рублей";
        }

        public ResaultForm(string s)
        {
            InitializeComponent();
            busketItems.Text = s.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
