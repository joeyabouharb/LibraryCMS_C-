namespace LibraryCMS.Contexts
{
    using Microsoft.EntityFrameworkCore;
    using LibraryCMS.Models;
    public class LibraryContext : DbContext
    {
        public DbSet<Book> TblBooks { get; set; }

        public DbSet<Category> TblCategories { get; set; }

        public DbSet<Author> TblAuthors { get; set; }
        
        public DbSet<Member> TblMembers { get; set; }
        
        public DbSet<Loan> TblLoans { get; set; }

        public LibraryContext():base()
        {
            
        }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            
        }
    }
}