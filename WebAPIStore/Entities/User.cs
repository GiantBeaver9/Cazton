using System.ComponentModel.DataAnnotations;
namespace WebAPIStore.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }


        public string? UserName { get; set; }

    }
}
