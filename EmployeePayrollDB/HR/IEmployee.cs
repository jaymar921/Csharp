

namespace EmployeePayrollDB.HR
{
    public interface IEmployee
    {
        int GeneratePayroll();
        void ShowEmployeeData();
        void Work();
        void Work(int hours);
    }
}
