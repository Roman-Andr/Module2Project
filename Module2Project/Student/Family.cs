namespace Module2Project
{
    /// <summary>
    ///     Представляет информацию о семье студента.
    /// </summary>
    public class Family(
        string size,
        Parent mother,
        Parent father,
        string familySupport,
        string parentsStatus,
        string internet,
        uint relationshipQuality
    )
    {
        /// <summary>
        ///     Размер семьи.
        /// </summary>
        public string Size { get; } = size;

        /// <summary>
        ///     Информация о матери студента.
        /// </summary>
        public Parent Mother { get; } = mother;

        /// <summary>
        ///     Информация о отце студента.
        /// </summary>
        public Parent Father { get; } = father;

        /// <summary>
        ///     Информация о поддержке со стороны семьи.
        /// </summary>
        public string FamilySupport { get; } = familySupport;

        /// <summary>
        ///     Статус родителей (например, совместное проживание).
        /// </summary>
        public string ParentsStatus { get; } = parentsStatus;

        /// <summary>
        ///     Доступ к интернету в семье.
        /// </summary>
        public string Internet { get; } = internet;

        /// <summary>
        ///     Качество отношений в семье.
        /// </summary>
        public uint RelationshipQuality { get; } = relationshipQuality;

        /// <summary>
        ///     Создает копию текущего объекта Family.
        /// </summary>
        /// <returns>Копия объекта Family.</returns>
        public Family Clone()
        {
            return new Family(Size, Mother.Clone(), Father.Clone(), FamilySupport, ParentsStatus, Internet,
                RelationshipQuality);
        }
    }
}