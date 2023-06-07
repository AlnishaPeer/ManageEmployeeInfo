# ManageEmployeeInfo
Windows Forms Application for managing Employee Details.
User can perform CRUD operations through RESTful Service.
Controls to perform the operations 
    Buttons
    TextBoxes
    Labels
    DataGridView
    Rich TextBox
 Function :
  1. Get All Details          
          - Button actions are given in Form1.cs file and API calls and sending the response are handled in Helper class.
          - Url - https://gorest.co.in/public-api/users/
          - All Employee Details are fetched and displayed in DataGridView.
  2. Search By Id
          - User have to enter the employee Id in the Employee Id Textbox and sent to Helper class to fetch the corresponding data through API call.
          - Url - https://gorest.co.in/public-api/users/empId
          - If Employee Id is found - Displays Employee Details in Text Box.
          - If Employee Id not found - Dsplays Error Message.
  3. Search By Name
          - User enters the name in the Name TextBox and that is sent to Helper class to fetch all records whose Employee Name contains the given word.
          - Url - https://gorest.co.in/public-api/users?name=empname
          - If Name is found - Displays Employee Details in DataGridView.
          - If Name is not found - Dsplays Error Message.
  4. Add
          - User enters Employee Id, Name, Email, Gender and Status and the Employee Object is sent to Helper Class.
          - PostAsync - Inserts the records 
          - Url - https://gorest.co.in/public-api/users/
  5. Update
          - User enters Employee Id, Name, Email, Gender and Status and the Employee Object is sent to Helper Class.
          - PutAsync - Update the specific record 
          - Url - https://gorest.co.in/public-api/users/empId
  6. Delete
          - User enters Employee Id and the data is sent to Helper Class.
          - DeleteAsync - Update the specific record 
          - Url - https://gorest.co.in/public-api/users/empId
  7. Page
          - User gives the page number to fetch records from particular page.
          - All records from the given page is displayed in DataGridView.
          - Url - https://gorest.co.in/public-api/users?page=2
  8. Refresh
          - Clears all controls.
  9. Export
          - On clicking Export button, the Employee list from the grid view will be exported in Excel sheet.

Packages installed 
  - Newtonsoft.Json 13.0.3
