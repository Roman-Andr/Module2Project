namespace Module2Project
{
    /// <summary>
    ///     Управляет меню и обработкой команд.
    /// </summary>
    public static class MenuManager
    {
        /// <summary>
        ///     Номер пункта выхода из программы
        /// </summary>
        public const string Exit = "5";
        /// <summary>
        ///     Флаг загрузки данных
        /// </summary>
        public static bool DataLoaded;
        /// <summary>
        ///     Словарь команд
        /// </summary>
        private static readonly Dictionary<string, MenuCommand> Commands = new()
        {
            { "1", new LoadCommand() },
            { "2", new FilterGradeCommand() },
            { "3", new FilterTimeCommand() },
            { "4", new StatsCommand() },
            { "5", new ExitCommand() },
            { "6", new SortStudyTimeCommand() },
            { "7", new GroupByAbsencesCommand() }
        };

        /// <summary>
        ///     Отображает меню и ответ на экран.
        /// </summary>
        /// <param name="response">Ответ для отображения.</param>
        public static void Show(string response)
        {
            Console.Clear();
            if (!string.IsNullOrEmpty(response))
            {
                Console.WriteLine(response);
            }

            Console.WriteLine(DataLoaded ? "1. Сменить данные из файла" : "1. Загрузить данные из файла");
            Console.WriteLine("2. Выборка по средней оценке");
            Console.WriteLine("3. Выборка по freetime и studytime");
            Console.WriteLine("4. Общая статистика файла");
            Console.WriteLine("5. Завершить работу программы");
            Console.WriteLine("6. Набор данных по убыванию времени");
            Console.WriteLine("7. Сгруппировать по причине поступления");
        }

        /// <summary>
        ///     Обрабатывает выбранный пункт меню.
        /// </summary>
        /// <param name="students">Список студентов.</param>
        /// <param name="key">Выбранный пункт меню.</param>
        /// <returns>Ответ на выбранный пункт меню.</returns>
        public static string Process(List<Student> students, string key)
        {
            if (!Commands.ContainsKey(key))
            {
                return "Некорректный пункт";
            }
            if (key != "1" && key != "5" && students.Count == 0)
            {
                return "Список студентов пуст. Загрузите данные из файла.";
            }

            try
            {
                return Commands[key].Execute(students);
            }
            catch (Exception e)
            {
                return HandleException(e, key);
            }
        }

        /// <summary>
        ///     Обрабатывает исключения, возникшие при выполнении команды.
        /// </summary>
        /// <param name="e">Исключение.</param>
        /// <param name="key">Выбранный пункт меню.</param>
        /// <returns>Сообщение об ошибке.</returns>
        private static string HandleException(Exception e, string key)
        {
            return key switch
            {
                "1" => e switch
                {
                    FileNotFoundException => "Ошибка: Файл не найден.",
                    NullReferenceException => "Ошибка: Неверный формат данных",
                    UnauthorizedAccessException => "Ошибка с записью данных в файл",
                    IOException => "Ошибка с открытием файла",
                    _ => "Ошибка при загрузке файла."
                },
                "2" => "Ошибка при формировании выборки.",
                "3" => "Ошибка при формировании выборки.",
                "4" => "Ошибка при выводе статистики.",
                "6" => "Ошибка при сортировке студентов.",
                "7" => e is InvalidDataException
                    ? "Ошибка: Некорректное имя файла"
                    : "Ошибка при группировке студентов.",
                _ => "Ошибка при обработке запроса."
            };
        }
    }
}