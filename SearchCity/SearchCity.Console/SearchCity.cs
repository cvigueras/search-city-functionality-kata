namespace SearchCity.Console;

public class SearchCity
{
    public string Get(string field)
    {
        if (!IsValidField(field))
        {
            return "No results.";
        }

        return SearchByName(Cities.Create(field));
    }

    private string SearchByName(Cities cities)
    {
        var result = cities.Values.Where(x => x.Contains(cities.Field)).ToList();
        return result.Count > 0 ? string.Join(",",result) : string.Empty;
    }

    private bool IsValidField(string field)
    {
        return !string.IsNullOrEmpty(field) && field.Length >= 2;
    }
}