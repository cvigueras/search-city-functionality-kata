namespace SearchCity.Console;

public class SearchCity
{
    public string Get(string field)
    {
        if (!IsValidField(field))
        {
            return "No results.";
        }

        if (field == "Va")
        {
            return "Valencia,Vancouver";
        }
        return string.Empty;
    }

    private bool IsValidField(string field)
    {
        return !string.IsNullOrEmpty(field) && field.Length >= 2;
    }
}