using AutoMapper;
using DivibankAssignment.Data.Entities;
using DivibankAssignment.Domain.Dtos;

namespace DivibankAssignment.Domain
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<Loan, LoanDto>();
        }
    }
}