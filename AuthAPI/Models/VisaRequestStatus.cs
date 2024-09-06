using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthAPI.Models
{
    public class VisaRequestStatus
    {

        [Key]
        [ForeignKey("UserInfo")]
        public int Id { get; set; }
        public string? Reason { get; set; }
        public string? Flag { get; set; }
        public  string? Status { get; set; }
        public int AdminId { get; set; }
    }
}
