# X.PagedList.Mvc.Bootstrap4
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

## Type
- Minimal
- PageNumbersOnly
- Classic
- Default
- ClassicPlusFirstAndLast
