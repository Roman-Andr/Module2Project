namespace Module2Project
{
    /// <summary>
    ///     Представляет оценки студента.
    /// </summary>
    public class Grades(
        uint g1,
        uint g2,
        uint g3
    )
    {
        /// <summary>
        ///     Оценка за первый период.
        /// </summary>
        public uint G1 { get; } = g1;

        /// <summary>
        ///     Оценка за второй период.
        /// </summary>
        public uint G2 { get; } = g2;

        /// <summary>
        ///     Оценка за третий период.
        /// </summary>
        public uint G3 { get; } = g3;

        /// <summary>
        ///     Получает среднее значение оценок.
        /// </summary>
        public double Average => (G1 + G2 + G3) / 3.0;

        /// <summary>
        ///     Создает копию текущего объекта Grades.
        /// </summary>
        /// <returns>Копия объекта Grades.</returns>
        public Grades Clone()
        {
            return new Grades(G1, G2, G3);
        }
    }
}