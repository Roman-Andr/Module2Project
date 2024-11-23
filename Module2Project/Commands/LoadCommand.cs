namespace Module2Project
{
    /// <summary>
    /// Команда загрузки данных
    /// </summary>
    public class LoadCommand(): MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public override string Execute(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Введите имя файла: ");
            string fileName = Console.ReadLine()!;
            StudentUtils.Load(students, fileName);
            MenuManager.DataLoaded = true;
            return $"Данные из файла {(string.IsNullOrEmpty(fileName) ? "student_data.csv" : fileName)} успешно загружены. Студентов загружено: {students.Count}";
        }
    }
}