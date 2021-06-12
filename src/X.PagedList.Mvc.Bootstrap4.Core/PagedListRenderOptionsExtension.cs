using X.PagedList.Web.Common;

namespace X.PagedList.Mvc.Bootstrap4.Core
{
    public static class PagedListRenderOptionsExtension
    {
        /// <summary>
        /// Set bootstrap4 style for raw <see cref="PagedListRenderOptions"/>
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static PagedListRenderOptions ApplyBootstrap4Style(this PagedListRenderOptions options)
        {
            options.LiElementClasses = new[] { "page-item" };
            options.PageClasses = new[] { "page-link" };

            // Due to no way change Ellipses element class, try setting EllipsesElementClass but fail, so disable Ellipses
            options.DisplayEllipsesWhenNotShowingAllPageNumbers = false;

            return options;
        }
    }
}
