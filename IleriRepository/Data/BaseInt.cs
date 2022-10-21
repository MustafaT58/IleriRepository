using System.ComponentModel.DataAnnotations;

namespace IleriRepository.Data
{
    public class BaseInt
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
