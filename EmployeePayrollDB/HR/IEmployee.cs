

namespace EmployeePayrollDB.HR
{
    public interface IEmployee
    {
        string GeneratePayroll();
        void ShowEmployeeData();
        void Work();
        void Work(int hours);
    }
}
