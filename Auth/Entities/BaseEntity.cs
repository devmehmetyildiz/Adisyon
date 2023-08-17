using System.ComponentModel.DataAnnotations;

namespace Auth.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Uuid { get; set; }
        public string Createuser { get; set; }
        public string Updateuser { get; set; }
        public string Deleteuser { get; set; }
        public DateTime? Createtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public DateTime? Deletetime { get; set; }
        public bool Isactive { get; set; }

    }
}
