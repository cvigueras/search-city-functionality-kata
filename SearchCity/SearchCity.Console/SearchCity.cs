namespace SearchCity.Console;

public class SearchCity
{
    public string Get(string field)
    {
        if (!IsValidField(field))
        {
            return "No results.";
        }
        
        return string.Empty;
    }

    private bool IsValidField(string field)
    {
        return !string.IsNullOrEmpty(field) && field.Length >= 2;
    }
}