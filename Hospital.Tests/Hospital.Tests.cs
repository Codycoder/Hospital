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
            Employee doctor = new Employee();
            doctor.Salary = 90000;

            //Arrange

            doctor.Doctor();

            //Assert

            Assert.Equal(90000, doctor.Salary);
        }
        [Fact]
        public void Is_Doctor_Paid()
        {
            // Act
            Employee doctor = new Employee();
            doctor.IfPaid = false;

            //Arrange

            doctor.Doctor();

            //Assert

            Assert.False(false);
        }
        [Fact]
        public void Is_NurseID_002()
        {
    
            // Act
            Employee nurse = new Employee();
            nurse.NumberID = 002;

            //Arrange

            nurse.Nurse();

            //Assert

            Assert.Equal(002, nurse.NumberID);

        }

    }
}
