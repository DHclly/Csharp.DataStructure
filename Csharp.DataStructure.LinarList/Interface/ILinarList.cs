namespace Csharp.DataStructure.LinarList.Interface
{
    /// <summary>
    /// 线性表接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ILinarList<T>
    {
        /// <summary>
        /// 插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="position"></param>
        void InsertNode(T node, int position);
        /// <summary>
        /// 在末尾插入节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        void InsertNode(T node);
        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="position"></param>
        void DeleteNode(int position);
        /// <summary>
        /// 通过位置搜索节点
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        T SearchNode(int position);
        /// <summary>
        /// 通过结点内容搜索节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        T SearchNode(T node);
        /// <summary>
        /// 获得长度
        /// </summary>
        /// <returns></returns>
        int GetLength();
        /// <summary>
        /// 清空
        /// </summary>
        void Clear();
        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
    }
}
