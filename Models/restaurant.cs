using System.ComponentModel.DataAnnotations;

namespace EksamenApi.Models{

    public class restaurant{
        
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
}