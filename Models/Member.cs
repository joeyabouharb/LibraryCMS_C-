namespace LibraryCMS.Models
{
    using System.Collections.Generic;
    public class Member
    {
        public int MemberId { get; set; }

        public string FirstName {get; set;}

        public string LastName { get; set; }

        public ICollection<Loan> Loans { get; set; }
    }
}