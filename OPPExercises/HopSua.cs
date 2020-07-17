using System;
using System.Collections.Generic;
using System.Text;

namespace OPPExercises
{
    public class HopSua : DoVat
    {
        public override void Report()
        {
            Console.WriteLine("I'm a milk box");
        }

        public override double TinhDientich()
        {
            return 0;
        }
        public int TinhSoGocNhon()
        {
            var z = 100;
            return 0;

        }
    }
}
