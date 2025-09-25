using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problems3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class TestPerson
        {
            string name;
            int age;
            public TestPerson(string name, int age)
            {
                this.name = name;
                this.age = age;
                Console.WriteLine("基底クラス");
                Console.WriteLine("名前：" + name + ", 年齢：" +age);

            }
        }
        class TestInfo : TestPerson
        {
            int height;
            int weigth;
            public TestInfo(string name, int age, int height, int weight) : base(name, age)
            {
                this.height = height;
                this.weigth = weight;
                Console.WriteLine("派生クラス");
                Console.WriteLine("身長：" + height + " , 体重：" + weigth);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // クラス型 変数名 = new クラス型(引数);
            TestPerson objTestPerson = new TestPerson("山田",20);

            TestInfo objTestInfo = new TestInfo("山田", 20,170, 60);

        }
    }
}
