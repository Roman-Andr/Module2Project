namespace Module2Project
{
    /// <summary>
    ///     Предоставляет утилиты для работы с данными студентов.
    /// </summary>
    public static class StudentUtils
    {
        /// <summary>
        ///     Загружает данные студентов из файла.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        /// <param name="fileName">Имя файла.</param>
        public static void Load(List<Student> students, string fileName)
        {
            students.Clear();
            foreach (Student student in StudentParser.Parse(FileUtils.ReadData(fileName)))
            {
                students.Add(student);
            }
        }

        /// <summary>
        ///     Сортирует список студентов по заданному критерию.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        /// <param name="sortFunc">Функция, определяющая критерий сортировки.</param>
        public static void SortStudent(List<Student> students, Func<Student, Student, bool> sortFunc)
        {
            int n = students.Count;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortFunc(students[j], students[j + 1]))
                    {
                        (students[j], students[j + 1]) = (students[j + 1], students[j]);
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        /// <summary>
        ///     Возвращает строковое представление списка студентов.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        /// <returns>Строковое представление списка студентов.</returns>
        public static string Show(List<Student> students)
        {
            return $"{string.Join(Environment.NewLine, students)}{Environment.NewLine}";
        }

        /// <summary>
        ///     Группирует студентов по причине поступления.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        /// <returns>Словарь с группами студентов.</returns>
        public static Dictionary<string, List<Student>> GroupByReason(List<Student> students)
        {
            Dictionary<string, List<Student>> data = new();
            foreach (Student student in students)
            {
                data.TryAdd(student.Education.Reason, []);
                data[student.Education.Reason].Add(student);
            }

            return data;
        }

        /// <summary>
        ///     Создает копию списка студентов.
        /// </summary>
        /// <param name="original">Исходный список студентов.</param>
        /// <returns>Копия списка студентов.</returns>
        public static List<Student> Copy(List<Student> original)
        {
            List<Student> copy = [];

            foreach (Student student in original)
            {
                copy.Add(student.Clone());
            }

            return copy;
        }
    }
}