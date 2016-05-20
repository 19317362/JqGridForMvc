/****************************************************
** ���ߣ� Halower (QQ:121625933)
** ��ʼʱ�䣺2015-02-01
** ������jqGrid��չ �ӱ��
*****************************************************/

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace HalowerHub.JqGrid
{
    public class SubGridTable
    {
        public SubGridTable(params GridColumn[] subGridConfig)
        {
            var columns = new List<GridColumn>();
            columns.AddRange(subGridConfig);
            GridColumns = columns;
        }

        [JsonIgnore]
        public List<GridColumn> GridColumns { get; set; }

        #region ����

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string[] ColNames
        {
            get { return GridColumns.ToList().Select(c => c.DisplayName).ToArray(); }
        }

        [JsonProperty("width")]
        public int[] ColWidths
        {
            get { return GridColumns.ToList().Select(c => c.Width ?? 20).ToArray(); }
        }

        [JsonProperty("align")]
        public string[] Aligns
        {
            get { return GridColumns.ToList().Select(c => c.Align ?? "right").ToArray(); }
        }
        #endregion
    }
}