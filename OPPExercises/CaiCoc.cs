using System;
using System.Collections.Generic;
using System.Text;

namespace OPPExercises
{
    public class CaiCoc : DoVat
    {
        public override void Report()
        {
            Console.WriteLine("I'm a cup");
        }

        public override double TinhDientich()
        {
            return 0;
        }
    }
}
