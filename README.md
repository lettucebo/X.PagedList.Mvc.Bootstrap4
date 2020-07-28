# X.PagedList.Mvc.Bootstrap4
[![Build Status](https://lettucebo.visualstudio.com/Github.Build/_apis/build/status/X.PagedList.Mvc.Bootstrap4/X.PagedList.Mvc.Bootstrap4.Build?branchName=master&jobName=Job)](https://lettucebo.visualstudio.com/Github.Build/_build/latest?definitionId=18&branchName=master)

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

Please see: HomeController.Cutsom

## Type
- Minimal
- PageNumbersOnly
- Classic
- Default
- ClassicPlusFirstAndLast
