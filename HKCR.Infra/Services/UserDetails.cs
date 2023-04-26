using HKCR.Application.Common.Interface;

namespace HKCR.Infra.Services;

public class UserDetails : IUserDetails
{
    private readonly IApplicationDbContext _dbContext;

    public UserDetails(IApplicationDbContext dBContext)
    {
        _dbContext = dBContext;
    }

    // public Task<List<EmployeeResponseDTO>> GetAllUser()
    // {
    //     throw new NotImplementedException();
    // }
}