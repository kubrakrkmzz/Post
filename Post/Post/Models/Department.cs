using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Post.Models
{
    public class Department
    {
        [Key]
        public int DepartId { get; set; }

        public string DepartName { get; set; }

        //Table Data Annotations: Veritabanı tablo adını düzenlemek için kullanılır.
        //Column Data Annotations : Veritabanında yer alan o tablo içindeki kolon adını düzenlemek için kullanılır.
        
        public List<Personal> personals { get; set; }

    }
}
