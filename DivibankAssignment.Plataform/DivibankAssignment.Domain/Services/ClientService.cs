using System.Threading.Tasks;
using DivibankAssignment.Data.Entities;
using DivibankAssignment.Domain.Services.Interfaces;

namespace DivibankAssignment.Domain.Services
{
    public class ClientService : IClientService
    {
        public Task<Client> GetClientById(int id)
        {
            var client = new Client{
                Id = id,
                Name = "Client Name",
                Birthdate = new System.DateTime(1990, 1, 1),
                Loans = new List<Loan>()
            };
        }
    }
}