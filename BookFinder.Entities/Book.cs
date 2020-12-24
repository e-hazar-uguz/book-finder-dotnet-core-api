using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookFinder.Entities
{
    public class Book
    {
      

        //annotations,id alanı primary key olacak ve autoincrement

       [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int id { get; set; }

       [StringLength(50)] 
       public string name { get; set; }
       [StringLength(50)]
       public string type { get; set; }
       [StringLength(50)]
        public string authorName { get; set; }

    }
}
