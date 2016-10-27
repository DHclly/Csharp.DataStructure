using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp.DataStructure.LinarList.Interface;

namespace Csharp.DataStructure.LinarList.StudentScore
{
    public class Program
    {
        private static ILinarList<StudentNode> studentList=null;
        private static char selectFlag = '1';
        public static void Run()
        {
            Start();
            MainLoop();
        }

        private static void Start()
        {
            Console.WriteLine("没有数据校验，所以请正确输入\n请选择存储结构的类型：1.顺序表 2.单链表 3.双链表 4.循环链表：");
            selectFlag = Convert.ToChar(Console.ReadLine());
            switch (selectFlag)
            {
                //初始化顺序表
                case '1':
                    Console.Write("请输入需要存储的学生人数:");
                    int maxSize = Convert.ToInt32(Console.ReadLine());
                    studentList = new SequenceList<StudentNode>(maxSize);
                    break;
                case '2':
                    studentList = new SingleLinkedList<StudentNode>();
                    break;
                case '3':
                    studentList = new DoubleLinkedList<StudentNode>();
                    break;
                case '4':
                    studentList = new CircleLinkedList<StudentNode>();
                    break;
            }
        }

        private static void MainLoop()
        {
            while (true)
            {
                DisplayMenu();
                selectFlag = Convert.ToChar(Console.ReadLine().ToLower());
                switch (selectFlag)
                {
                    case '1':
                        {
                            char flag = default(char);
                            do
                            {
                                Console.WriteLine("请输入学号：");
                                string studentId = Console.ReadLine();
                                Console.WriteLine("请输入姓名：");
                                string studentName = Console.ReadLine();
                                Console.WriteLine("请输入成绩：");
                                int studentScore = Convert.ToInt32(Console.ReadLine());
                                StudentNode newNode = new StudentNode(studentId, studentName, studentScore);
                                studentList.InsertNode(newNode, studentList.GetLength() + 1);
                                Console.WriteLine("添加成功");
                                Console.WriteLine("还有学生成绩输入吗(Y/N)：");
                                flag = Convert.ToChar(Console.ReadLine().ToUpper());
                            } while (flag == 'Y');
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("请输入要删除学生的学号：");
                            string studentId = Console.ReadLine();
                            for (int i = 1; i <= studentList.GetLength(); i++)
                            {
                                StudentNode tempNode = studentList.SearchNode(i);
                                if (tempNode.Id == studentId)
                                {
                                    studentList.DeleteNode(i);
                                    Console.WriteLine("删除成功");
                                    break;
                                }
                            }
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("请输入要查询学生的姓名：");
                            string studentName = Console.ReadLine();
                            for (int i = 1; i <= studentList.GetLength(); i++)
                            {
                                var tempNode = studentList.SearchNode(i);
                                if (tempNode.Name == studentName)
                                {
                                    tempNode = studentList.SearchNode(i);
                                    Console.WriteLine("{0}的成绩是：{1}", tempNode.Name, tempNode.Score);
                                    break;
                                }
                            }
                            break;
                        }
                    case '4':
                        {
                            Console.WriteLine("请输入要查询学生的学号：");
                            string studentId = Console.ReadLine();
                            for (int i = 1; i <= studentList.GetLength(); i++)
                            {
                                var tempNode = studentList.SearchNode(i);
                                if (tempNode.Id == studentId)
                                {
                                    tempNode = studentList.SearchNode(i);
                                    Console.WriteLine("{0}的成绩是：{1}", tempNode.Name, tempNode.Score);
                                    break;
                                }
                            }
                            break;
                        }

                    case '5':
                        {
                            Console.WriteLine("学号\t姓名\t成绩");
                            for (int i = 1; i < studentList.GetLength() - 1; i++)
                            {
                                for (int j = 2; j < studentList.GetLength(); j++)
                                {
                                    var res = studentList.SearchNode(i).Score >
                                              studentList.SearchNode(j).Score;
                                    if (res)
                                    {
                                        var temp = studentList.SearchNode(i);
                                        studentList.InsertNode(studentList.SearchNode(j), i);
                                        studentList.InsertNode(temp, j);
                                    }
                                }
                            }
                            for (int i = 1; i <= studentList.GetLength(); i++)
                            {
                                var tempNode = studentList.SearchNode(i);
                                Console.WriteLine("{0}\t{1}\t{2}", tempNode.Id, tempNode.Name,
                                    tempNode.Score);
                            }
                            break;
                        }
                    case '6':
                        {
                            Console.WriteLine("学号\t姓名\t成绩");
                            for (int i = 1; i < studentList.GetLength() - 1; i++)
                            {
                                for (int j = 2; j < studentList.GetLength(); j++)
                                {
                                    var res = studentList.SearchNode(i).Score <
                                              studentList.SearchNode(j).Score;
                                    if (res)
                                    {
                                        var temp = studentList.SearchNode(i);
                                        studentList.InsertNode(studentList.SearchNode(j), i);
                                        studentList.InsertNode(temp, j);
                                    }
                                }
                            }
                            for (int i = studentList.GetLength(); i >= 1; i--)
                            {
                                var tempNode = studentList.SearchNode(i);
                                Console.WriteLine("{0}\t{1}\t{2}", tempNode.Id, tempNode.Name,
                                    tempNode.Score);
                            }
                            break;
                        }
                    case '7':
                        return;
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("请输入操作选项：");
            Console.WriteLine("1：添加学生成绩");
            Console.WriteLine("2：删除学生成绩");
            Console.WriteLine("3：按姓名查询学生成绩");
            Console.WriteLine("4：按学号查询学生成绩");
            Console.WriteLine("5：按升序显示所有学生成绩");
            Console.WriteLine("6：按降序显示所有学生成绩");
            Console.WriteLine("7：退出");
        }
    }
}
