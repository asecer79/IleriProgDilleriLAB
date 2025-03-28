using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Abstraction.Interface2.Abstracts;

namespace Week6.Abstraction.Interface2.Concretes
{
    // Temel sınıf

    // Ek arayüzler

    // Kalıtım ve uygulama birlikte

    public class ClassicalCar : Vehicle, IAutonomous
    {
        public int AutoPilotVersion { get; }
        public void EnableAutoPilot()
        {
            throw new NotImplementedException();
        }
    }
}
