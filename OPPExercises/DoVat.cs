﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OPPExercises
{
    public abstract class DoVat
    {
        public abstract void Report();
        public abstract double TinhDientich();
        public int TinhSoGocNhon()
        {
            return 0;
        }
    }
}
