using System;
public class AccessControl
{
    public enum AccessLevel
    {
        Guest,
        User,
        Moderator,
        Admin
    }
    public static bool CanPerformAction(AccessLevel userLevel, string action)
    {
        switch (action)
        {
            case "Read":
                return true; // Все могут читать
            case "Comment":
                return userLevel >= AccessLevel.User; // Пользователь, Модератор, Админ
            case "DeletePost":
                return userLevel >= AccessLevel.Moderator; // Модератор, Админ
            case "Administer":
                return userLevel == AccessLevel.Admin; // Только Админ
            default:
                Console.WriteLine("Неизвестное действие.");
                return false;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            AccessLevel currentUserLevel = AccessLevel.User; // Пример: текущий уровень доступа пользователя

            Console.WriteLine($"Текущий уровень доступа: {currentUserLevel}");

            // Проверяем различные действия
            if (CanPerformAction(currentUserLevel, "Read"))
            {
                Console.WriteLine("Разрешено: Чтение контента.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав для чтения контента!");
            }

            if (CanPerformAction(currentUserLevel, "Comment"))
            {
                Console.WriteLine("Разрешено: Оставлять комментарии.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав для оставления комментариев!");
            }

            if (CanPerformAction(currentUserLevel, "DeletePost"))
            {
                Console.WriteLine("Разрешено: Удалять посты.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав для удаления постов!");
            }

            if (CanPerformAction(currentUserLevel, "Administer"))
            {
                Console.WriteLine("Разрешено: Администрирование системы.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно прав для администрирования системы!");
            }
        }
    }
}
