using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Book.businessLogic;

namespace Book.winform
{
    public partial class addForm : Form
    {
        public Logic logic;
        int id;
        /// <summary>
        /// Создание формы для редактирования книги
        /// </summary>
        /// <param name="logic">Экземпляр логики</param>
        /// <param name="id">ID книги для редактирования</param>
        public addForm(Logic logic, int id)
        {
            InitializeComponent();
            this.logic = logic;
            this.id = id;
            var book = logic.GetBooks().Find(b => b.Id == id);
            if (book != null)
            {
                this.title.Text = book.Title;
                this.author.Text = book.Author;
                this.genre.Text = book.Genre;
                this.price.Text = book.Price.ToString();
            }

            save.Click += saveUpdate_Click;
        }

        /// <summary>
        /// Создание формы для добавления новой книги
        /// </summary>
        /// <param name="logic">Экземпляр логики</param>
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
