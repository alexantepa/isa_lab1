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

        private void listBooks_SelectionChanged(object? sender, EventArgs e)
        {
            if (listBooks.CurrentRow?.DataBoundItem is not Book.model.Book book) return;

            selected = book.id;
            MessageBox.Show(selected.ToString());
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupeBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selected.ToString());
        }
    }
}
