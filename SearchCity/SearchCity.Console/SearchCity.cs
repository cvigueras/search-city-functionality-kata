namespace SearchCity.Console;

public class SearchCity : ISearchCity
{
    public string Get(CitiesRepository citiesRepository)
    {
        return citiesRepository.Field == "*" ? CitiesRepository.Create(citiesRepository.Field).GetAllValues() :
            !Validate(CitiesRepository.Create(citiesRepository.Field)) ? CitiesRepository.GetNoResults() :
            CitiesRepository.Create(citiesRepository.Field).SearchByName();
    }

    private bool Validate(CitiesRepository citiesRepository)
    {
        return !string.IsNullOrEmpty(citiesRepository.Field) && citiesRepository.Field.Length >= 2;
    }
}