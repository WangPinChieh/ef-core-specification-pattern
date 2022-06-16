
namespace ef_core_specification_pattern;

public class EFContext 
{
   public IQueryable<User> Users { get; set; }

   public EFContext()
   {
      Users = new List<User>
      {
         new User
         {
            Id = new Guid(),
            Name = "Jay",
            Age = 30,
            Address = "Taoyuan"
         },
         new User
         {
            Id = new Guid(),
            Name = "Chen",
            Age = 32,
            Address = "Taoyuan"
         },
         new User
         {
            Id = new Guid(),
            Name = "Wang",
            Age = 10,
            Address = "Keelung"
         },
         new User
         {
            Id = new Guid(),
            Name = "Shao",
            Age = 18,
            Address = "Taipei"
         },
      }.AsQueryable();
   }
}

public class User
{
   public Guid Id { get; set; }
   public string Name { get; set; }
   public int Age { get; set; }
   public string Address { get; set; }
}
