namespace Module2Project
{
    /// <summary>
    ///     Представляет информацию о студенте.
    /// </summary>
    public class Student(
        Personal personal,
        Family family,
        Education education,
        Academic academic,
        Lifestyle lifestyle,
        Health health,
        Grades grades
    )
    {
        /// <summary>
        ///     Личная информация о студенте.
        /// </summary>
        public Personal Personal { get; } = personal;

        /// <summary>
        ///     Информация о семье студента.
        /// </summary>
        public Family Family { get; } = family;

        /// <summary>
        ///     Информация об образовании студента.
        /// </summary>
        public Education Education { get; } = education;

        /// <summary>
        ///     Академическая информация о студенте.
        /// </summary>
        public Academic Academic { get; } = academic;

        /// <summary>
        ///     Информация об образе жизни студента.
        /// </summary>
        public Lifestyle Lifestyle { get; } = lifestyle;

        /// <summary>
        ///     Информация о здоровье студента.
        /// </summary>
        public Health Health { get; } = health;

        /// <summary>
        ///     Оценки студента.
        /// </summary>
        public Grades Grades { get; } = grades;

        /// <summary>
        ///     Создает копию текущего объекта Student.
        /// </summary>
        /// <returns>Копия объекта Student.</returns>
        public Student Clone()
        {
            return new Student(Personal.Clone(), Family.Clone(), Education.Clone(), Academic.Clone(), Lifestyle.Clone(),
                Health.Clone(), Grades.Clone());
        }

        /// <summary>
        ///     Возвращает строковое представление объекта Student.
        /// </summary>
        /// <returns>Строковое представление объекта Student.</returns>
        public override string ToString()
        {
            return string.Join(",",
                Personal.School,
                Personal.Sex,
                Personal.Age,
                Personal.Address,
                Family.Size,
                Family.ParentsStatus,
                Family.Mother.Edu,
                Family.Father.Edu,
                Family.Mother.Job,
                Family.Father.Job,
                Education.Reason,
                Personal.Guardian,
                Academic.TravelTime,
                Academic.StudyTime,
                Academic.Failures,
                Education.SchoolSupport,
                Family.FamilySupport,
                Education.Paid,
                Lifestyle.Activities,
                Academic.Nursery,
                Education.HigherEducation,
                Family.Internet,
                Lifestyle.RomanticRelationship,
                Family.RelationshipQuality,
                Lifestyle.FreeTime,
                Lifestyle.GoOut,
                Health.WorkdayAlcohol,
                Health.WeekendAlcohol,
                Health.HealthStatus,
                Academic.Absences,
                Grades.G1,
                Grades.G2,
                Grades.G3
            );
        }
    }
}