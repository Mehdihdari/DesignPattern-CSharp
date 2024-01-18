using pattern.FactoryMethod;

List<Resume> products = new List<Resume>(2);
products.Add(new DemoAccount());
products.Add(new RealAccount());


foreach (var product in products) { 

   Console.WriteLine(product.GetType().Name);
    foreach (Abilityes item in product.Abilityes)
    {
        Console.Write(item.GetType().Name + "  ");

    }

}