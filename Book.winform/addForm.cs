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
    public partial class addForm : Form
    {
        public Logic logic;
        int id;

        public addForm(Logic logic, int id)
        {
            InitializeComponent();
            this.logic = logic;
            this.id = id;
            var book = logic.GetBooks().Find(b => b.id == id);
            if (book != null)
            {
                this.title.Text = book.title;
                this.author.Text = book.author;
                this.genre.Text = book.genre;
                this.price.Text = book.price.ToString();
            }

            save.Click += saveUpdate_Click;
        }

        public addForm(Logic logic)
        {
            this.logic = logic;
            InitializeComponent();

            save.Click += saveAdd_Click;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAdd_Click(object sender, EventArgs e)
        {
            string t = title.Text;
            string a = author.Text;
            string g = genre.Text;
            int p = int.Parse(price.Text);
            logic.CreatBook(t, a, g, p);
            this.Close();
        }

        private void saveUpdate_Click(object sender, EventArgs e)
        {
            string t = title.Text;
            string a = author.Text;
            string g = genre.Text;
            int p = int.Parse(price.Text);
            logic.UpdateBook(id, t, a, g, p);
            this.Close();
        }
    }
}
