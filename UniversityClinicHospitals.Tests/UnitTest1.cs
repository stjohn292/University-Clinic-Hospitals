using System;
using Xunit;

namespace UniversityClinicHospitals.Tests
{

    public class DoctorTests

    {
        [Fact]
        public void CreateDoctor()
        {
            Doctor doctor = new Doctor();
            doctor.EmpName = "Octogon";

            Assert.Equal("Octogon", doctor.EmpName);
        }

        [Fact]
        public void DoctorSalary()
        {
            Doctor doctor = new Doctor();

            Assert.Equal(9000, doctor.EmpSalary);
        }

        [Fact]
        public void DoctorSpecialtyArea()
        {
            Doctor doctor = new Doctor();
            doctor.SpecialtyArea = "Brain";

            Assert.Equal("Brain", doctor.SpecialtyArea);
        }

        [Fact]
        public void DoctorBeenPaid()
        {
            Doctor doctor = new Doctor();

            doctor.PaySalary();
            Assert.True(doctor.EmpBeenPaid);
        }

        [Fact]
        public void DoctorDrawsBlood()
        {
            Doctor doctor = new Doctor();
            Patient patient = new Patient();

            doctor.DrawBlood(patient);
            Assert.Equal(0, patient.BloodLevel);
        }

    }

        public class JanitorTests

        {
            [Fact]
            public void CreateJanitor()
            {
                Janitor janitor = new Janitor();
                janitor.EmpName = "Al";

                Assert.Equal("Al", janitor.EmpName);
            }

            [Fact]
            public void JanitorSalary()
            {
                Janitor janitor = new Janitor();

                Assert.Equal(40000, janitor.EmpSalary);
            }

            [Fact]
            public void JanitorIsSweeping()
            {
                Janitor janitor = new Janitor();
                janitor.IsSweeping = true;

                Assert.True(janitor.IsSweeping);
            }

            [Fact]
            public void JanitorBeenPaid()
            {
                Janitor janitor = new Janitor();

                janitor.PaySalary();
                Assert.True(janitor.EmpBeenPaid);
            }
    
        }

    public class NurseTests

    {
        [Fact]
        public void CreateNurse()
        {
            Nurse nurse = new Nurse();
            nurse.EmpName = "Amy";

            Assert.Equal("Amy", nurse.EmpName);
        }

        [Fact]
        public void NurseSalary()
        {
            Nurse nurse = new Nurse();

            Assert.Equal(50000, nurse.EmpSalary);
        }

        [Fact]
        public void NurseAssignedPatients()
        {
            Nurse nurse = new Nurse();
            nurse.NumAssignedPatients = 10;

            Assert.Equal(10, nurse.NumAssignedPatients);
        }

        [Fact]
        public void NurseBeenPaid()
        {
            Nurse nurse = new Nurse();

            nurse.PaySalary();
            Assert.True(nurse.EmpBeenPaid);
        }

        [Fact]
        public void NurseDrawsBlood()
        {
            Nurse nurse = new Nurse();
            Patient patient = new Patient();

            nurse.DrawBlood(patient);
            Assert.Equal(80, patient.BloodLevel);
        }

    }

    public class PatientTests

    {
        [Fact]
        public void CreatePatient()
        {
            Patient patient = new Patient();
            patient.PatientName = "Jim";

            Assert.Equal("Jim", patient.PatientName);
        }

        [Fact]
        public void PatientBloodLevel()
        {
            Patient patient = new Patient();

            Assert.Equal(100, patient.BloodLevel);
        }

        [Fact]
        public void PatientHealthLevel()
        {
            Patient patient = new Patient();

            Assert.Equal(100, patient.HealthLevel);
        }

        [Fact]
        public void ReceptionistBeenPaid()
        {
            Receptionist receptionist = new Receptionist();

            receptionist.PaySalary();
            Assert.True(receptionist.EmpBeenPaid);
        }

    }

    public class ReceptionistTests

    {
        [Fact]
        public void CreateReceptionist()
        {
            Receptionist receptionist = new Receptionist();
            receptionist.EmpName = "Bill";

            Assert.Equal("Bill", receptionist.EmpName);
        }

        [Fact]
        public void ReceptionistSalary()
        {
            Receptionist receptionist = new Receptionist();

            Assert.Equal(45000, receptionist.EmpSalary);
        }

        [Fact]
        public void ReceptionistOnPhone()
        {
            Receptionist receptionist = new Receptionist();
            receptionist.OnPhone = true;

            Assert.True(receptionist.OnPhone);
        }

        [Fact]
        public void ReceptionistBeenPaid()
        {
            Receptionist receptionist = new Receptionist();

            receptionist.PaySalary();
            Assert.True(receptionist.EmpBeenPaid);
        }


    }
}
