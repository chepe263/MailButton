using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MailButton.Models
{
    [Table("messages")]
    public class Message
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(60)]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Body { get; set; }

        public DateTime Created { get; set; }
        
        public DateTime Updated { get; set; }
        
        public Nullable <DateTime> Deleted { get; set; }

    }
}
