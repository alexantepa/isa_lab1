using Book.businessLogic;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace Book.winform
{
    public partial class Form1 : Form
    {
        public Logic logic;

        private AppDbContext? context;
        private int sum = 0;
        public int selected;

        public Form1()
        {
            InitializeComponent();

            context = new AppDbContext();
            IRepository<Book.model.Book> repository = new EntityRepository<Book.model.Book>(context);
            //IRepository<Book.model.Book> repository = new DapperRepository<Book.model.Book>("Data Source=books.db");

            logic = new Logic(repository);

            //FillData();
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

            var lines = groupedBooks.Select(g => $"{g.Key} ({g.Value.Count} шт.):\r\n" +
                string.Join("\r\n", g.Value.Select(c => "   " + c.ToString())));
            var text = string.Join("\r\n", lines);

            new ResaultForm(text).ShowDialog();
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
            addForm addForm = new addForm(logic, logic.GetBooks()[selected].Id);
            addForm.ShowDialog();
            ReloadGrid();
        }

        private void deleteBut_Click(object sender, EventArgs e)
        {
            logic.DeleteBook(logic.GetBooks()[selected].Id);
            ReloadGrid();
        }

        private void searchAuthorBut_Click(object sender, EventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите автора или ничего для всех:");
            if (result == null || result.Length == 0)
            {
                ReloadGrid();
            }
            else
            {
                var authorBooks = logic.FindByAuthor(result);
                listBooks.DataSource = null;
                listBooks.DataSource = authorBooks.ToList();
            }
        }

        private void busketBut_Click(object sender, EventArgs e)
        {
            ResaultForm busketForm = new ResaultForm(logic);
            busketForm.ShowDialog();
        }

        private void clearBusketBut_Click(object sender, EventArgs e)
        {
            logic.ClearBusket();
        }

        private void listBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            logic.AddToBusket(logic.GetBooks()[selected].Id);
            MessageBox.Show("Книга добавлена в корзину");
        }

        private void sortByPrise_Click(object sender, EventArgs e)
        {
            logic.SortByPrice();
            ReloadGrid();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            logic.Dispose();
            context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
