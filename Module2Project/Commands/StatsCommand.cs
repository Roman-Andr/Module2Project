namespace Module2Project
{
    /// <summary>
    /// Команда получения статистики
    /// </summary>
    public class StatsCommand : MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public override string Execute(List<Student> students)
        {
            string result = $"Статистика по данным загруженного файла{Environment.NewLine}";
            result += $"Общее количество данных: {students.Count}{Environment.NewLine}";

            result += "Статистика по столбцу reason:";
            Dictionary<string, List<Student>> data = StudentUtils.GroupByReason(students);
            foreach (KeyValuePair<string, List<Student>> pair in data)
            {
                result += $"{pair.Key}={pair.Value.Count};";
            }

            double manAge = 0;
            double manCount = 0;
            double womanAge = 0;
            double womanCount = 0;
            foreach (Student student in students)
            {
                if (student.Personal.Sex == "M")
                {
                    manAge += student.Personal.Age;
                    manCount++;
                }
                else
                {
                    womanAge += student.Personal.Age;
                    womanCount++;
                }
            }

            result += Environment.NewLine;

            result += $"Средний возраст юношей: {(manCount != 0 ? manAge / manCount : 0):F2}" +
                      $"{Environment.NewLine}";
            result += $"Средний возраст девушек: {(womanCount != 0 ? womanAge / womanCount : 0):F2}" +
                      $"{Environment.NewLine}";

            result += Environment.NewLine;
            return result;
        }
    }
}