﻿using static System.Reflection.MethodBase;
using CustomerTestsExcel;
using SampleSystemUnderTest.Calculator;
using System;
using System.Collections.Generic;

namespace SampleTests.Setup
{
    public partial class SpecificationSpecificUnderscore : ReportsSpecificationSetup
    {
        public readonly int A_Result = 1;

        internal void Do_Nothing()
        {
            // this test it so checks that everything compiles / round trips, it is not trying to test the running code, so no need to do anything here.
        }

    }
}