# X.PagedList.Mvc.Bootstrap4
[![Build Status](https://dev.azure.com/lettucebo/Github.Build/_apis/build/status%2FX.PagedList.Mvc.Bootstrap4%2FX.PagedList.Mvc.Bootstrap4.Build?branchName=master)](https://dev.azure.com/lettucebo/Github.Build/_build/latest?definitionId=18&branchName=master)
[![Nuget](https://img.shields.io/nuget/dt/X.PagedList.Mvc.Bootstrap4?label=NuGet)](https://www.nuget.org/packages/X.PagedList.Mvc.Bootstrap4)

pager style for bootstrap 4

## Styling the Pager Yourself
Current PagedList.Mvc Pager style is for Bootstrap 3, at Bootstrap 4, the pager style have a little change, this help easy transform to bootstrap 4 style

![ResultDemo](https://i.imgur.com/tUcO9Xp.png)

## Usage
First install nuget package:
```
Install-Package X.PagedList.Mvc.Bootstrap4
```

Then at cshtml pager:
``` cshtml
@Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page }), Bootstrap4PagedListRenderOptions.ClassicPlusFirstAndLast)
```

Then it's done.

## Custom
You can also custom your own setting base on Bootstrap4PagedListRenderOptions

Please see: [HomeController.Cutsom](https://github.com/lettucebo/X.PagedList.Mvc.Bootstrap4/blob/master/src/X.PagedList.Mvc.Bootstrap4.Core.Example/Views/Home/Custom.cshtml)

## Type
- Minimal
- PageNumbersOnly
- Classic
- Default
- ClassicPlusFirstAndLast
