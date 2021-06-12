using X.PagedList.Web.Common;

namespace X.PagedList.Mvc.Bootstrap4.Core
{
    /// <summary>
    /// Some built-in bootstrap4 <see cref="PagedListRenderOptions"/>
    /// </summary>
    public class Bootstrap4PagedListRenderOptions
    {
        private static PagedListRenderOptions GetCommonSetting()
        {
            var option = new PagedListRenderOptions()
            {
                LiElementClasses = new[] { "page-item" },
                PageClasses = new[] { "page-link" },

                // Due to no way change Ellipses element class, try setting EllipsesElementClass but fail, so disable Ellipses
                DisplayEllipsesWhenNotShowingAllPageNumbers = false
            };
            return option;
        }

        public static PagedListRenderOptions Default
        {
            get
            {
                var option = GetCommonSetting();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.IfNeeded;
                option.DisplayLinkToLastPage = PagedListDisplayMode.IfNeeded;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.IfNeeded;
                option.DisplayLinkToNextPage = PagedListDisplayMode.IfNeeded;

                return option;
            }
        }

        public static PagedListRenderOptions ClassicPlusFirstAndLast
        {
            get
            {
                var option = GetCommonSetting();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Always;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Always;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Always;

                return option;
            }
        }

        public static PagedListRenderOptions Classic
        {
            get
            {
                var option = GetCommonSetting();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Always;

                return option;
            }
        }

        public static PagedListRenderOptions Minimal
        {
            get
            {
                var option = GetCommonSetting();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
                option.DisplayLinkToIndividualPages = false;

                return option;
            }
        }

        public static PagedListRenderOptions PageNumbersOnly
        {
            get
            {
                var option = GetCommonSetting();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Never;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Never;
                option.DisplayEllipsesWhenNotShowingAllPageNumbers = false;

                return option;
            }
        }

        public static PagedListRenderOptions OnlyShowFivePagesAtATime
        {
            get
            {
                var option = GetCommonSetting();

                option.DisplayLinkToFirstPage = PagedListDisplayMode.Never;
                option.DisplayLinkToLastPage = PagedListDisplayMode.Never;
                option.DisplayLinkToPreviousPage = PagedListDisplayMode.Always;
                option.DisplayLinkToNextPage = PagedListDisplayMode.Always;
                option.MaximumPageNumbersToDisplay = 5;

                return option;
            }
        }
    }
}
