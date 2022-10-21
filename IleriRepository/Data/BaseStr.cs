 using System.ComponentModel.DataAnnotations;

namespace IleriRepository.Data
{
    public class BaseStr
    {
        [Key]
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
