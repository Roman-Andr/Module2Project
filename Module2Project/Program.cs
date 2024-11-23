/*
 * Андрусевич Роман Дмитриевич
 * БПИ244 подгруппа 1
 * Вариант 4
 */

namespace Module2Project
{
    /// <summary>
    ///     Главный класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        ///     Список студентов
        /// </summary>
        private static readonly List<Student> Students = [];

        /// <summary>
        ///     Точка входа в программу.
        /// </summary>
        public static void Main()
        {
            string menuKey, response = "";
            do
            {
                MenuManager.Show(response);
                menuKey = Console.ReadLine()!;
                response = MenuManager.Process(Students, menuKey);
            } while (menuKey != MenuManager.Exit);
        }
    }
}