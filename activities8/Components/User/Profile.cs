using activities8.Data;
using activities8.Models;
using Microsoft.EntityFrameworkCore;

namespace activities8.Components.User;

public class Profile : IProfile
{
    private readonly ApplicationDbContext db;

    public Profile(ApplicationDbContext context)
    {
        this.db = context ?? throw new ArgumentNullException(nameof(context));
    }

    public Task<UserProfile> Add(UserProfile profile)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<UserProfile> Edit(string userId, UserProfile profile)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetPhoto(string userId)
    {
        throw new NotImplementedException();
    }

    public async Task<UserProfile> GetProfile(string userId)
    {
        var user = await this.db.UserProfiles.Select(s => new UserProfile
            {
                UserId = s.UserId,
                Name = s.Name,
                About = s.About,
                Approval = s.Approval,
                ApprovalMessage = s.ApprovalMessage,
                Available = s.Available,
                City = s.City,
                Id = s.Id,
                IdActivity = s.IdActivity,
                IdCountry = s.IdCountry,
                IdLanguage = s.IdLanguage,
                Member = s.Member,
                Other = s.Other,
                Test = s.Test
            }).Where(p => p.UserId == userId).FirstOrDefaultAsync();

            return user;
        }

}