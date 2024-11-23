namespace Module2Project
{
    /// <summary>
    ///     Представляет информацию об образовании студента.
    /// </summary>
    public class Education(
        string reason,
        string paid,
        string schoolSupport,
        string higherEducation
    )
    {
        /// <summary>
        ///     Причина выбора данного учебного заведения.
        /// </summary>
        public string Reason { get; } = reason;

        /// <summary>
        ///     Информация о том, оплачивается ли обучение.
        /// </summary>
        public string Paid { get; } = paid;

        /// <summary>
        ///     Информация о поддержке со стороны школы.
        /// </summary>
        public string SchoolSupport { get; } = schoolSupport;

        /// <summary>
        ///     Информация о намерении продолжить образование на более высоком уровне.
        /// </summary>
        public string HigherEducation { get; } = higherEducation;


        /// <summary>
        ///     Создает копию текущего объекта Education.
        /// </summary>
        /// <returns>Копия объекта Education.</returns>
        public Education Clone()
        {
            return new Education(Reason, Paid, SchoolSupport, HigherEducation);
        }
    }
}