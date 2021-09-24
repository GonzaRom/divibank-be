using System.Threading.Tasks;
using DivibankAssignment.Data.Entities;

namespace DivibankAssignment.Domain.Services.Interfaces
{
    public interface IClientService
    {
        Task<Client> GetClientById(int id);
    }
}