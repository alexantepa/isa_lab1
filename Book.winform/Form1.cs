using Book.model;

namespace Book.winform
{
    public partial class Form1 : Form
    {
        public Logic logic = new Logic();
        private List<string> busket = new List<string>();
        private int sum = 0;
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

            //var newList = groupedBooks
            //    .SelectMany(groupe => groupe.Value)
            //    .ToList();

            //listBooks.DataSource = null;
            //listBooks.DataSource = newList;

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
            ResaultForm busketForm = new ResaultForm(sum, busket);
            busketForm.ShowDialog();
        }

        private void clearBusketBut_Click(object sender, EventArgs e)
        {
            sum = 0;
            busket.Clear();
        }

        private void listBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            sum += logic.GetBooks()[selected].Price;
            busket.Add($"{logic.GetBooks()[selected].Title} - {logic.GetBooks()[selected].Author}." + 
                $" Цена: {logic.GetBooks()[selected].Price}");
        }
    }
}
