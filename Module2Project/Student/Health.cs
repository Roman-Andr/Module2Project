namespace Module2Project
{
    /// <summary>
    ///     Представляет информацию о здоровье студента.
    /// </summary>
    public class Health(
        uint workdayAlcohol,
        uint weekendAlcohol,
        uint healthStatus
    )
    {
        /// <summary>
        ///     Употребление алкоголя в будние дни.
        /// </summary>
        public uint WorkdayAlcohol { get; } = workdayAlcohol;

        /// <summary>
        ///     Употребление алкоголя в выходные дни.
        /// </summary>
        public uint WeekendAlcohol { get; } = weekendAlcohol;

        /// <summary>
        ///     Общее состояние здоровья.
        /// </summary>
        public uint HealthStatus { get; } = healthStatus;

        /// <summary>
        ///     Создает копию текущего объекта Health.
        /// </summary>
        /// <returns>Копия объекта Health.</returns>
        public Health Clone()
        {
            return new Health(WorkdayAlcohol, WeekendAlcohol, HealthStatus);
        }
    }
}