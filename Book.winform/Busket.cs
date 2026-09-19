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
    public partial class busket : Form
    {
        public busket(Logic items)
        {
            InitializeComponent();
            busketItems.Text = items.books.Count.ToString();
        }


    }
}
