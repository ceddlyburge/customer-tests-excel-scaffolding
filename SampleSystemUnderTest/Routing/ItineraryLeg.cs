﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSystemUnderTest.Routing
{
    public class ItineraryLeg : IItineraryLeg
    {
        public ItineraryLeg(string origin, string destination)
        {
            Origin = origin;
            Destination = destination;
        }

        public string Origin { get; }
        public string Destination { get; }
    }
}
