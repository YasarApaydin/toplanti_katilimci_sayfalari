using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad&Soyad Alanı Zorunludur.")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon Alanı Zorunludur.")]
        public string? Phone { get; set;}

        [Required(ErrorMessage ="Email Alanı Zorunludur.")]
        [EmailAddress(ErrorMessage ="Hatalı Email.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım Durumunuzu Belirtiniz.")]
        public bool? WillAttend { get; set; }


    }
}
