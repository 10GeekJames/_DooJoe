namespace DojoSurveysBlazorModule.UIUnitTests;

public class AllDojoSurveysPageTests : BaseTest
{
    [Fact]
    public void AllDojoSurveysPageRender()
    {
        var tableSelector = "#AllDojoSurveysStaticTable>div>Table";
        var tableHeaderRowSelector = $"{tableSelector}>thead>tr";
        var tableDataRowsSelector = $"{tableSelector}>tbody>tr";
        
        var component = ctx.RenderComponent<AllDojoSurveys>();       

        var tableHeader = component.Find(tableSelector);
        tableHeader.Should().NotBeNull();

        var tableHeaderRow = component.Find(tableHeaderRowSelector);
        tableHeaderRow.Should().NotBeNull();

        var tableDataRows = component.FindAll(tableDataRowsSelector);
        tableDataRows.Count().Should().BeGreaterThan(0);
        tableDataRows.Count().Should().Be(9);
        
        var row1 = component.FindAll(tableDataRowsSelector).First();
        row1.ToMarkup().Should().Contain("DojoSurveyTwoQuestions");
        row1.ToMarkup().Should().NotContain("DojoSurveyFiveQuestions");

        // Given I am on the all dojoSurveys page

        // When I scan the table data

        // I can see records

    }

    [Fact]
    public void AllDojoSurveysFetchRender()
    {
        var component = ctx.RenderComponent<AllDojoSurveys>();        

       /*  // And the counter is initialized to 0
        component.Find("#currentCount").TextContent.Should().Be("0");

        // When I increment the count
        component.Find("#incrementPlus").Click();

        // The count should be 1
        component.Find("#currentCount").TextContent.Should().Be("1"); */

    }
}