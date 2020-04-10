using Clinic.DAL;
using Clinic.DBContext;
using Clinic.Model;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Clinic.Test
{
    public class Tests
    {
        PatientRepository PatientRepository;
        [SetUp]
        public void Setup()
        {
            PatientRepository = new PatientRepository();
        }

        [Test]
        public void Add_AddPatient_ReturnPatientCreated_()
        {
            Patient patient = new Patient()
            {
                FullName = "Moneim",
                Age = 12,
                Address = "Menia",
                Phone = "01110706791",
                GenderId = 1
            };

            PatientRepository.Add(patient);
            PatientRepository.save();

            TestContext.Write(patient.PatientId);
            Assert.That(patient.PatientId, Is.Not.Zero);
        }
        [Test]
        public void Delete_MakePatientIsDeletedTrue_DeletedISTrue()
        {
            Patient patient = PatientRepository.GetAll().FirstOrDefault();
            PatientRepository.Remove(patient.PatientId);
            Assert.That(patient.IsDeleted, Is.True);
        }
        [Test]
        public void GetAll_GetAllPatientFromDB_reutrnAllPatients()
        {
            var patients = PatientRepository.GetAll();
            Assert.That(patients.Count(), Is.Not.Zero);
        }
        [Test]
        public void GetPatietnt_SearchAboutPatient_ReturnPatient()
        {
            Patient patient = PatientRepository.GetAll().FirstOrDefault();
            Patient p =  PatientRepository.Find(patient.PatientId);
            Assert.That(p, Is.Not.Null);
          
        }
        [Test]
        public void Edit()
        {
            Patient patient = PatientRepository.GetAll().FirstOrDefault();


            //var samePatient = PatientRepository.Find(patient.PatientId);
            //Assert.That(patient.FullName,Is.EqualTo(patient.FullName));
            Assert.Pass(patient.PatientId.ToString());

        }
    }
}