/****************************************************
** ���ߣ� Halower (QQ:121625933)
** ��ʼʱ�䣺2015-02-01
** ������jqGrid��չ����
*****************************************************/

using Newtonsoft.Json;

namespace HalowerHub.JqGrid
{
    public class SubGridModel
    {
        [JsonProperty("name")]
        public string[] FiledNames { get; set; }

        [JsonProperty("width")]
        public int[] FiledWidths { get; set; }

        [JsonProperty("align")]
        public string[] FiledAligns { get; set; }

        [JsonProperty("params")]
        public string[] Params { get; set; }
    }
}