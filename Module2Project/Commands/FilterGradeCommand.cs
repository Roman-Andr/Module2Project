namespace Module2Project
{
    /// <summary>
    /// Команда фильтрации студентов по оценкам
    /// </summary>
    public class FilterGradeCommand : MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public override string Execute(List<Student> students)
        {
            List<Student> result2 = [];
            foreach (Student student in students)
            {
                if (student.Grades.Average > 11)
                {
                    result2.Add(student);
                }
            }

            FileUtils.SaveToFile("Student-Grades.csv", result2);
            return $"Список студентов:{Environment.NewLine}{StudentUtils.Show(result2)}" +
                   $"Результат записан в Student-Grades.csv{Environment.NewLine}";
        }
    }
}