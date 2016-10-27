namespace Csharp.DataStructure.LinarList.StudentScore
{
    /// <summary>
    /// 学生结点(代表学生个体)
    /// </summary>
    public class StudentNode
    {
        /// <summary>
        /// 学号 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// 禁用默认构造函数
        /// </summary>
        private StudentNode() { }
        /// <summary>
        /// 非默认构造函数
        /// </summary>
        /// <param name="studentId">学号</param>
        /// <param name="studentName">姓名</param>
        /// <param name="studentScore">分数</param>
        public StudentNode(string studentId, string studentName, int studentScore)
        {
            Id = studentId;
            Name = studentName;
            Score = studentScore;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Score;
        }
    }
}
