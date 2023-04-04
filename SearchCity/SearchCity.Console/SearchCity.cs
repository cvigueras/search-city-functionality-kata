namespace SearchCity.Console;

public class SearchCity : ISearchCity
{
    public string Get(string field)
    {
        return field == "*" ? CitiesRepository.Create(field).GetAllValues() :
            !Validate(CitiesRepository.Create(field)) ? "No results." :
            CitiesRepository.Create(field).SearchByName();
    }

    private bool Validate(CitiesRepository citiesRepository)
    {
        return !string.IsNullOrEmpty(citiesRepository.Field) && citiesRepository.Field.Length >= 2;
    }
}