using Book.businessLogic;
using DataAccessLayer;

// IRepository<Book.model.Book> repository = new EntityRepository<Book.model.Book>(new AppDbContext());
IRepository<Book.model.Book> repository = new DapperRepository<Book.model.Book>("Data Source=books_dapper.db");

Logic logic = new Logic(repository);
logic.CreatBook("Война и мир", "Лев Толстой", "Роман", 500);
logic.CreatBook("Мизери", "Стивен Кинг", "Ужасы", 300);
logic.CreatBook("Преступление и наказание", "Федор Достоевский", "Роман", 400);
logic.CreatBook("Оно", "Стивен Кинг", "Ужасы", 800);
logic.CreatBook("Мастер и Маргарита", "Михаил Булгаков", "Роман", 600);


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
            Console.Write("Введите новое название книги: ");
            string newTitle = Console.ReadLine();
            Console.Write("Введите нового автора книги: ");
            string newAuthor = Console.ReadLine();
            Console.Write("Введите новый жанр книги: ");
            string newGenre = Console.ReadLine();
            Console.Write("Введите новую цену книги: ");
            string newPrice = Console.ReadLine();
            if (int.TryParse(newPrice, out int n))
                logic.UpdateBook(id, newTitle, newAuthor, newGenre, int.Parse(newPrice));
            Console.WriteLine("Книга изменена!");
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
            var groupedBooks = logic.GroupByGenre();
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
            foreach (var book in logic.FindByAuthor(searchAu))
            {
                Console.WriteLine(book);
            }
            break;
        case 7:
            logic.SortByPrice();
            foreach (var b in logic.GetBooks())
            {
                Console.WriteLine(b);
            }
            break;
        case 8:
            Console.WriteLine("Введите ID книги, которую хотите добавить");
            int idtoBus = int.Parse(Console.ReadLine());
            logic.AddToBusket(idtoBus);
            break; 
        case 9:
            logic.ClearBusket();
            break;
        case 10:
            int sum = 0;
            foreach(var item in logic.busket)
            {
                sum += item.Price;
                Console.WriteLine($"{item.Title} - {item.Author}. Цена: {item.Price} рублей.\n");
            }
            Console.WriteLine($"Итог: {sum}");
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