//参考链接：https://www.cnblogs.com/hnsongbiao/p/5636076.html

using System;
using System.Threading;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("test.xml");

            XmlElement root = null;
            root = doc.DocumentElement;

            XmlNodeList listNodes = null;
            listNodes = root.SelectNodes("/bookstore/book/price");//绝对路径
            foreach (XmlNode node in listNodes)
            {
                Console.WriteLine(node.Name);
                Console.WriteLine(node.InnerText);
            }
            Console.WriteLine();

            var nodes1 = root.SelectNodes("//title");//匹配xml文件中所有元素
            foreach (XmlNode  item in nodes1)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.InnerText);
            }
            Console.WriteLine();

            var nodes2 = root.SelectNodes("/bookstore/book/*/age");//匹配book的子节点的子节点（孙子节点）为age的元素
            foreach (XmlNode node in nodes2)
            {
                Console.WriteLine(node.Name);
                Console.WriteLine(node.InnerText);
            }
            Console.WriteLine();

            var nodes3 = root.SelectNodes("/*/*/age");//匹配第三级节点为age的元素
            foreach (XmlNode node in nodes3)
            {
                Console.WriteLine(node.Name);
                Console.WriteLine(node.InnerText);
            }
            Console.WriteLine();

            var nodes4 = root.SelectNodes("//@name");//获取属性值，属性都以@开头
            foreach (XmlNode node in nodes4)
            {
                Console.WriteLine(node.Name);
                Console.WriteLine(node.InnerText);
            }
            Console.WriteLine();

            var nodes5 = root.SelectNodes("//author[@country]/age");//选取具有country属性的author节点的age节点
            foreach (XmlNode node in nodes5)
            {
                Console.WriteLine(node.Name);
                Console.WriteLine(node.InnerText);
            }
            Console.WriteLine();

            var nodes6 = root.SelectNodes("//*[@*]");//   "//*[@*]"选取所有属性的节点
            foreach (XmlNode node in nodes6)
            {
                Console.WriteLine(node.Name);
                Console.WriteLine(node.InnerText);
            }


            Console.ReadKey();
        }
    }


}
