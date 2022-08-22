namespace WorkshopLib
{
    public abstract class StoreItem
    {
        public StoreItem(string name, string country, string description)
        {
            Name = name;
            Country = country;
            Description = description;
        }
        public abstract string Name { get; init; }
        protected virtual int Id { get; init; }
        public abstract string Country { get; init; }
        public abstract string Description { get; init; }
    }

    internal interface IHasShelfLife
    {
        bool HasShelfLife { get; }
        bool SearchForExpirationDate();
        DateTime ProductionDate { get; init; }
    }

    public abstract class Wear : StoreItem
    {
        public Wear(string name, string country, string description) : base(name, country, description)
        { }
        public override string Name => "Одежда";
        protected override int Id => 0;
        public override string Country => "Страна производителя";
        public override string Description => "Одежда";
    }

    public abstract class SportSuit : Equipment
    {
        public SportSuit(string name, string country, string description) : base(name, country, description)
        { }
        public override string Name => "Спортивный костюм";
        protected override int Id => 1;
        public override string Country => "Россия";
        public override string Description => "Одежда для занятия спортом";
    }

    public abstract class Equipment : StoreItem
    {
        public Equipment(string name, string country, string description) : base(name, country, description)
        { }
        public override string Name => "Оборудование";
        protected override int Id => 0;
        public override string Country => "Страна производителя";
        public override string Description => "Оборудование";
    }

    public abstract class horizontalbar : Equipment
    {
        public horizontalbar(string name, string country, string description) : base(name, country, description)
        { }
        public override string Name => "Турник";
        protected override int Id => 1;
        public override string Country => "Россия";
        public override string Description => "Турник для дома";

    }

    public abstract class Food : StoreItem, IHasShelfLife
    {
        public Food(string name, string country, string description, DateTime productionDate) : base(name, country, description)
        {
            ProductionDate = productionDate;
        }
        public override string Name => "Еда";
        protected override int Id => 0;
        public override string Country => "Страна производителя";
        public override string Description => "Спортивное питание";

        public bool HasShelfLife => true;
        public DateTime ProductionDate { get; init; }
        public DateTime ExpirationDate;
        public bool SearchForExpirationDate()
        {
            return true;
        }
    }


    public abstract class Protein : Food
    {
        public Protein(string name, string country, string description, DateTime productionDate) : base(name, country, description, productionDate)
        { }
        public override string Name => "Протеин";
        protected override int Id => 1;
        public override string Country => "Германия";
        public override string Description => "Прот для настоящих мужиков";
        public bool HasShelfLife => SearchForExpirationDate();
        public bool SearchForExpirationDate()
        {
            return true;
        }


    }
}