using activities8.Models;

namespace activities8.Components.User;
    public interface IProfile
    {
        Task<string> GetPhoto(string userId);
        Task<UserProfile> Add(UserProfile profile);
        Task<bool> Delete(string userId);
        Task<UserProfile> Edit(string userId, UserProfile profile);
        Task<UserProfile> GetProfile(string userId);
    }