using System.Collections.Generic;

namespace ToDoList.Models
{
    public class Category
    {
      public int CategoryId { get; set; }
      public string Name { get; set; }
      public List<Item> Items { get; set; }
        // public Category()
        // {
        //     this.Items = new HashSet<Item>();
        // }

        // public int CategoryId { get; set; }
        // public string Name { get; set; }
        // public virtual ICollection<Item> Items { get; set; }
    }
}