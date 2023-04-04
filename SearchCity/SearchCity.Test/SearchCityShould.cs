using FluentAssertions;

namespace SearchCity.Test
{
    public class SearchCityShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void return_no_result_when_input_search_is_empty()
        {
            var searchCity = new Console.SearchCity();

            var result = searchCity.Get("");

            result.Should().Be("No results.");
        }
    }
}