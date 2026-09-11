using Book.model;

Logic logic = new Logic();
logic.CreatBook("Война и мир", "Лев Толстой", "Роман", 500);
logic.CreatBook("Преступление и наказание", "Федор Достоевский", "Роман", 400);
logic.CreatBook("Мастер и Маргарита", "Михаил Булгаков", "Роман", 600);
logic.CreatBook("Оно", "Стивен Кинг", "Ужасы", 800);
logic.CreatBook("Мизери", "Стивен Кинг", "Ужасы", 300);

foreach (var book in logic.GetBooks())
{
    Console.WriteLine(book);
}
void PrintMenu()
{
    Console.WriteLine("Меню");
    Console.WriteLine("1. Добавить книгу");
    Console.WriteLine("2. Показать все книги");
    Console.WriteLine("3. Изменить книгу");
    Console.WriteLine("4. Удалить книгу");
    Console.WriteLine("5. Поиск по автору");//ghxfhxfhgfhgx
    Console.WriteLine("6. Поиск по диапазону цен");//hzhhfhfhhfgxghfhxgf
    Console.WriteLine("0. Выход");
    Console.Write("Ваш выбор: ");
}