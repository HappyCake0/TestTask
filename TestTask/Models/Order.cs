using System.ComponentModel.DataAnnotations;

namespace TestTask.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Sender city")]
        public string SenderCity { get; set; }

        [Display(Name = "Sender adress")]
        public string SenderAdress { get; set; }

        [Display(Name = "Receiver city")]
        public string ReceiverCity { get; set; }

        [Display(Name = "Receiver adress")]
        public string ReceiverAdress { get; set; }

        [Range(0.001,100000)]
        public float Weight { get; set; }

        [Display(Name = "Pickup Date")]
        [DataType(DataType.Date)]
        public string PickupDate { get; set; }

    }
}
