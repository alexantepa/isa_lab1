using Book.model;

namespace Book.winform
{
    public partial class Form1 : Form
    {
        public Logic logic = new Logic();
        public int selected;

        public Form1()
        {
            InitializeComponent();
            FillData();
            ReloadGrid();

        }

        private void FillData()
        {
            logic.CreatBook("Война и мир", "Лев Толстой", "Роман", 500);
            logic.CreatBook("Мизери", "Стивен Кинг", "Ужасы", 300);
            logic.CreatBook("Преступление и наказание", "Федор Достоевский", "Роман", 400);
            logic.CreatBook("Оно", "Стивен Кинг", "Ужасы", 800);
            logic.CreatBook("Мастер и Маргарита", "Михаил Булгаков", "Роман", 600);
        }

        private void ReloadGrid()
        {
            listBooks.DataSource = null;
            listBooks.DataSource = logic.GetBooks();
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupeBut_Click(object sender, EventArgs e)
        {
            var groupedBooks = logic.GroupByGenre();
            List<object> listBooksss = new List<object>();
            foreach (var group in groupedBooks)
            {
                foreach (var book in group.Value)
                {
                    listBooksss.Add(book);
                }
            }
            MessageBox.Show(groupedBooks.Values.ToString());
            listBooks.DataSource = null;
            listBooks.DataSource = listBooksss;
        }

        private void listBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected = e.RowIndex;
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            addForm addForm = new addForm(logic);
            addForm.ShowDialog();
            ReloadGrid();
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
            var book = logic.GetBooks().Find(x => x.id == selected + 1);
            addForm addForm = new addForm(logic, selected + 1);
            addForm.ShowDialog();
            ReloadGrid();
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            logic.DeleteBook(selected + 1);
            ReloadGrid();
        }

        private void searchAuthorBut_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите автора или ничего для всех:");
            if (result == null || result.Length == 0) {
                ReloadGrid();
            }
            else
            {
                var authorBooks = logic.GetBooks().Where(x => x.author.ToLower().Contains(result.ToLower()));
                listBooks.DataSource = null;
                listBooks.DataSource = authorBooks.ToList();
            }
        }
    }
}
