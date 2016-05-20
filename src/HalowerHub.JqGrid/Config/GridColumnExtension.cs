/****************************************************
** ���ߣ� Halower (QQ:121625933)
** ��ʼʱ�䣺2015-02-01
** ������jqGrid��չ��Ԫ������
*****************************************************/

using System.Collections.Generic;

namespace HalowerHub.JqGrid
{
    public static class GridColumnExtension
    {
        /// <summary>
        ///     �����еĳ�ʼ��ȣ�����pixels�Ͱٷֱ�
        /// </summary>
        /// <param name="width">��ʼ���</param>
        /// <returns></returns>
        public static GridColumn Width(this GridColumn col, int width)
        {
            col.Width = width;
            return col;
        }

        /// <summary>
        ///     �����ʼ��ʱ�����Ƿ�����
        /// </summary>
        public static GridColumn Hidden(this GridColumn col, bool hidden = true)
        {
            col.Hidden = hidden;
            return col;
        }

        /// <summary>
        ///     �����ֶ�λ��
        /// </summary>
        /// <param name="contentAlign">�ֶ�λ��</param>
        /// <returns></returns>
        public static GridColumn ContentAlign(this GridColumn col, string contentAlign)
        {
            col.Align = contentAlign;
            return col;
        }

        /// <summary>
        ///     �����ֶ��Ƿ�ɱ༭
        /// </summary>
        public static GridColumn Editable(this GridColumn col, ColumnEdits edittype, string editoptions, EditRules rules = null)
        {
            col.Editable = true;
            col.EditType = edittype.ToString().ToLower();
            col.Editoptions = "&{" + editoptions + "}&";
            col.EditRule = rules;
            return col;
        }
        /// <summary>
        ///   ����༭����
        /// </summary>
        /// <param name="col"></param>
        /// <param name="editRules"></param>
        /// <returns></returns>
        public static GridColumn EditRules(this GridColumn col, EditRules editRules)
        {
            col.EditRule = editRules;
            return col;
        }

        /// <summary>
        ///     ���嶨���ֶ��Ƿ�ɱ༭
        /// </summary>
        public static GridColumn Formatter(this GridColumn col, CellFormatters cellformater,Formatoption formatoption=null)
        {
            col.Formatter ="\""+cellformater.ToString().ToLower()+"\"";
            col.Formatoptions =formatoption;
            return col;
        }


        /// <summary>
        /// ������ʽ����
        /// </summary>
        /// <param name="col"></param>
        /// <param name="thousandsSeparator">ǧ��λ�ָ���</param>
        /// <param name="defautlValue">��û�����ݵ�����µ�Ĭ��ֵ</param>
        /// <returns></returns>
        public static GridColumn IntegerFormatter(this GridColumn col,string thousandsSeparator,string defautlValue=null)
        {
            col.Formatter = "\"" + CellFormatters.Integer.ToString().ToLower() + "\"";
            col.Formatoptions = new Formatoption { ThousandsSeparator = thousandsSeparator, DefaulValue = defautlValue };
            return col;
        }

        /// <summary>
        /// ���ָ�ʽ����
        /// </summary>
        /// <param name="col"></param>
        /// <param name="thousandsSeparator">ǧ��λ�ָ���</param>
        /// <param name="decimalPlaces">С������λ��</param>
        /// <param name="decimalSeparator">С���ָ��� �硱.��</param>
        /// <param name="defautlValue">��û�����ݵ�����µ�Ĭ��ֵ</param>
        /// <returns></returns>
        public static GridColumn NumberFormatter(this GridColumn col, string thousandsSeparator,string decimalPlaces=null, string decimalSeparator=null,string defautlValue = null)
        {
            col.Formatter = "\"" + CellFormatters.Number.ToString().ToLower() + "\"";
            col.Formatoptions = new Formatoption { ThousandsSeparator = thousandsSeparator, DefaulValue = defautlValue,DecimalPlaces= decimalPlaces,DecimalSeparator=decimalSeparator };
            return col;
        }

        /// <summary>
        /// ��Ǯ��ʽ����
        /// </summary>
        /// <param name="col"></param>
        /// <param name="prefix">ǰ׺</param>
        /// <param name="suffix">��׺</param>
        /// <param name="thousandsSeparator">ǧ��λ�ָ���</param>
        /// <param name="decimalPlaces">С������λ��</param>
        /// <param name="decimalSeparator">С���ָ��� �硱.��</param>
        /// <param name="defautlValue">��û�����ݵ�����µ�Ĭ��ֵ</param>
        /// <returns></returns>
        public static GridColumn CurrencyFormatter(this GridColumn col,string prefix="��", string decimalPlaces = null, string suffix=null, string thousandsSeparator=null, string decimalSeparator = null, string defautlValue = null)
        {
            col.Formatter = "\"" + CellFormatters.Currency.ToString().ToLower() + "\"";
            col.Formatoptions = new Formatoption {Prefix=prefix,Suffix=suffix,ThousandsSeparator = thousandsSeparator, DefaulValue = defautlValue, DecimalPlaces = decimalPlaces, DecimalSeparator = decimalSeparator };
            return col;
        }

        /// <summary>
        /// ʱ���ʽ����
        /// </summary>
        /// <param name="col"></param>
        /// <param name="srcformat">ԭ���ĸ�ʽ</param>
        /// <param name="newformat">�µĸ�ʽ</param>
        /// <returns></returns>
        public static GridColumn DateFormatter(this GridColumn col, string srcformat,string newformat)
        {
            col.Formatter = "\"" + CellFormatters.Date.ToString().ToLower() + "\"";
            col.Formatoptions = new Formatoption { Srcformat = srcformat, Newformat = newformat };
            return col;
        }
        /// <summary>
        /// ���Ӹ�ʽ����
        /// </summary>
        /// <param name="col"></param>
        /// <param name="baseLinkUrl">�ڵ�ǰcell�м���link��url���硱jq/query.action��</param>
        /// <param name="addParam">��baseLinkUrl��������Ĳ������硱&name=aaaa��</param>
        /// <param name="idName">Ĭ�ϻ���baseLinkUrl�����,�硱.action?id=1�塣���������idName=��name��,��ô��.action?name=1�塣����ȡֵΪ��ǰrowid</param>
        /// <returns></returns>
        public static GridColumn LinkFormatter(this GridColumn col, string baseLinkUrl=null, string addParam=null,string idName=null)
        {
            col.Formatter = "\"" + CellFormatters.Showlink.ToString().ToLower() + "\"";
            col.Formatoptions = new Formatoption { BaseLinkUrl = baseLinkUrl, addParam = addParam,IdName= idName };
            return col;
        }

        /// <summary>
        /// ��ѡ���ʽ����
        /// </summary>
        /// <param name="col"></param>
        /// <param name="disabled">�Ƿ�ѡ��</param>
        /// <returns></returns>
        public static GridColumn CheckBoxFormatter(this GridColumn col,bool disabled)
        {
            col.Formatter = "\"" + CellFormatters.Checkbox.ToString().ToLower() + "\"";
            col.Formatoptions = new Formatoption { Disabled = disabled};
            return col;
        }

        /// <summary>
        ///     ��������
        /// </summary>
        public static GridColumn Searchable(this GridColumn col, CellTypes filedType = CellTypes.String)
        {
            col.Search = true;
            col.SearchFiledType = filedType;
            col.SearchType ="text";
            return col;
        }

        public static GridColumn SelectSearchable(this GridColumn col, string selectDataUrl)
        {
            col.Search = true;
            col.SearchType ="select";
            col.SelectDataSourceUrl = selectDataUrl;
            return col;
        }


        /// <summary>
        ///     ��������
        /// </summary>
        /// <param name="columnSorts">��������</param>
        /// <returns></returns>
        public static GridColumn Sortable(this GridColumn col, ColumnSorts columnSorts = ColumnSorts.Text)
        {
            col.Sortable = true;
            col.SortType = columnSorts.ToString().ToLower();
            return col;
        }
        /// <summary>
        /// ����λ��
        /// </summary>
        /// <param name="col"></param>
        /// <param name="align"></param>
        /// <returns></returns>
        public static GridColumn TextAlign(this GridColumn col, string align)
        {
            col.Align = align;
            return col;
        }
        /// <summary>
        /// �кϲ�
        /// </summary>
        /// <param name="col"></param>
        /// <param name="align"></param>
        /// <returns></returns>
        public static GridColumn Merger(this GridColumn col)
        {

            var templete = @"&function(rowId, tv, rawObject, cm, rdata){return 'id=@FiledName'+ rowId;}&";
            col.CellAttr = templete.Replace("@FiledName", "\""+ col.Field+"\"");
            return col;
        }
    }
}
 