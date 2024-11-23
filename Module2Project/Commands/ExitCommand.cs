namespace Module2Project
{
    /// <summary>
    /// Команда выхода из меню
    /// </summary>
    public class ExitCommand : MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public override string Execute(List<Student> students)
        {
            Console.WriteLine("Выход из программы...");
            return "";
        }
    }
}