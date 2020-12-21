using System;
namespace promotersapp.ViewModels
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public int FirmId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public decimal Value { get; set; }
        public bool? IsSubscribed { get; set; }
        public string PaymentCode { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
