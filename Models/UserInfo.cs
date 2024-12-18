using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]    
        public string? Name { get; set; }
        [Required(ErrorMessage = "Lütfen telefon numaranızı giriniz.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Lütfen e-posta adresinizi giriniz.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir e-posta adresi giriniz.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Lütfen katılım durumunuzu giriniz.")]
        public bool? WillAttend { get; set; }
        public string? OtherReason { get; set; }
    }
}