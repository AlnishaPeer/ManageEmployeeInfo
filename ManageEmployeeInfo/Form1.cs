using ManageEmployeeInfo.Helper;
using ManageEmployeeInfo.Model;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageEmployeeInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Display All Employee Details
        /// <summary>
        /// To List All Employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_GetAll_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            txt_Response.Text = "";
            txt_Page.Text = "";
            var jsonResponse = await RestHelper.GetAllEmployee();
            var employeeResponse = JsonConvert.DeserializeObject<List<EmployeeInfo>>(jsonResponse);
            if (employeeResponse != null)
            {
                dataGridView1.DataSource = employeeResponse;
            }
            else
            {
                lbl_Message.Text = "Sorry! Couldn't display Employee details";
                lbl_Message.ForeColor = Color.Red;
            }
        }
        #endregion

        #region Search Employee By Id
        /// <summary>
        /// To search an employee with Employee Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_SearchById_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            txt_Response.Text = "";
            txt_Page.Text = "";
            dataGridView1.DataSource = null;
            if (txt_EmpId.Text == string.Empty)
            {
                lbl_Message.Text = "Please Enter the Employee Id";
                lbl_Message.ForeColor = Color.Red;
            }
            else
            {
                int empId = Convert.ToInt32(txt_EmpId.Text);
                if (empId <= 0)
                {
                    lbl_Message.Text = "Please Enter the valid Employee Id";
                    lbl_Message.ForeColor = Color.Red;
                }
                else
                {
                    var jsonResponse = await RestHelper.SearchById(empId);
                    var employeeResponse = JsonConvert.DeserializeObject<EmployeeInfo>(jsonResponse);
                    clearAllControl();
                    if (employeeResponse != null && employeeResponse.Id != 0)
                    {
                        txt_Response.Text = "Employee Id : " + employeeResponse.Id.ToString();
                        txt_Response.Text += Environment.NewLine + "Name : " + employeeResponse.Name;
                        txt_Response.Text += Environment.NewLine + "Email : " + employeeResponse.Email;
                        txt_Response.Text += Environment.NewLine + "Gender : " + employeeResponse.Gender;
                        txt_Response.Text += Environment.NewLine + "Status : " + employeeResponse.Status;
                    }
                    else
                    {
                        lbl_Message.Text = "Sorry! Couldn't find the Employee Id";
                        lbl_Message.ForeColor = Color.Red;
                    }
                }
            }
        }
        #endregion

        #region Add an Employee details
        /// <summary>
        /// To add an employee record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_Add_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            txt_Response.Text = "";
            txt_Page.Text = "";
            dataGridView1.DataSource = null;
            EmployeeInfo empInfo = new EmployeeInfo();
            empInfo.Name = txt_Name.Text;
            empInfo.Email = txt_Email.Text;
            empInfo.Gender = txt_Gender.Text;
            empInfo.Status = txt_Stat.Text;
            if (empInfo.Name != "" && empInfo.Status != "" && empInfo.Email != "" && empInfo.Gender != "")
            {
                var response = await RestHelper.AddEmployee(empInfo);
                if (response != null)
                {
                    var employeeResponse = JsonConvert.DeserializeObject<EmployeeInfo>(response);
                    if (employeeResponse != null && employeeResponse.Id != 0)
                    {
                        clearAllControl();
                        txt_Response.Text = RestHelper.JsonFormat(response);
                        lbl_Message.Text = "Employee data is successfully added.";
                        lbl_Message.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl_Message.Text = "Couldn't add the Employee data!";
                        lbl_Message.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbl_Message.Text = "Please provide data in correct format";
                    lbl_Message.ForeColor = Color.Red;
                }
            }
            else
            {
                lbl_Message.Text = "Enter all values to add an employee";
                lbl_Message.ForeColor = Color.Red;
            }
        }
        #endregion

        #region Update Employee details
        /// <summary>
        /// To update an employee record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_Update_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            txt_Response.Text = "";
            txt_Page.Text = "";
            dataGridView1.DataSource = null;
            EmployeeInfo empInfo = new EmployeeInfo();
            if (txt_EmpId.Text == string.Empty)
            {
                lbl_Message.Text = "Please Enter the Employee Id";
                lbl_Message.ForeColor = Color.Red;
            }
            else
            {
                empInfo.Id = Convert.ToInt32(txt_EmpId.Text);
                empInfo.Name = txt_Name.Text;
                empInfo.Email = txt_Email.Text;
                empInfo.Gender = txt_Gender.Text;
                empInfo.Status = txt_Stat.Text;
                if (empInfo.Id != 0 && (empInfo.Name != "" | empInfo.Status != "" | empInfo.Email != "" | empInfo.Gender != ""))
                {
                    var response = await RestHelper.UpdateEmployee(empInfo);
                    if (response != null)
                    {
                        var employeeResponse = JsonConvert.DeserializeObject<EmployeeInfo>(response);
                        if (employeeResponse != null)
                        {
                            clearAllControl();
                            txt_Response.Text = RestHelper.JsonFormat(response);
                            lbl_Message.Text = "Employee data is successfully updated.";
                            lbl_Message.ForeColor = Color.Green;

                        }
                        else
                        {
                            lbl_Message.Text = "Couldn't update the Employee data!";
                            lbl_Message.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lbl_Message.Text = "Please provide data in correct format";
                        lbl_Message.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lbl_Message.Text = "Enter all values to update an employee";
                    lbl_Message.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region Get Employee Details by Page
        /// <summary>
        /// To navigate to given page number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_Page_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            txt_Response.Text = "";
            dataGridView1.DataSource = null;
            string pageNo = txt_Page.Text;
            if (pageNo == "0" | pageNo == string.Empty)
            {
                lbl_Message.Text = "Please Enter the Page Number";
                lbl_Message.ForeColor = Color.Red;
            }
            else
            {
                var jsonResponse = await RestHelper.GoToPage(pageNo);
                var employeeResponse = JsonConvert.DeserializeObject<List<EmployeeInfo>>(jsonResponse);
                if (employeeResponse != null)
                {
                    dataGridView1.DataSource = employeeResponse;
                }
                else
                {
                    lbl_Message.Text = "Sorry! Couldn't navigate to the page";
                    lbl_Message.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region Delete an employee record
        /// <summary>
        /// To delete an employee record with Employee Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            txt_Response.Text = "";
            txt_Page.Text = "";
            dataGridView1.DataSource = null;
            if (txt_EmpId.Text != string.Empty)
            {
                int empId = Convert.ToInt32(txt_EmpId.Text);
                if (empId <= 0)
                {
                    lbl_Message.Text = "Please Enter the valid Employee Id";
                    lbl_Message.ForeColor = Color.Red;
                }
                else
                {
                    var jsonResponse = await RestHelper.DeleteEmployee(empId);
                    var employeeResponse = JsonConvert.DeserializeObject<EmployeeInfo>(jsonResponse);

                    if (employeeResponse == null)
                    {
                        lbl_Message.Text = "Employee Data is deleted successfully!";
                        lbl_Message.ForeColor = Color.Green;
                        clearAllControl();

                    }
                    else
                    {
                        txt_Response.Text = RestHelper.JsonFormat(jsonResponse);
                        if (txt_Response.Text.Contains("Resource not found"))
                        {
                            lbl_Message.Text = "Couldn't find the Employee data.";
                            lbl_Message.ForeColor = Color.Red;
                        }
                    }
                }
            }
            else
            {
                lbl_Message.Text = "Please Enter the Employee Id";
                lbl_Message.ForeColor = Color.Red;
            }

        }
        #endregion

        #region Search Employees by Name
        /// <summary>
        /// To list all employee whose name contains the given word
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_SearchName_Click(object sender, EventArgs e)
        {
            lbl_Message.Text = "";
            txt_Response.Text = "";
            txt_Page.Text = "";
            string empName = txt_Name.Text;
            if (empName == string.Empty | empName == null)
            {
                lbl_Message.Text = "Please Enter the Name to be searched";
                lbl_Message.ForeColor = Color.Red;
            }
            else
            {
                var jsonResponse = await RestHelper.SearchByName(empName);
                var employeeResponse = JsonConvert.DeserializeObject<List<EmployeeInfo>>(jsonResponse);
                if (employeeResponse != null && employeeResponse.Count != 0)
                {
                    dataGridView1.DataSource = employeeResponse;
                }
                else
                {
                    lbl_Message.Text = "Sorry! Couldn't find the employee with the given name";
                    lbl_Message.ForeColor = Color.Red;
                }
            }
        }
        #endregion

        #region To Refresh all Controls
        /// <summary>
        /// To Refresh all textbox values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_EmpId.Clear();
            txt_Name.Clear();
            txt_Email.Clear();
            txt_Gender.Clear();
            txt_Stat.Clear();
            txt_Page.Clear();
            txt_Response.Clear();
            dataGridView1.DataSource = null;
            lbl_Message.Text = "";
        }
        #endregion
        private void clearAllControl()
        {

            txt_EmpId.Clear();
            txt_Name.Clear();
            txt_Email.Clear();
            txt_Gender.Clear();
            txt_Stat.Clear();
            txt_Page.Clear();
            txt_Response.Clear();
            dataGridView1.DataSource = null;

        }

        #region Export Employee Data
        /// <summary>
        /// Export Employee Data to Excel Sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.ColumnCount != 0)
            {

                RestHelper.ExportFile(dataGridView1);
            }
            else
            {
                lbl_Message.Text = "Please click Get All Details / Search By Name button before Export";
                lbl_Message.ForeColor = Color.Red;
            }
        }
        #endregion




        private void txt_EmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }       

        private void txt_Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txt_Email.Text.Length > 0)

            {

                if (!rEMail.IsMatch(txt_Email.Text))

                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_Email.SelectAll();

                    e.Cancel = true;

                }

            }
        }

        private void txt_Gender_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!((txt_Gender.Text.ToLower() == "female") | (txt_Gender.Text.ToLower() == "male")))
            {
                MessageBox.Show("Enter Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Stat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!((txt_Stat.Text.ToLower() == "active") | (txt_Stat.Text.ToLower() == "inactive")))
            {
                MessageBox.Show("Status should be active/inactive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}