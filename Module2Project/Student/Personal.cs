namespace Module2Project
{
    /// <summary>
    ///     Представляет личную информацию о студенте.
    /// </summary>
    public class Personal(
        string school,
        string sex,
        uint age,
        string address,
        string guardian
    )
    {
        /// <summary>
        ///     Школа, в которой учится студент.
        /// </summary>
        public string School { get; } = school;

        /// <summary>
        ///     Пол студента.
        /// </summary>
        public string Sex { get; } = sex;

        /// <summary>
        ///     Возраст студента.
        /// </summary>
        public uint Age { get; } = age;

        /// <summary>
        ///     Адрес проживания студента.
        /// </summary>
        public string Address { get; } = address;

        /// <summary>
        ///     Опекун студента.
        /// </summary>
        public string Guardian { get; } = guardian;

        /// <summary>
        ///     Создает копию текущего объекта Personal.
        /// </summary>
        /// <returns>Копия объекта Personal.</returns>
        public Personal Clone()
        {
            return new Personal(School, Sex, Age, Address, Guardian);
        }
    }
}