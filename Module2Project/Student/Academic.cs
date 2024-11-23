namespace Module2Project
{
    /// <summary>
    ///     Представляет академическую информацию о студенте.
    /// </summary>
    public class Academic(
        uint travelTime,
        uint studyTime,
        uint failures,
        uint absences,
        string nursery
    )
    {
        public uint TravelTime { get; } = travelTime;
        public uint StudyTime { get; } = studyTime;
        public uint Failures { get; } = failures;
        public uint Absences { get; } = absences;
        public string Nursery { get; } = nursery;

        /// <summary>
        ///     Создает копию текущего объекта Academic.
        /// </summary>
        /// <returns>Копия объекта Academic.</returns>
        public Academic Clone()
        {
            return new Academic(TravelTime, StudyTime, Failures, Absences, Nursery);
        }
    }
}