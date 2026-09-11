using Book.model;

Logic logic = new Logic();
logic.CreatBook("Война и мир", "Лев Толстой", "Роман", 500);
logic.CreatBook("Мизери", "Стивен Кинг", "Ужасы", 300);
logic.CreatBook("Преступление и наказание", "Федор Достоевский", "Роман", 400);
logic.CreatBook("Оно", "Стивен Кинг", "Ужасы", 800);
logic.CreatBook("Мастер и Маргарита", "Михаил Булгаков", "Роман", 600);


PrintMenu();
int choice = Convert.ToInt32(Console.ReadLine());
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
            int price = Convert.ToInt32(Console.ReadLine());
            logic.CreatBook(title, author, genre, price);
            Console.WriteLine("Книга добавлена!");
            break;
        case 2:
            foreach (var b in logic.GetBooks())
            {
                Console.WriteLine(b);
            }
            break;
        case 3:
            Console.Write("Введите ID книги для изменения: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите новое название книги: ");
            string newTitle = Console.ReadLine();
            Console.Write("Введите нового автора книги: ");
            string newAuthor = Console.ReadLine();
            Console.Write("Введите новый жанр книги: ");
            string newGenre = Console.ReadLine();
            Console.Write("Введите новую цену книги: ");
            int newPrice = Convert.ToInt32(Console.ReadLine());
            logic.UpdateBook(id, newTitle, newAuthor, newGenre, newPrice);
            Console.WriteLine("Книга изменена!");
            break;
        case 4:
            Console.Write("Введите ID книги для удаления: ");
            int delid = Convert.ToInt32(Console.ReadLine());
            logic.DeleteBook(delid);
            Console.WriteLine("Книга удалена!");
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

        default:
            Console.WriteLine("Неверный выбор. Попробуйте снова.");
            break;
    }
    PrintMenu();
    choice = Convert.ToInt32(Console.ReadLine());
}
static void PrintMenu()
{
    Console.WriteLine("------Меню------");
    Console.WriteLine("1. Добавить книгу");
    Console.WriteLine("2. Показать все книги");
    Console.WriteLine("3. Изменить книгу");
    Console.WriteLine("4. Удалить книгу");
    Console.WriteLine("5. Группировка по жанру");
    Console.WriteLine("6. Поиск по автору");
    Console.WriteLine("0. Выход");
    Console.Write("Ваш выбор: ");
}