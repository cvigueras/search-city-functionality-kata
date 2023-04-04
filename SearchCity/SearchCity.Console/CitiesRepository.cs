namespace SearchCity.Console;

public class CitiesRepository
{
    private static string _noResults;
    public string Field { get; }

    public static string GetNoResults() => _noResults;

    private void SetNoResults(string value) => _noResults = value;

    public List<string> Values { get; set; }

    private CitiesRepository(List<string> values, string field)
    {
        Values = values;
        Field = field;
        SetNoResults("No results.");
    }

    public static CitiesRepository Create(string field)
    {
        var values = new List<string>
        {
            "Paris",
            "Budapest",
            "Skopje",
            "Rotterdam",
            "Valencia",
            "Vancouver",
            "Amsterdam",
            "Vienna",
            "Sydney",
            "New York City",
            "London",
            "Bangkok",
            "Hong Kong",
            "Dubai",
            "Rome",
            "Istanbul",
        };
        return new CitiesRepository(values, field);
    }

    public string SearchByName()
    {
        var result = Values.Where(x => x.Contains(Field,StringComparison.Ordinal)).ToList();
        return result.Count > 0 ? string.Join(",", result) : _noResults;
    }

    public string GetAllValues()
    {
        return string.Join(",", Create(Field).Values);
    }
}