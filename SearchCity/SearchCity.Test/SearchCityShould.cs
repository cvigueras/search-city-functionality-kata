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
            var result = SearchCity.Get("");

            result.Should().Be("No results.");
        }
    }

    public class SearchCity
    {
        public static object Get(string empty)
        {
            return "No results.";
        }
    }
}