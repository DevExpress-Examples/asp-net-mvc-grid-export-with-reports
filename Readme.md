<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4121)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Grid View for ASP.NET MVC - How to use Reports to export a large amount of filtered data

This example demonstrates how to export a large amount of filtered data using **LINQ-to-SQL**.

## Implementation Details

When you export a large amount of of filtered data, [Grid View](https://docs.devexpress.com/AspNetMvc/8966/components/grid-view) export mechanism requests all data from a database and then filters it. Such request can be fulfilled and the `System.OutOfMemoryException` exception can occur. To resolve this issue, request filtered data manually and export it using the **XtraReports Suite**. 

```csharp
public ActionResult ExportTo(string filterString) {
    CriteriaOperator filterCriteria = CriteriaOperator.Parse(filterString);
    IList<Email> emails = LargeDatabaseDataProvider.GetEmailsByFilter(filterCriteria);

    XtraReport1 report = new XtraReport1();
    report.DataSource = emails;
    ExportReport(report, "largeData", true, "Xlsx");
    return GridViewPartial();
}
```

To pass the `FilterExpression` to a controller's action, obtain and save the expression in a custom client property:

```cs
settings.CustomJSProperties = (s, e) => {
	MVCxGridView gridView = (MVCxGridView)s;
	e.Properties["cpGridFilterExpression"] = gridView.FilterExpression;
};
```

```vbnet
settings.CustomJSProperties = Sub(s, e)
	Dim gridView = TryCast(s, MVCxGridView)
	e.Properties("cpGridFilterExpression") = gridView.FilterExpression
End Sub
```

When a user clicks the **Export to XLSx** button, the `Click` event handler adds filter expression contained in the custom client property to the collection of jQuery selector parameters.

```js
function onClick(s, e) {
	var actionParams = $("form").attr("action").split("?filterString=");
	actionParams[1] = encodeURIComponent(GridView.cpGridFilterExpression);
	$("form").attr("action", actionParams.join("?filterString="));
}
```

## Files to Review

* [HomeController.cs](./CS/E4121/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/E4121VB/Controllers/HomeController.vb))
* [GridViewPartial.cshtml](./CS/E4121/Views/Home/_GridViewPartial.cshtml) (VB: [GridViewPartial.vbhtml](./VB/E4121VB/Views/Home/_GridViewPartial.vbhtml))
* [Index.cshtml](./CS/E4121/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/E4121VB/Views/Home/Index.vbhtml))

## Documentation
* [Create a Report in Visual Studio](https://docs.devexpress.com/XtraReports/14989/get-started-with-devexpress-reporting/create-a-report-in-visual-studio)
* [Use Embedded Fields (Mail Merge)](https://docs.devexpress.com/XtraReports/2433/detailed-guide-to-devexpress-reporting/use-report-controls/bind-report-controls-to-data/use-embedded-fields-mail-merge)
* [Create a Table Report](https://docs.devexpress.com/XtraReports/4784/create-reports/create-a-table-report)

## More Examples

* [How to convert the CriteriaOperator to a lambda expression to use it for IQueryable](https://github.com/DevExpress-Examples/XDL_how-to-convert-the-criteriaoperator-to-a-lambda-expression-to-use-it-for-iqueryable-e2596)
