using Book.businessLogic;
using Book.BusinessLogic;
using Ninject;

namespace Book.winform
{
    public partial class Form1 : Form
    {
        public Logic logic;
        private readonly BusinessFunctionLogic busFunLogic;
        public Busket busket;
        public int selected;

        public Form1()
        {
            InitializeComponent();

            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
            logic = ninjectKernel.Get<Logic>();
            busFunLogic = ninjectKernel.Get<BusinessFunctionLogic>();
            busket = ninjectKernel.Get<Busket>();

            ReloadGrid();
        }

        private void ReloadGrid()
        {
            listBooks.DataSource = null;
            listBooks.DataSource = busFunLogic.GetSortedBooks();
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupeBut_Click(object sender, EventArgs e)
        {
            var groupedBooks = busFunLogic.GroupByGenre();

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
                var authorBooks = busFunLogic.FindByAuthor(result);
                listBooks.DataSource = null;
                listBooks.DataSource = authorBooks.ToList();
            }
        }

        private void busketBut_Click(object sender, EventArgs e)
        {
            ResaultForm busketForm = new ResaultForm(busket);
            busketForm.ShowDialog();
        }

        private void clearBusketBut_Click(object sender, EventArgs e)
        {
            busket.Clear();
        }

        private void listBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            busket.Add(logic.GetBooks()[selected]);
            MessageBox.Show("Книга добавлена в корзину");
        }

        private void sortByPrise_Click(object sender, EventArgs e)
        {
            busFunLogic.SortByPrice();
            ReloadGrid();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
    }
}
