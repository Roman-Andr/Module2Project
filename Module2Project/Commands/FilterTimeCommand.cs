namespace Module2Project
{
    /// <summary>
    /// Команда фильтрации студентов по времени
    /// </summary>
    public class FilterTimeCommand : MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public override string Execute(List<Student> students)
        {
            List<Student> result3 = [];
            foreach (Student student in students)
            {
                if (student.Lifestyle.FreeTime > student.Academic.StudyTime &&
                    student.Academic.Absences <= 7)
                {
                    result3.Add(student);
                }
            }

            FileUtils.SaveToFile("Student-Time.csv", result3);
            return StudentUtils.Show(result3) +
                   $"Резальтат записан в Student-Time.csv{Environment.NewLine}";
        }
    }
}