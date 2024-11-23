namespace Module2Project
{
    /// <summary>
    /// Абстрактный класс команды меню
    /// </summary>
    public abstract class MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public abstract string Execute(List<Student> students);
    }
}