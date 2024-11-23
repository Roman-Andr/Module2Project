namespace Module2Project
{
    /// <summary>
    ///     Представляет информацию об образе жизни студента.
    /// </summary>
    public class Lifestyle(
        uint freeTime,
        uint goOut,
        string activities,
        string romanticRelationship
    )
    {
        /// <summary>
        ///     Количество свободного времени.
        /// </summary>
        public uint FreeTime { get; } = freeTime;

        /// <summary>
        ///     Частота выхода из дома.
        /// </summary>
        public uint GoOut { get; } = goOut;

        /// <summary>
        ///     Виды досуга и занятий.
        /// </summary>
        public string Activities { get; } = activities;

        /// <summary>
        ///     Информация о романтических отношениях.
        /// </summary>
        public string RomanticRelationship { get; } = romanticRelationship;

        /// <summary>
        ///     Создает копию текущего объекта Lifestyle.
        /// </summary>
        /// <returns>Копия объекта Lifestyle.</returns>
        public Lifestyle Clone()
        {
            return new Lifestyle(FreeTime, GoOut, Activities, RomanticRelationship);
        }
    }
}