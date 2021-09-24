using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DivibankAssignment.Data.Entities
{
    public class Client : BaseEntity<Client>
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        public List<Loan> Loans { get; set; }

        public override void CopyFrom(Client entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Birthdate = entity.Birthdate;
            Loans = entity.Loans;
        }
    }
}