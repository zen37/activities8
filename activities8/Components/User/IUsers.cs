using activities8.Models;

namespace activities8.Components.User
{
    public interface IUsers
    {
        Task<List<Profile>> GetProfilesLastRegistered();
        Task<IEnumerable<Stats>> GetStats(string GroupBy, Dictionary<string, string> ressources);
        Task<int> CountUsers();
        Task<Profile[]> GetProfiles(int pageNumber, Search searchCriteria);
       // Task<UserProfile[]> SearchProfiles(int pageNumber, SearchModel searchModel);
        Task<int[]> GetProfilesActivites();
        Task<string[]> GetProfilesCountries();
        Task<string[]> GetProfilesLanguages(int idCountry);
        Task<int> CountProfiles(Search searchCriteria);
       // Task<int> CountSearchProfiles(SearchModel model);
    }
}
