using System;
using System.Collections.Generic;
using Navigation;

namespace Assistance
{
    public class PostfixTemplates
    {
        // new, ret
        public Car CreateCar (int seats, int maximumVelocity)
        {
            throw new NotImplementedException();
        }

        // foreach, notnull, check seats, yield
        public IEnumerable<IVehicle> GetBigVehicles (IVehicle[] vehicles)
        {
            throw new NotImplementedException();
        }
    }
}