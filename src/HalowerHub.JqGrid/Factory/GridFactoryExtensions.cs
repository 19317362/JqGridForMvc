/****************************************************
** ���ߣ� Halower (QQ:121625933)
** ��ʼʱ�䣺2015-03-21
** ������jqGrid��ѯ��չ 
*****************************************************/

using System.Web.Mvc;

namespace HalowerHub.JqGrid 
{
    /// <summary>
    ///     Grid ������չ������
    /// </summary>
    public static class GridFactoryExtensions
    {
        /// <summary>
        ///    Grid
        /// </summary>
        /// <param name="htmlHelper">Html ����</param>
        /// <returns>Grid ����</returns>
        public static GridFacotory JqGridKit(this HtmlHelper htmlHelper)
        {
            return new GridFacotory(htmlHelper);
        }

        /// <summary>
        ///   Grid
        /// </summary>
        /// <typeparam name="TModel">ģ������</typeparam>
        /// <param name="htmlHelper">Html ����</param>
        /// <returns>Grid ����</returns>
        public static GridFacotory<TModel> JqGridKit<TModel>(this HtmlHelper<TModel> htmlHelper)
        {
            return new GridFacotory<TModel>(htmlHelper);
        }
    }
}