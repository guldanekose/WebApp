using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class CheckoutDto
    {
        [Requried(ErrorMessage = "The Delivery Address is required.")]
        [MaxLength(200)]
        public string DeliveryAddress { get; set; } = "";
        public string PaymentMethod { get; set; } = "";

    }
}
