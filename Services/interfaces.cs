using Models;
using Configuration;
using Seido.Utilities.SeedGenerator;

namespace Services;


public interface IUserService 
{
    Task<List<IUser>> GetUsersAsync (int _count);
    Task SeedUserAsync(int _count);
}

public interface ICommentService
{
    public Task<List<ICommentService>> Comment(int _count);
    public Task Seed(int _count);
}

public interface IAttractionService
{
    public Task<List<IAttractionService>> Attractions(int _count);
    public Task Seed(int _count);
}

public interface ICityService
{
    public Task<List<ICityService>> Cities(int _count);
    public Task Seed(int _count);
}

public interface ICountryService
{
    public Task<List<ICountryService>> Countries(int _count);
    public Task Seed(int _count);
}