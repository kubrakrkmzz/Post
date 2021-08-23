using System.ComponentModel.DataAnnotations;

namespace Post.Models
{
    public class Personal
    {
        public int Id { get; set; }
        
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string IdentificationNumber { get; set; }
        
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public bool? Gender { get; set; }

        public int DepartId { get; set; }
        public Department depart { get; set; }


    }
}
