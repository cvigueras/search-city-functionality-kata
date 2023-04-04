namespace SearchCity.Console;

public class SearchCity
{
    public string Get(string field)
    {
        if (field == "")
        {
            return "No results.";
        }
        if (field == null)
        {
            return "No results.";
        }
        if (field == "a")
        {
            return "No results.";
        }

        return string.Empty;
    }
}