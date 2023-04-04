namespace SearchCity.Console;

public class SearchCity : ISearchCity
{
    public string Get(string field)
    {
        return !IsValidField(Cities.Create(field)) ? "No results." : SearchByName(Cities.Create(field));
    }

    private string SearchByName(Cities cities)
    {
        var result = cities.Values.Where(x => x.Contains(cities.Field)).ToList();
        return result.Count > 0 ? string.Join(",",result) : string.Empty;
    }

    private bool IsValidField(Cities cities)
    {
        return !string.IsNullOrEmpty(cities.Field) && cities.Field.Length >= 2;
    }
}