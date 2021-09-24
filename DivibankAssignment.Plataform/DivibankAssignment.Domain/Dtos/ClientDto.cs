using System;
using System.Collections.Generic;

namespace DivibankAssignment.Domain.Dtos
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public DateTime Birthdate { get; set; }
        public List<LoanDto> Loans { get; set; }
    }
}
