namespace WorkshopLib
{
    internal interface IHasShelfLife
    {
        bool HasShelfLife { get; }
        bool SearchForExpirationDate();
        DateTime ProductionDate { get; init; }
    }
}