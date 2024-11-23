namespace Module2Project
{
    /// <summary>
    ///     Предоставляет методы для парсинга данных студентов.
    /// </summary>
    public static class StudentParser
    {
        /// <summary>
        ///     Парсит данные студентов из массива строк.
        ///     0 school,1 sex,2 age,3 address,4 famsize,5 Pstatus,6 Medu,7 Fedu,
        ///     8 Mjob,9 Fjob,10 reason,11 guardian,12 traveltime,13 studytime,
        ///     14 failures,15 schoolsup,16 famsup,17 paid,18 activities,19 nursery,
        ///     20 higher,21 internet,22 romantic,23 famrel,24 freetime,25 goout,26 Dalc,
        ///     27 Walc,28 health,29 absences,30 G1,31 G2,32 G3
        /// </summary>
        /// <param name="content">Массив строк с данными.</param>
        /// <returns>Выходной список студентов.</returns>
        public static List<Student> Parse(string[] content)
        {
            List<Student> result = [];

            for (int i = 1; i < content.Length; i++)
            {
                if (content[i] == string.Empty)
                {
                    continue;
                }

                string[] data = content[i].Split(",");
                result.Add(new Student(
                    new Personal(data[0],
                        data[1],
                        uint.Parse(data[2]),
                        data[3],
                        data[11]),
                    new Family(
                        data[4],
                        new Parent(data[6], data[8]),
                        new Parent(data[7], data[9]),
                        data[16],
                        data[5],
                        data[21],
                        uint.Parse(data[23])
                    ),
                    new Education(
                        data[10],
                        data[17],
                        data[15],
                        data[20]
                    ),
                    new Academic(
                        uint.Parse(data[12]),
                        uint.Parse(data[13]),
                        uint.Parse(data[14]),
                        uint.Parse(data[29]),
                        data[19]
                    ),
                    new Lifestyle(
                        uint.Parse(data[24]),
                        uint.Parse(data[25]),
                        data[18],
                        data[22]
                    ),
                    new Health(
                        uint.Parse(data[26]),
                        uint.Parse(data[27]),
                        uint.Parse(data[28])
                    ),
                    new Grades(
                        uint.Parse(data[30]),
                        uint.Parse(data[31]),
                        uint.Parse(data[32])
                    )
                ));
            }

            return result;
        }
    }
}