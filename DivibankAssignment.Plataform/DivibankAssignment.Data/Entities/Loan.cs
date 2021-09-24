using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DivibankAssignment.Data.Entities
{
    public class Loan : BaseEntity<Loan>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LoanDateTime { get; set; }
        [Required]
        public decimal RequestedAmount { get; set; }
        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; }

        public override void CopyFrom(Loan entity)
        {
            Id = entity.Id;
            LoanDateTime = entity.LoanDateTime;
            RequestedAmount = entity.RequestedAmount;
            Client = entity.Client;
        }
    }
}