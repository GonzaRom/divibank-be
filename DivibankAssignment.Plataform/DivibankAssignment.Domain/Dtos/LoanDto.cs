using System;

namespace DivibankAssignment.Domain.Dtos
{
    public class LoanDto
    {
        public Guid Id { get; set; }
        public DateTime LoanDateTime { get; set; }
        public decimal RequestedAmount { get; set; }
        public ClientDto Client { get; set; }
    }
}