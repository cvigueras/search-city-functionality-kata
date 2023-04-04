namespace SearchCity.Console;

public class SearchCity
{
    public string Get(string empty)
    {
        if (empty == "")
        {
            return "No results.";
        }
        if (empty == null)
        {
            return "No results.";
        }

        return string.Empty;
    }
}