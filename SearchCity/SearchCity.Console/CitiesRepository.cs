namespace SearchCity.Console;

public class CitiesRepository
{
    public string Field { get; private set; }
    public List<string> Values { get; set; }

    private CitiesRepository(List<string> values, string field)
    {
        Values = values;
        Field = field;
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
        return result.Count > 0 ? string.Join(",",result) : "No results.";
    }
}