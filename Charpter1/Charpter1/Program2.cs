using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter1
{
    /****************** 16.08.23 Delegate. *********************/
    delegate void Simple1();
    delegate void Simple2(int i);
    delegate void Simple3(string j);

    public class Dele
    {
        public void A() {
            Console.WriteLine("A");
        }
        public void B(int x) {
            Console.WriteLine(x.ToString());
        }
        public void C(string y) {
            Console.WriteLine(y);
        }
    }

    public class Deltest {
        public static void Main() {
            Dele D = new Dele();
            
            Simple1 s1 = new Simple1(D.A);
            Simple2 s2 = new Simple2(D.B);
            Simple3 s3 = new Simple3(D.C);

            //16.08.23 Dele클래스의 멤버함수를 대리 실행.
            s1();
            s2(1000);
            s3("Hello");
            Console.ReadLine();
        }
    }

    
}
