using X.PagedList.Mvc.Common;

namespace X.PagedList.Mvc.Bootstrap4
{
    public class Bootstrap4PagedListRenderOptions : PagedListRenderOptionsBase
    {
        private static PagedListRenderOptionsBase GetCommonSetting()
        {
            var option = new PagedListRenderOptionsBase()
            {
                LiElementClasses = new[] { "page-item" },
                PageClasses = new[] { "page-link" },

                // Due to no way change Ellipses element class, try setting EllipsesElementClass but fail, so disable Ellipses
                DisplayEllipsesWhenNotShowingAllPageNumbers = false
            };
            return option;
        }

        public static PagedListRenderOptionsBase Default
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

        public new static PagedListRenderOptionsBase ClassicPlusFirstAndLast
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

        public new static PagedListRenderOptionsBase Classic
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

        public new static PagedListRenderOptionsBase Minimal
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

        public new static PagedListRenderOptionsBase PageNumbersOnly
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

        public new static PagedListRenderOptionsBase OnlyShowFivePagesAtATime
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
