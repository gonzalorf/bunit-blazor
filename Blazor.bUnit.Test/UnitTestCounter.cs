using Blazor.bUnit.Pages;
using Bunit;
using Bunit.Rendering;

namespace Blazor.bUnit.Test
{
    public class UnitTestCounter : TestContext
    {
        [Fact]
        public void CounterIncrementWhenClicked()
        {
            var component = RenderComponent<Counter>();

            component.Find("button").Click();

            component.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }
    }
}