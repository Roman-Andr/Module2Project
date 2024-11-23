namespace Module2Project
{
    /// <summary>
    /// Команда сортировки по времени обучения
    /// </summary>
    public class SortStudyTimeCommand : MenuCommand
    {
        /// <summary>
        /// Метод выполнения команды
        /// </summary>
        /// <param name="students">Студенты на вход</param>
        /// <returns>Ответ на запрос</returns>
        public override string Execute(List<Student> students)
        {
            List<Student> temp = StudentUtils.Copy(students);
            StudentUtils.SortStudent(temp, (student1, student2) => student1.Academic.StudyTime < student2.Academic.StudyTime);
            FileUtils.SaveToFile("sort-students.csv", temp);
            return StudentUtils.Show(temp) + $"Результат записан в sort-students.csv{Environment.NewLine}";
        }
    }
}