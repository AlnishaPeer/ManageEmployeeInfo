using Microsoft.VisualStudio.TestTools.UnitTesting;
using ManageEmployeeInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageEmployeeInfo.Model;
using ManageEmployeeInfo.Helper;
using Newtonsoft.Json;
using System.Configuration;

namespace ManageEmployeeInfo.Tests
{
    [TestClass()]
    public class ManageEmployeeTest
    {
        [TestMethod()]
        public async Task GetAllTest()
        {
            try
            {
                var jsonResponse = await RestHelper.GetAllEmployee();
                var employeeResponse = JsonConvert.DeserializeObject<List<EmployeeInfo>>(jsonResponse);
                Assert.IsNotNull(employeeResponse);
                Assert.IsTrue(employeeResponse.Any());
            }
            catch (NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [TestMethod()]
        public async Task AddEmployeeTest()
        {
            EmployeeInfo empinfo = new EmployeeInfo()
            {
                Name = "usertest",
                Email = "usertestnew@gmail.com",
                Gender = "male",
                Status = "inactive"
            };
            try
            {
                var jsonResponse = await RestHelper.AddEmployee(empinfo);
                var employee = JsonConvert.DeserializeObject<EmployeeInfo>(jsonResponse);
                Assert.AreEqual(empinfo.Name, employee.Name);
                Assert.AreEqual(empinfo.Email, employee.Email);
                Assert.AreEqual(empinfo.Gender, employee.Gender);
                Assert.AreEqual(empinfo.Status, employee.Status);
            }
            catch (NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [TestMethod()]
        public async Task UpdateEmployeeTest()
        {

            EmployeeInfo empinfo = new EmployeeInfo()
            {
                Id = 2565231,
                Name = "Akshat Khatri CPA",
                Email = "khatri_akshat_cpa@schinner.com",
                Gender = "male",
                Status = "inactive"
            };
            try
            {
                var jsonResponse = await RestHelper.UpdateEmployee(empinfo);
                var employee = JsonConvert.DeserializeObject<EmployeeInfo>(jsonResponse);
                Assert.AreEqual(empinfo.Name, employee.Name);
                Assert.AreEqual(empinfo.Email, employee.Email);
                Assert.AreEqual(empinfo.Gender, employee.Gender);
                Assert.AreEqual(empinfo.Status, employee.Status);
            }
            catch (NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [TestMethod()]
        public async Task DeleteEmployeeTest()
        {
            try
            {
                var jsonResponse = await RestHelper.DeleteEmployee(2565232);
                var employee = JsonConvert.DeserializeObject<EmployeeInfo>(jsonResponse);
                Assert.IsNull(employee);
            }
            catch (NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [TestMethod()]
        public async Task SearchById()
        {
            try
            {
                var jsonResponse = await RestHelper.SearchById(2565225);
                var employee = JsonConvert.DeserializeObject<EmployeeInfo>(jsonResponse);
                Assert.IsNotNull(employee.Id);
                Assert.IsNotNull(employee.Name);
                Assert.IsNotNull(employee.Email);
                Assert.IsNotNull(employee.Gender);
                Assert.IsNotNull(employee.Status);
            }
            catch (NullReferenceException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [TestMethod()]
        public async Task SearchByNameTest()
        {

            try
            {
                var jsonResponse = await RestHelper.SearchByName("bandhu");
                var employee = JsonConvert.DeserializeObject<List<EmployeeInfo>>(jsonResponse);
                Assert.IsNotNull(employee);
                Assert.IsTrue(employee.Any());
            }
            catch (ArgumentException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [TestMethod()]
        public async Task GetByPageTest()
        {
            try
            {
                var jsonResponse = await RestHelper.GoToPage("100");
                var employee = JsonConvert.DeserializeObject<List<EmployeeInfo>>(jsonResponse);
                Assert.IsNotNull(employee);
                Assert.IsTrue(employee.Count > 1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}