namespace LibraryCMS.Models
{
    using System.Collections.Generic;

    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public ICollection<Book> Books { get; set; }

        
    }
}