using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter1
{
    /****************** 16.08.23 HelloWorld. *********************/
    public class MainTest {
        public void SayHello() {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        /*
        public static void Main() {
            MainTest m = new MainTest();
            m.SayHello();
        }*/
    }

    /****************** 16.08.23 Overloading. *********************/
    public class Overloading {
        public int Plus(int a, int b) {
            return (a + b);
        }
        public float Plus(float a, float b) {
            return (a + b);
        }
        /*
        public static void Main()
        {
            Overloading oc = new Overloading();
            int i = oc.Plus(3, 5);
            float j = oc.Plus(0.1f, 0.2f);
            Console.WriteLine("int sum: {0}", i);
            Console.WriteLine("float sum: {0}", j);
            Console.ReadLine();
        }*/
    }

    /****************** 16.08.23 Inheritance. *********************/
    public class GrandFather {
        public GrandFather() {
            Console.WriteLine("GrandFather");
        }
        public void SayGrandFather() {
            Console.WriteLine("SayGrandFather");
        }
    }
    public class Father : GrandFather {
        public Father() {
            Console.WriteLine("Father");
        }
        public void SayFather() {
            Console.WriteLine("SayFather");
        }
        /*
        public static void Main() {
            Father F = new Father();
            F.SayGrandFather();
            F.SayFather();
            Console.ReadLine();
        }*/
    }

    /****************** 16.08.23 Override *********************/
    public class Base {
        public void MethodA() {
            Console.WriteLine("Base");
        }
    }
    public class MethodHide : Base {
        //16.08.23 public void MethodA() { //경고발생.
        new public void MethodA() {
            Console.WriteLine("MethodHide");
        }
        /*
        public static void Main() {
            MethodHide M = new MethodHide();
            M.MethodA();
            Console.ReadLine();
        }*/
    }

    /****************** 16.08.23 Base 키워드. *********************/
    public class NewFather {
        public virtual void OverrideFunc() {
            Console.WriteLine("아버지함수.");
        }
    }
    public class NewSon : NewFather {
        public override void OverrideFunc() {
            Console.WriteLine("아들의함수.");
        }
        public void TestFunc() {
            //16.08.23 아버지함수가호출됨.
            base.OverrideFunc();
        }
        /*
        public static void Main() {
            NewSon ns = new NewSon();
            ns.OverrideFunc(); // 아들함수호출.
            ns.TestFunc(); // 아버지함수호출.
            Console.ReadLine();
        }*/
    }

    /****************** 16.08.23 상속시 생성자 타입 맞춰줘야함. *********************/
    public class BaseFather {
        private string name;
        public BaseFather(string name) {
            this.name = name;
            Console.WriteLine("base: {0}", name);
        }
    }

    public class BaseSon : BaseFather {
        public BaseSon(string str) : base(str) {

        }
        /*
        public static void Main() {
            BaseSon B = new BaseSon("Base Test Problem");
            Console.ReadLine();
        }*/
    }

    /****************** 16.08.23 abstract. 설계시. *********************/
    public abstract class A {
        private int i = 1;
        public abstract void F1();
        public abstract void F2();
        public void test() {
            Console.WriteLine(i.ToString());
        }
    }

    public class B : A {
        //16.08.23 구현하지않으면 안됨.
        public override void F1() {//16.08.23 구현하지않으면 안됨.
            Console.WriteLine("F1구현");
        }
        //16.08.23 구현하지않으면 안됨.
        public override void F2() {
            Console.WriteLine("F2구현");
        }
        /*
        public static void Main() {
            B b = new B();
            b.F1();
            b.F2();
            b.test();
            Console.ReadLine();
        }*/
    }
    /****************** 16.08.23 interface. 구현시. (+ 추상클래스 1개) *********************/
    public interface AA {
        void SayA();
    }
    public interface BB {
        void SayB();
    }
    public abstract class Top1 {
        public abstract void SayTop();
    }
    public class TopTest : Top1, AA, BB {
        public void SayA() {
            Console.WriteLine("인터페이스 AA");
        }
        public void SayB() {
            Console.WriteLine("인터페이스 BB");
        }
        public override void SayTop() {
            Console.WriteLine("추상클래스 SayTop");
        }
        /*
        public static void Main() {
            TopTest T = new TopTest();
            T.SayA();
            T.SayB();
            T.SayTop();
            Console.ReadLine();
        }*/
    }

    /****************** 16.08.23 업캐스팅. *********************/
    public class FuncA {
        public void AAA1() {
            Console.WriteLine("AAA1");
        }
        public virtual void BBB1() {
            Console.WriteLine("BBB1");
        }
    }

    public class FuncB : FuncA {
        new public void AAA1() {
            Console.WriteLine("AAA2");
        }
        public override void BBB1() {
            Console.WriteLine("BBB2");
        }
        public static void Main() {
            FuncB B = new FuncB();
            B.AAA1();  //16.08.23 "AAA2"
            B.BBB1();  //16.08.23 "BBB2"

            FuncA A = B; //16.08.23 업캐스팅발생.

            A.AAA1(); //16.08.23 "AAA1" 
            A.BBB1(); //16.08.23 "BBB2" -> virtual, override 로 오버라이드 됬을경우 자식꺼 불러옴.

            FuncA C = new FuncA();

            C.AAA1(); //16.08.23 "AAA1"
            C.BBB1(); //16.08.23 "BBB1"

            Console.ReadLine();
        }
    }
}
