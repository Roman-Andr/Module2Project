namespace Module2Project
{
    /// <summary>
    ///     Представляет информацию о родителе.
    /// </summary>
    public class Parent(string edu, string job)
    {
        /// <summary>
        ///     Образование родителя.
        /// </summary>
        public string Edu { get; } = edu;

        /// <summary>
        ///     Работа родителя.
        /// </summary>
        public string Job { get; } = job;

        /// <summary>
        ///     Создает копию текущего объекта Parent.
        /// </summary>
        /// <returns>Копия объекта Parent.</returns>
        public Parent Clone()
        {
            return new Parent(Edu, Job);
        }
    }
}