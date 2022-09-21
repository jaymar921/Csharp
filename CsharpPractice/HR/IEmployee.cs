using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPractice.HR
{
    public interface IEmployee
    {
        double ReceiveWage();
        void GiveBonus();
        void PerformWork();
        void StopWorking();
        void DisplayEmployeeDetails();
        void GiveCompliment();
    }
}
