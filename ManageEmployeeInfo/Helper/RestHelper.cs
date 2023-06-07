using ManageEmployeeInfo.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ManageEmployeeInfo.Helper
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://gorest.co.in/public/v2/users";


        #region Get All Employee List
        /// <summary>
        /// To List All Employees
        /// </summary>
        /// <returns>
        /// Returns json string
        /// </returns>
        public static async Task<string> GetAllEmployee()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiToken = MyApiConfig.GetApiToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
                using (HttpResponseMessage response = await client.GetAsync(baseURL))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        #endregion

        #region Search By Id
        /// <summary>
        /// To Search an Employee with Employee Id
        /// </summary>
        /// <returns>
        /// Returns json string
        /// </returns>
        public static async Task<string> SearchById(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiToken = MyApiConfig.GetApiToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "/" + id))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }
        #endregion

        #region Search By Name
        /// <summary>
        /// To List All Employees whose name contains the given word
        /// </summary>
        /// <returns>
        /// Returns json string
        /// </returns>
        public static async Task<string> SearchByName(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                string apiToken = MyApiConfig.GetApiToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "?name=" + name))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }
        #endregion

        #region Add an Employee
        /// <summary>
        /// To Add an Employee
        /// </summary>
        /// <returns>
        /// Returns json string
        /// </returns>
        public static async Task<string> AddEmployee(EmployeeInfo empInfo)
        {
            using (HttpClient client = new HttpClient())
            {

                var ApiToken = MyApiConfig.GetApiToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", ApiToken);

                var inputData = new Dictionary<string, object>
                {
                        { "name", empInfo.Name },
                        { "email", empInfo.Email },
                        { "gender", empInfo.Gender },
                        { "status", empInfo.Status }
                };

                var json = JsonConvert.SerializeObject(inputData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage response = await client.PostAsync(baseURL + "", content))
                {
                    using (HttpContent httpContent = response.Content)
                    {
                        string data = await httpContent.ReadAsStringAsync();
                        if (data.Contains("invalid"))
                        {
                            MessageBox.Show(data);
                            return null;
                        }
                        return data;

                    }
                }
            }

        }
        #endregion

        #region Update Employee details
        /// <summary>
        /// To Update the Employee details
        /// </summary>
        /// <returns>
        /// Returns json string
        /// </returns>
        public static async Task<string> UpdateEmployee(EmployeeInfo empInfo)
        {
            var inputData = new Dictionary<string, object>
            {
                {"id",empInfo.Id},
                {"name",empInfo.Name},
                {"email",empInfo.Email},
                {"gender",empInfo.Gender},
                {"status",empInfo.Status}
            };

            var content = JsonConvert.SerializeObject(inputData);
            var buffer = Encoding.UTF8.GetBytes(content);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (HttpClient client = new HttpClient())
            {
                string apiToken = MyApiConfig.GetApiToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
                using (HttpResponseMessage response = await client.PutAsync(baseURL + "/" + empInfo.Id, byteContent))
                {
                    using (HttpContent httpcontent = response.Content)
                    {
                        string data = await httpcontent.ReadAsStringAsync();
                        if (data.Contains("invalid"))
                        {
                            MessageBox.Show(data);
                            return null;
                        }
                        return data;
                    }
                }
            }
        }
        #endregion

        #region Get Details By Page
        /// <summary>
        /// To Navigate to the given page
        /// </summary>
        /// <returns>
        /// Returns json string
        /// </returns>
        public static async Task<string> GoToPage(string pageno)
        {

            if (Convert.ToInt32(pageno) >= 280)
            {
                pageno = "280";
            }
            using (HttpClient client = new HttpClient())
            {
                string apiToken = MyApiConfig.GetApiToken();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "?page=" + pageno))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        #endregion

        #region Delete Employee Details
        /// <summary>
        /// To Delete an employee detail with Employee Id
        /// </summary>
        /// <returns>
        /// Returns json string
        /// </returns>
        public static async Task<string> DeleteEmployee(int id)
        {

            using (HttpClient client = new HttpClient())
            {
                string apiToken = MyApiConfig.GetApiToken();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
                using (HttpResponseMessage response = await client.DeleteAsync(baseURL + "/" + id))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }

            return string.Empty;
        }
        #endregion

        #region Formattting JSON string
        /// <summary>
        /// To Parse the json string
        /// </summary>
        /// <returns>
        /// Returns parsed json
        /// </returns>
        public static string JsonFormat(string jsonString)
        {
            JToken parseJson = JToken.Parse(jsonString);

            return parseJson.ToString(Newtonsoft.Json.Formatting.Indented);

        }
        #endregion

        #region Export Employee Data into Excel
        /// <summary>
        /// To Export the data into excel sheet
        /// </summary>
        /// <param name="gridView"></param>
        /// <returns></returns>
        public static bool ExportFile(DataGridView gridView)
        {
            bool exported = false;
            // Create new SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.ShowDialog();

            // If the user clicked OK
            if (saveFileDialog.FileName != "")
            {
                // Create new file and write headers
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false);
                StringBuilder sb = new StringBuilder();
                for (int k = 0; k < gridView.Columns.Count; k++)
                {
                    sb.Append(gridView.Columns[k].HeaderText);
                    sb.Append("\t");
                }
                sw.WriteLine(sb.ToString());

                // Write data to file
                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    sb = new StringBuilder();
                    for (int k = 0; k < gridView.Columns.Count; k++)
                    {
                        sb.Append(gridView.Rows[i].Cells[k].Value.ToString());
                        sb.Append("\t");
                    }
                    sw.WriteLine(sb.ToString());
                }

                // Close file and show message
                sw.Close();
                MessageBox.Show("Data exported to " + saveFileDialog.FileName + " successfully.");

            }
            return exported;
        }
        #endregion
    }

}

