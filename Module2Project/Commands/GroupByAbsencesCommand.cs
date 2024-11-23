namespace Module2Project
{
    /// <summary>
    /// Команда группировки студентов по цели поступления
    /// </summary>
    public class GroupByAbsencesCommand : MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public override string Execute(List<Student> students)
        {
            string result = "";
            Dictionary<string, List<Student>> groups = StudentUtils.GroupByReason(students);
            foreach (KeyValuePair<string, List<Student>> pair in groups)
            {
                StudentUtils.SortStudent(pair.Value, (student1, student2) => student1.Academic.Absences > student2.Academic.Absences);
                result += $"Группа: {pair.Key}{Environment.NewLine}{Environment.NewLine}";
                result += $"{StudentUtils.Show(pair.Value)}{Environment.NewLine}{Environment.NewLine}";
            }

            Console.WriteLine("Введите имя файла для сохранения: ");
            string response = Console.ReadLine()!;
            if (string.IsNullOrEmpty(response))
            {
                throw new InvalidDataException();
            }

            FileUtils.SaveToFile(response + ".csv", groups.Values.ToArray());
            return $"{result}Результат записан в {response + ".csv"}{Environment.NewLine}";
        }
    }
}