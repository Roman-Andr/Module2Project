namespace Module2Project
{
    /// <summary>
    ///     Предоставляет утилиты для работы с файлами.
    /// </summary>
    public static class FileUtils
    {
        /// <summary>
        ///     Первая строка в файле
        /// </summary>
        private const string Structure =
            "school,sex,age,address,famsize,Pstatus,Medu,Fedu,Mjob,Fjob,reason,guardian,traveltime,studytime,failures,schoolsup,famsup,paid,activities,nursery,higher,internet,romantic,famrel,freetime,goout,Dalc,Walc,health,absences,G1,G2,G3";

        /// <summary>
        ///     Записывает данные студентов в файл.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <param name="studentsArray">Массив списков студентов.</param>
        public static void SaveToFile(string fileName, params List<Student>[] studentsArray)
        {
            List<string> data = [Structure];
            foreach (List<Student> students in studentsArray)
            {
                for (int i = 1; i <= students.Count; i++)
                {
                    data.Add(students[i - 1].ToString());
                }
            }

            File.WriteAllLines(GetFilePath(fileName), data);
        }

        /// <summary>
        ///     Получает полный путь к файлу на уровне solution.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        /// <returns>Полный путь к файлу.</returns>
        private static string GetFilePath(string fileName)
        {
            return Path.Combine(Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.Parent!.FullName,
                fileName);
        }

        /// <summary>
        ///     Читает данные из файла.
        /// </summary>
        /// <param name="fileName">Имя файла (по умолчанию "student_data.csv").</param>
        /// <returns>Массив строк с данными.</returns>
        public static string[] ReadData(string fileName = "student_data.csv")
        {
            return File.ReadAllLines(GetFilePath(string.IsNullOrEmpty(fileName) ? "student_data.csv" : fileName))[1..];
        }
    }
}