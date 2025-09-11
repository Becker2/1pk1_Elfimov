using System;

public class User
{
    // Статическое свойство для хранения текущего пользователя
    private static User _currentUser; // Приватное поле для хранения значения

    public static User CurrentUser
    {
        get { return _currentUser; }
        private set { _currentUser = value; } // Сделаем setter приватным
    }

    // Свойства экземпляра пользователя (для примера)
    public string Username { get; set; }
    public string Email { get; set; }

    // Конструктор
    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }

    // Метод для установки текущего пользователя
    public static void SetCurrentUser(User user)
    {
        CurrentUser = user;
        Console.WriteLine($"Текущий пользователь установлен: {user.Username}");
    }

    // Метод для вывода информации о текущем пользователе
    public static void PrintCurrentUser()
    {
        if (CurrentUser != null)
        {
            Console.WriteLine($"Текущий пользователь: {CurrentUser.Username}, Email: {CurrentUser.Email}");
        }
        else
        {
            Console.WriteLine("Текущий пользователь не установлен.");
        }
    }
}

public class UserExample
{
    public static void Main(string[] args)
    {
        // Создание пользователей
        User user1 = new User("JohnDoe", "john.doe@example.com");
        User user2 = new User("JaneSmith", "jane.smith@example.com");

        // Установка текущего пользователя
        User.SetCurrentUser(user1);
        User.PrintCurrentUser();

        // Смена текущего пользователя
        User.SetCurrentUser(user2);
        User.PrintCurrentUser();

        // Попытка установить CurrentUser напрямую (нельзя, так как setter приватный)
        // User.CurrentUser = user1; // Ошибка компиляции: "User.CurrentUser.set" недоступен из-за уровня защиты

        // Сброс текущего пользователя (можно, если добавить логику)
        User.SetCurrentUser(null); // Установим в null для сброса
        User.PrintCurrentUser();
    }
}
