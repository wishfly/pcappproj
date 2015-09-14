using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicProject
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary> Json序列化数组
        ///1 Json序列化数组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jsonArr_Click(object sender, RoutedEventArgs e)
        {
            //1.0 实体对象
            Student stu = new Student() { Age = 1, Name = "a" };
            Student stu2 = new Student() { Age = 2, Name = "b" };
            //2.0 实体数组
            Student[] strArrs = { stu, stu2 };
            //3.0 实例化实体数组
            string strSer = JsonConvert.SerializeObject(strArrs);
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
