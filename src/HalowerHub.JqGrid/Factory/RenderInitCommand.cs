namespace HalowerHub.JqGrid
{
    /// <summary>
    /// 
    /// </summary>
    public class RenderInitCommand
    {
        /// <summary>
        /// ���Id
        /// </summary>
        public string GridId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TableInitCommand { get; set; }
        /// <summary>
        /// �ײ���ť��ʼ��
        /// </summary>
        public string BottomNavBarInitCommand { get; set; }
        /// <summary>
        /// ��ͷ�ϲ���ʼ��
        /// </summary>
        public string GroupHeaderInitCommand { get; set; }
        /// <summary>
        /// �ϲ��г�ʼ��
        /// </summary>
        public string MergerColumnInitCommand { get; set; }

        /// <summary>
        /// ��ҳId
        /// </summary>
        public string PagerId { get; set; }
    }
}