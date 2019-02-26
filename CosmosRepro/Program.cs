namespace CosmosRepro
{
    class Program
    {
        static void Main()
        {
            using(var context = new CosmosContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                context.Add(new Class1 { Id = 1, SubObj = new Subclass { String = "New" } });

                context.SaveChanges();
            }
        }
    }
}
