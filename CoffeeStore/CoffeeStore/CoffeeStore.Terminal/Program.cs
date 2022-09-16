using CoffeeStore.DataAccess.Dto;
using CoffeeStore.DataAccess;

await DealWithDbContext();

async Task DealWithDbContext()
{
    var dbContext = new CoffeeStoreContext();
    var products = dbContext.Products;

    var prodTypeId = Guid.Parse("0C57276D-022F-4983-A175-550E19B17318");
    var coffeeBeanProducts = products.Where(prod => prod.ProductTypeId == prodTypeId);

    foreach (var product in coffeeBeanProducts)
    {
        Console.WriteLine($"Name: {product.Name}, Description: {product.Description}");
    }

    //Joined data from two table
    var orders = dbContext.Orders;
    var orderDetails = dbContext.OrderDetails;

    var ordersWithDetails = orders.Join(orderDetails,
        order => order.Id,
        orderDetails => orderDetails.OrderId,
        (order, orderDetails) => new
        {
            OrderId = order.Id,
            Amount = orderDetails.Amount,
            Sum = orderDetails.Sum,
        }
        );
    foreach (var orderRow in ordersWithDetails)
    {
        Console.WriteLine($"ID:{orderRow.OrderId}, Amount: {orderRow.Amount}, Sum: {orderRow.Sum}");
    }

    //Add new product
    var productType = dbContext.ProductTypes.FirstOrDefault(type => type.Name == "Coffee (ground)")
        ?? throw new InvalidOperationException("Type 'Cofee (ground)' should be placed in ProdyctTypes!");

    var javaCoffee = new Product
    {
        Id = Guid.NewGuid(),
        Name = "Java Coffe",
        Description = "The best coffee (much better than programming language)",
        NomenclatureNumber = "0015-4326",
        ProductTypeId = productType.Id
    };

    await products.AddAsync(javaCoffee);
    await dbContext.SaveChangesAsync();

    var javaCoffeeStored = products.SingleOrDefault(prod => prod.Id == javaCoffee.Id);
    Console.WriteLine(javaCoffeeStored?.Name ?? "NOT FOUND");
}
