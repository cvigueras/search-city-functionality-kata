namespace SearchCity.Console;

public class SearchCity : ISearchCity
{
    public string Get(string field)
    {
        if (field == "*")
        {
            return string.Join(",", CitiesRepository.Create(field).Values);
        }
        return !IsValidField(CitiesRepository.Create(field)) ? "No results." : CitiesRepository.Create(field).SearchByName();
    }

    private bool IsValidField(CitiesRepository citiesRepository)
    {
        return !string.IsNullOrEmpty(citiesRepository.Field) && citiesRepository.Field.Length >= 2;
    }
}