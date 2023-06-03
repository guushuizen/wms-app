using System; 
namespace LyraWMS.Models{ 

    public class BillingAddress
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public object CompanyName { get; set; }
        public string Fullname { get; set; }
        public string AddressLine1 { get; set; }
        public object AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ValidatedAt { get; set; }
        public object DeletedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}