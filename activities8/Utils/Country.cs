namespace activities8.Utils;
public class Country
{
    public static string? GetCountryById(int id)
    {
        return Countries.DictCountries.TryGetValue(id, out var country) ? country : null;
    }

    public static string? GetCountryById(byte id)
    {
        return Countries.DictCountriesByte.TryGetValue(id, out var country) ? country : null;
    }

    public static List<(int, string)> GetCountryList()
    {
        return Countries.ListCountries.Select(country => (country.Item1, country.Item2)).ToList();
    }

    public static List<(byte, string)> GetCountryList(bool getbyte = true)
    {
        return Countries.ListCountriesByte.Select(country => (country.Item1, country.Item2)).ToList();
    }

    public static List<(int, string)> GetCountriesByOrder()
    {
        var sortedList = Countries.ListCountries.Select(country => (country.Item1, country.Item2)).ToList();
        return sortedList;
    }

    public static List<(byte, string)> GetCountriesByOrder(bool getbyte = true)
    {
        var sortedList = Countries.ListCountriesByte.Select(country => (country.Item1, country.Item2)).ToList();
        return sortedList;
    }
}