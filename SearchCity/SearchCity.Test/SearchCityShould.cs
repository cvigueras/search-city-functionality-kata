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

        [Test]
        public void return_no_result_when_input_search_is_null()
        {
            var searchCity = new Console.SearchCity();

            var result = searchCity.Get(null);

            result.Should().Be("No results.");
        }

        [Test]
        public void return_no_result_when_input_search_is_less_than_two_character()
        {
            var searchCity = new Console.SearchCity();

            var result = searchCity.Get("a");

            result.Should().Be("No results.");
        }

        [Test]
        public void return_no_result_when_input_search_is_less_than_two_character_with_other_string()
        {
            var searchCity = new Console.SearchCity();

            var result = searchCity.Get("b");

            result.Should().Be("No results.");
        }

        [Test]
        public void return_no_result_when_input_search_is_less_than_two_character_with_other_more_string()
        {
            var searchCity = new Console.SearchCity();

            var result = searchCity.Get("c");

            result.Should().Be("No results.");
        }
    }
}