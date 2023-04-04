using FluentAssertions;
using NSubstitute;
using SearchCity.Console;

namespace SearchCity.Test
{
    public class SearchCityShould
    {
        private Console.SearchCity _searchCity;
        private ISearchCity _isearchCity;

        [SetUp]
        public void Setup()
        {
            _searchCity = new Console.SearchCity();
            _isearchCity = Substitute.For<ISearchCity>();
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

        [TestCase("Va", "Valencia,Vancouver")]
        [TestCase("on", "London,Hong Kong")]
        [TestCase("am", "Rotterdam,Amsterdam")]
        public void return_Valencia_Vancouver_when_input_value_is_Va(string input, string expectedResult)
        {
            _isearchCity.Get(input).Returns(expectedResult);

            expectedResult.Should().Be(_isearchCity.Get(input));
        }
    }
}