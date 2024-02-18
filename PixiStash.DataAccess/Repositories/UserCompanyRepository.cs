namespace PixiStash.DataAccess.Repositories
{
    //public class UserCompanyRepository : IUserCompany
    //{
    //    private readonly IOkrDbContext _context;
    //    public UserCompanyRepository(IOkrDbContext context)
    //    {
    //        _context = context;
    //    }

    //    public List<UserCompany> GetByUserId(Guid Id)
    //    {
    //       var userCompanies = _context.UserCompanies.Where(x => x.UserId == Id).ToList();
    //        if (userCompanies == null)
    //        {
    //            // Handle the situation where the context or collection is null.
    //            // You might log an error, display a message, or take appropriate action.
    //            return new List<UserCompany>(); // Return an empty list or null as per your requirements.
    //        }

    //        return userCompanies;
    //    }

    //    public UserCompany GetByUserCompany(Guid UserId, Guid ComId)
    //    {
    //        var userCompanies = _context.UserCompanies.Where(x => x.UserId == UserId && x.ComId == ComId).FirstOrDefault();
    //        if (userCompanies == null)
    //        {
    //            // Handle the situation where the context or collection is null.
    //            // You might log an error, display a message, or take appropriate action.
    //            return new UserCompany(); // Return an empty list or null as per your requirements.
    //        }

    //        return userCompanies;
    //    }

    //    public UserCompany GetDefaultCompany(Guid UserId)
    //    {
    //        var userCompanies = _context.UserCompanies
    //            .Where(x => x.UserId == UserId && x.Role == CompanyRole.SuperAdmin)
    //            .FirstOrDefault();
    //        if (userCompanies == null)
    //        {
    //            // Handle the situation where the context or collection is null.
    //            // You might log an error, display a message, or take appropriate action.
    //            return new UserCompany(); // Return an empty list or null as per your requirements.
    //        }

    //        return userCompanies;
    //    }
    //}
}
