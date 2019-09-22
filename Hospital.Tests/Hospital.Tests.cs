using System;
using Xunit;

namespace Hospital.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Doctor_Makes_Ninety_Thousand()
        {
            // Act
            Doctor doctor = new Doctor();
            doctor.Salary = 90000;

            //Arrange

            doctor.EmployeeInfo();

            //Assert

            Assert.Equal(90000, doctor.Salary);
        }
        [Fact]
        public void Is_Doctor_Paid()
        {
            // Act
            Doctor doctor = new Doctor();
            doctor.IfPaid = false;

            //Arrange

            doctor.EmployeePaid();

            //Assert

            Assert.False(false);
        }
        [Fact]
        public void Is_NurseID_002()
        {

            // Act
            Nurse nurse = new Nurse();
            nurse.NumberID = 002;

            //Arrange

            nurse.EmployeeInfo();

            //Assert

            Assert.Equal(002, nurse.NumberID);

        }

    }
}
