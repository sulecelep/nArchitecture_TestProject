using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Queries.GetById;

public class GetByIdCustomerResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
}