using FluentAssertions;

namespace SearchCity.Test
{
    public class SearchCityShould
    {
        private Console.SearchCity _searchCity;

        [SetUp]
        public void Setup()
        {
            _searchCity = new Console.SearchCity();
        }

        [Test]
        public void return_no_result_when_input_search_is_empty()
        {
            var result = _searchCity.Get("");

            result.Should().Be("No results.");
        }

        [Test]
        public void return_no_result_when_input_search_is_null()
        {
            var result = _searchCity.Get(null);

            result.Should().Be("No results.");
        }

        [TestCase("a")]
        [TestCase("b")]
        [TestCase("c")]
        public void return_no_result_when_input_search_is_less_than_two_character(string input)
        {
            var result = _searchCity.Get(input);

            result.Should().Be("No results.");
        }

        [Test]
        public void return_Valencia_Vancouver_when_input_value_is_Va()
        {
            var result = _searchCity.Get("Va");

            result.Should().Be("Valencia,Vancouver");
        }

        [Test]
        public void return_London_HongKong_when_input_value_is_on()
        {
            var result = _searchCity.Get("on");

            result.Should().Be("London,Hong Kong");
        }

        [Test]
        public void return_Rotterdam_Amsterdam_when_input_value_is_am()
        {
            var result = _searchCity.Get("am");

            result.Should().Be("Rotterdam,Amsterdam");
        }
    }
}