using System.ComponentModel.DataAnnotations.Schema;

namespace PostgresSampleApp
{
    [Table("contacts")]
    public class Contact
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
}