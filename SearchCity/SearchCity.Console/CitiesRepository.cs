namespace SearchCity.Console;

public class Cities
{
    public string Field { get; private set; }
    public List<string> Values { get; set; }

    private Cities(List<string> values, string field)
    {
        Values = values;
        Field = field;
    }

    public static Cities Create(string field)
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
        return new Cities(values, field);
    }
}