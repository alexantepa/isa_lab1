using Book.businessLogic;
using Book.BusinessLogic;
using DataAccessLayer;
using Ninject;
using Ninject.Selection;

using var ninjectKernel = new StandardKernel(new SimpleConfigModule());

Logic logic = ninjectKernel.Get<Logic>();
BusinessFunctionLogic busFunLogic = ninjectKernel.Get<BusinessFunctionLogic>();
Busket busket = ninjectKernel.Get<Busket>();

PrintMenu();
int choice = int.Parse(Console.ReadLine());
while (choice != 0)
{
    switch (choice)
    {
        case 1:
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();
            Console.Write("Введите автора книги: ");
            string author = Console.ReadLine();
            Console.Write("Введите жанр книги: ");
            string genre = Console.ReadLine();
            Console.Write("Введите цену книги: ");
            string price = Console.ReadLine();
            if (int.TryParse(price, out int num))
            {
                logic.CreatBook(title, author, genre, int.Parse(price));
                Console.WriteLine("Книга добавлена!");
            }
            else
            {
                Console.WriteLine("\nВведено неверное значение");
            }
            break;
        case 2:
            foreach (var b in logic.GetBooks())
            {
                Console.WriteLine(b);
            }
            break;
        case 3:
            Console.Write("Введите ID книги для изменения: ");
            int id = int.Parse(Console.ReadLine());
            if (logic.GetBooks()[id] != null)
            {
                Console.Write("Введите новое название книги: ");
                string newTitle = Console.ReadLine();
                Console.Write("Введите нового автора книги: ");
                string newAuthor = Console.ReadLine();
                Console.Write("Введите новый жанр книги: ");
                string newGenre = Console.ReadLine();
                Console.Write("Введите новую цену книги: ");
                string newPrice = Console.ReadLine();
                if (int.TryParse(newPrice, out int n))
                {
                    logic.UpdateBook(id, newTitle, newAuthor, newGenre, int.Parse(newPrice));
                    Console.WriteLine("Книга изменена!");
                }
            }
            else Console.WriteLine("Такой книги нет");
            break;
        case 4:
            Console.Write("Введите ID книги для удаления: ");
            string delid = Console.ReadLine();
            if (int.TryParse(delid, out int nu))
            {
                logic.DeleteBook(int.Parse(delid));
                Console.WriteLine("Книга удалена!");
            }
            else
            {
                Console.WriteLine("Введено некоректное значение");
            }
            break;
        case 5:
            var groupedBooks = busFunLogic.GroupByGenre();
            foreach (var group in groupedBooks)
            {
                Console.WriteLine($"Жанр: {group.Key}");
                foreach (var book in group.Value)
                {
                    Console.WriteLine(book);
                }
            }
            break;
        case 6:
            Console.Write("Введите автора: ");
            string searchAu = Console.ReadLine();
            foreach (var book in busFunLogic.FindByAuthor(searchAu))
            {
                Console.WriteLine(book);
            }
            break;
        case 7:
            busFunLogic.SortByPrice();
            foreach (var b in busFunLogic.GetSortedBooks())
            {
                Console.WriteLine(b);
            }
            break;
        case 8:
            Console.WriteLine("Введите ID книги, которую хотите добавить");
            int idtoBus = int.Parse(Console.ReadLine());
            if (logic.GetBooks()[idtoBus] != null)
            {
                busket.Add(logic.GetBooks()[idtoBus]);
                Console.WriteLine("Книга успешно добавлена");
            }
            break; 
        case 9:
            busket.Clear();
            Console.WriteLine("Корзина отчищена");
            break;
        case 10:
            foreach(var item in busket.GetBusket())
            {
                Console.WriteLine($"{item.Title} - {item.Author}. Цена: {item.Price} рублей.\n");
            }
            Console.WriteLine($"Итог: {busket.GetSum()}");
            break;
        default:
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            break;
    }
    Console.ReadKey();
    PrintMenu();
    choice = int.Parse(Console.ReadLine());
}
static void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("------Меню------");
    Console.WriteLine("1. Добавить книгу");
    Console.WriteLine("2. Показать все книги");
    Console.WriteLine("3. Изменить книгу");
    Console.WriteLine("4. Удалить книгу");
    Console.WriteLine("5. Группировка по жанру");
    Console.WriteLine("6. Поиск по автору");
    Console.WriteLine("7. Соротировка по цене");
    Console.WriteLine("8. Добавить в корзину");
    Console.WriteLine("9. Очистить корзину");
    Console.WriteLine("10. Посмотреть корзину");

    Console.WriteLine("0. Выход");
    Console.Write("Ваш выбор: ");
}