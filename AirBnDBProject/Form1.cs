using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirBnDBProject
{
    public partial class Form1 : Form
    {

        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        public Form1()
        {
            InitializeComponent();
            PopulateDataGridViews();
            PopulatePropertyHostComboBox();
            PopulateBookingPropertyAddressComboBox();
            PopulateBookingUserNameComboBox();
        }

        public void PopulateDataGridViews()
        {
            usersDataGrid.DataSource = dataAccessLayer.ReadUsers().Tables[0];
            hostDataGrid.DataSource = dataAccessLayer.ReadHosts().Tables[0];
            propertyDataGrid.DataSource = dataAccessLayer.ReadProperties().Tables[0]; 
            bookingDataGrid.DataSource = dataAccessLayer.ReadBookings().Tables[0];
        }

        //Method to return an sql Error message
        public string SqlError(SqlException ex)
        {
            return ex.Message;
        }
        public void ClearFields()
        {
            txtBox_HostID.Clear();
            txtBox_HostName.Clear();
            txtBox_HostPhoneNumber.Clear();
            txtBox_PropertyAddress.Clear();
            txtBox_PropertyCountry .Clear();
            txtBox_PropertyPrice.Clear();
            txtBox_PropertyType.Clear();
            txtBox_UserFullName.Clear();
            txtBox_UserName.Clear();
            txtBox_UserPhoneNumber.Clear();
         
        }
        public void PopulatePropertyHostComboBox()
        {
            //Start with clearing the comboBox
            comboBox_PropertyHostId.Items.Clear();

            //Load all Host into a dataset from ReadHosts()
            DataSet allHosts = dataAccessLayer.ReadHosts();

            //Create for loop to fill the combobox with both ID and Name of host

            for(int i = 0; i< allHosts.Tables[0].Rows.Count; i++)
            {
                string hostId = allHosts.Tables[0].Rows[i]["HostID"].ToString();
                string hostName = allHosts.Tables[0].Rows[i]["HostName"].ToString();
                comboBox_PropertyHostId.Items.Add(hostId + ",  " + hostName);

            }

        }

        public void PopulateBookingPropertyAddressComboBox()
        {
            
            //Start with clearing the comboBox
            comboBox_BookingAddress.Items.Clear();

            //Load all Properties into a dataset from ReadProperties()
            DataSet allProperties = dataAccessLayer.ReadProperties();

            //Create for loop to fill the combobox with property addresses and country

            for (int i = 0; i < allProperties.Tables[0].Rows.Count; i++)
            {
                string propertyAddress = allProperties.Tables[0].Rows[i]["PropertyAddress"].ToString();
                string propertyCountry = allProperties.Tables[0].Rows[i]["PropertyCountry"].ToString();

                comboBox_BookingAddress.Items.Add(propertyAddress + ",  " + propertyCountry);

            }

        }

        

        public void PopulateBookingUserNameComboBox()
        {
           
            //Start with clearing the comboBox
              comboBox_BookingUsername.Items.Clear();

            //Load all Users into a dataset from ReadUsers()
            DataSet allUsers = dataAccessLayer.ReadUsers();

            //Create for loop to fill the combobox with both userName and full Name of User

            for (int i = 0; i < allUsers.Tables[0].Rows.Count; i++)
            {
                string userName = allUsers.Tables[0].Rows[i]["UserName"].ToString();
                string userFullName = allUsers.Tables[0].Rows[i]["FullName"].ToString();
                comboBox_BookingUsername.Items.Add(userName + ",  " + userFullName);

            }

        }
        //Method to splt the value of the comboBoxes
        public string SplitComboBoxValue (string ComboBoxValue)
        {
            string[] values = ComboBoxValue.Split(',');
            string value = values[0];
            return value;
        }

        public bool CheckIfFieldsAreEmpty(String[] stringArray)
        {
            foreach(string s in stringArray)
            {
                if (s == "")
                {
                    return false;
                }
            }
            return true;
        }

        //Method to generate an unique HostID
        public string GenerateHostID()
        {

            string hostID = "";
            bool check = true;
            List<string> hostIds = new List<string>();
            hostIds.Add(dataAccessLayer.GetHostIds());
           
            while (check)
            {
                int min = 100;
                int max = 9999;

                Random random = new Random();

                int hostIDNumber = random.Next(min, max) + min;

                hostID = "H" + hostIDNumber;
                check = false;
                foreach (string id in hostIds)
                {

                    if (hostID.Equals(id))
                    {
                        check = true;
                    }
                }


            }
            return hostID;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

        private void UserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if(e.ColumnIndex >= 0)
                {
                    DataGridViewRow dataGridUsersRow = this.usersDataGrid.Rows[e.RowIndex];

                    txtBox_UserName.Text = dataGridUsersRow.Cells["UserName"].Value.ToString();
                    txtBox_UserFullName.Text = dataGridUsersRow.Cells["FullName"].Value.ToString();
                    txtBox_UserPhoneNumber.Text = dataGridUsersRow.Cells["UserPhoneNumber"].Value.ToString();
                 
                }
            }
        }

   

        private void HostDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex >= 0)
                {
                    DataGridViewRow dataGridHostRow = this.hostDataGrid.Rows[e.RowIndex];

                    txtBox_HostID.Text = dataGridHostRow.Cells["HostID"].Value.ToString();
                    txtBox_HostName.Text = dataGridHostRow.Cells["HostName"].Value.ToString();
                    txtBox_HostPhoneNumber.Text = dataGridHostRow.Cells["HostPhoneNumber"].Value.ToString();

                }
            }

        }

        private void PropertyDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex >= 0)
                {
                    DataGridViewRow dataGridPropertyRow = this.propertyDataGrid.Rows[e.RowIndex];

                    txtBox_PropertyAddress.Text = dataGridPropertyRow.Cells["PropertyAddress"].Value.ToString();
                    txtBox_PropertyCountry.Text = dataGridPropertyRow.Cells["PropertyCountry"].Value.ToString();
                    txtBox_PropertyPrice.Text = dataGridPropertyRow.Cells["PropertyPrice"].Value.ToString();
                    txtBox_PropertyType.Text = dataGridPropertyRow.Cells["PropertyType"].Value.ToString();
                    comboBox_PropertyHostId.Text = dataGridPropertyRow.Cells["HostID"].Value.ToString();

                }
            }

        }
        private void BookingDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex >= 0)
                {
                    DataGridViewRow dataGridBookingRow = this.bookingDataGrid.Rows[e.RowIndex];

                    comboBox_BookingUsername.Text = dataGridBookingRow.Cells["UserName"].Value.ToString();
                    comboBox_BookingAddress.Text = dataGridBookingRow.Cells["PropertyAddress"].Value.ToString();
                    datePickerBookingStartDate.Text = dataGridBookingRow.Cells["BookingStartDate"].Value.ToString();
                    datePickerBookingEndDate.Text = dataGridBookingRow.Cells["BookingEndDate"].Value.ToString();
                    label_TbarPropertyRatingResult.Text = dataGridBookingRow.Cells["PropertyRating"].Value.ToString();

                }
            }

        }

        //Add Users Button
        private void Btn_AddUser(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[3];
                stringArray[0] = txtBox_UserName.Text;
                stringArray[1] = txtBox_UserFullName.Text;
                stringArray[2] = txtBox_UserPhoneNumber.Text;

                //Check for empty fields
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //DaL method call
                    dataAccessLayer.AddUsers(stringArray[0], stringArray[1], stringArray[2]);
                    //Populate table and combobox + clear the fields
                    PopulateDataGridViews();
                    PopulateBookingUserNameComboBox();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseUser.Text = "User: " + stringArray[0] + " has been added!";


                }
                else
                {
                    //Response to user
                    label_ErrorResponseUser.Text = "Please fill in all required fields!";

                }



            }
            catch (SqlException ex)
            {
                //Catch sqlException
                label_ErrorResponseUser.Text = SqlError(ex);
            }

        }
        //Button for updating User
        private void Btn_UpdateUser(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[3];
                stringArray[0] = txtBox_UserName.Text;
                stringArray[1] = txtBox_UserFullName.Text;
                stringArray[2] = txtBox_UserPhoneNumber.Text;

                //Check for empty fields
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //Dal method call
                    dataAccessLayer.UpdateUsers(stringArray[0], stringArray[1], stringArray[2]);
                    //Populate table and combobox + clear the fields
                    PopulateBookingUserNameComboBox();
                    PopulateDataGridViews();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseUser.Text = "User: " + stringArray[0] + " has been updated!";

                }
                else
                {
                    //Response to user
                    label_ErrorResponseUser.Text = "Please insert all fields!";
                }

            }
            catch (SqlException ex)
            {
                //Hande sqlException
                label_ErrorResponseUser.Text = SqlError(ex);
            }


        }
        //Button for deleting User
        private void Btn_DeleteUser(object sender, EventArgs e)
        {
            try
            {
                string userName = txtBox_UserName.Text;

                //Check for empty fields
                if (userName != "")
                {
                    //Dal method call
                    dataAccessLayer.DeleteUsers(userName);
                    //Populate table + clear fields
                    PopulateDataGridViews();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseUser.Text = "User: " + userName + " has been deleted!";

                } else
                {
                    //Response to user
                    label_ErrorResponseUser.Text = "Please choose an User from table to delete!";
                }

            } catch (SqlException ex)
            {
                //Handling of sqlException and response to user
                label_ErrorResponseUser.Text = SqlError(ex);
            }
           

        }

        //Add Host button
        private void Btn_AddHost(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[3];
                stringArray[0] = GenerateHostID();
                stringArray[1] = txtBox_HostName.Text;
                stringArray[2] = txtBox_HostPhoneNumber.Text;

                //Check for empty fields
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //Dal method call
                    dataAccessLayer.AddHost(stringArray[0], stringArray[1], stringArray[2]);
                    //Populate table + clear fields
                    PopulateDataGridViews();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseHost.Text = "Host: " + stringArray[1] + " has been added!";


                } else
                {
                    //Respone to user if all fields are not filled in
                    label_ErrorResponseHost.Text = "Please fill in all fields in order to add Host!(Id will be generated)";
                }

            }
            catch (SqlException ex)
            {
                //Handling sqlException and response to user
                label_ErrorResponseHost.Text = SqlError(ex);
            }
        }

        //Delete Host button
        private void Btn_DeleteHost(object sender, EventArgs e)
        {
            try
            {
                string hostID = txtBox_HostID.Text;

                //Check if there has been a host selected in order to delete
                if(hostID == "")
                {
                    //Response to user if a host has not been selected
                    label_ErrorResponseHost.Text = "Please choose a Host from table in order to delete!";

                }
                else
                {
                    //Dal method call
                    dataAccessLayer.DeleteHost(hostID);
                    //Populate Table and comboboxes + clear fields
                    PopulateDataGridViews();
                    PopulatePropertyHostComboBox();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseHost.Text = "Host: " + hostID + " has been deleted!";

                }

              

            }
            catch (SqlException ex)
            {
                //Handling sqlError and giving response to user
                label_ErrorResponseHost.Text = SqlError(ex);


            }  

        }
        //Update host button
        private void Btn_UpdateHost(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[3];
                stringArray[0] = txtBox_HostID.Text;
                stringArray[1] = txtBox_HostName.Text;
                stringArray[2] = txtBox_HostPhoneNumber.Text;

                //Check for empty fields
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //Dal method call
                    dataAccessLayer.UpdateHost(stringArray[0], stringArray[1], stringArray[2]);
                    //Populate table and comboboxes + clear fields
                    PopulateBookingUserNameComboBox();
                    PopulateDataGridViews();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseHost.Text = "Host: " + stringArray[0] +  ": " + stringArray[0] +" has been updated!";

                } else
                {
                    //Response to user
                    label_ErrorResponseHost.Text = "Please fill in all fields in order to update Host! (Id can not be updated)";
                }

            } catch (SqlException ex)
            {
                //Handling sqlException and giving response User
                label_ErrorResponseHost.Text = SqlError(ex);
            }
          
        }

        //Add property button
        private void Btn_AddProperty(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[5];
                stringArray[0] = txtBox_PropertyAddress.Text;
                stringArray[1] = txtBox_PropertyPrice.Text;
                stringArray [2]= txtBox_PropertyType.Text;
                stringArray[3] = txtBox_PropertyCountry.Text;
                stringArray [4]= SplitComboBoxValue(comboBox_PropertyHostId.Text);

                //Check for empty 
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //Convert string to an int 
                    int propertyPrice = Convert.ToInt32(stringArray[1]);
                    //Dal method call
                    dataAccessLayer.AddProperty(stringArray[0], propertyPrice, stringArray[2], stringArray[3], stringArray[4]);
                    //Populate table and combobox + clear fields
                    PopulateDataGridViews();
                    PopulateBookingPropertyAddressComboBox();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseProperty.Text = "Property: " + stringArray[0] + " has been added!";
                } 
                else {
                    //Response to user if fields are not filled in
                    label_ErrorResponseProperty.Text = "Please fill in all fields in order to add a property";

                }
   
            }
            catch (SqlException ex)
            {
                //Handling sqlException and sending response to user
                label_ErrorResponseProperty.Text = SqlError(ex);
            } catch (FormatException nx)
            {
                //Handling exception if numbers are not inserted in the price txtBox and giving proper response to user
                label_ErrorResponseProperty.Text = "Please only insert numbers to price column";
            }
        }

        //Delete Property button
        private void Btn_DeleteProperty(object sender, EventArgs e)
        {
            try
            {

                string[] stringArray = new string[1];
                stringArray[0] = txtBox_PropertyAddress.Text;
                //Check if any fields are empty
                if(CheckIfFieldsAreEmpty(stringArray))
                {
                    //Dal method call
                    dataAccessLayer.DeleteProperty(stringArray[0]);
                    //Populate table and combobox + clear fields
                    PopulateDataGridViews();
                    ClearFields();
                    PopulateBookingPropertyAddressComboBox();
                    //Response to user
                    label_ErrorResponseProperty.Text = "Property: " + stringArray[0] + " has been deleted!";
                }
                else
                {
                    //Response to user if a property hasent been selected
                    label_ErrorResponseProperty.Text = "Please choose a property from table in order to delete!";
                }
              
            } catch (SqlException ex)
            {
                //Handling sqlException and giving response to user
                label_ErrorResponseProperty.Text = SqlError(ex);
            } 
           
        }
        //Update Property button
        private void Btn_UpdateProperty(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[5];
                stringArray[0] = txtBox_PropertyAddress.Text;
                stringArray[1] = txtBox_PropertyPrice.Text;
                stringArray[2] = txtBox_PropertyType.Text;
                stringArray[3] = txtBox_PropertyCountry.Text;
                stringArray[4] = SplitComboBoxValue(comboBox_PropertyHostId.Text);

                //Check if any fields are empty 
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //Convert priceString to an int
                    int propertyPrice = Convert.ToInt32(stringArray[1]);
                    //Dal method call
                    dataAccessLayer.UpdateProperty(stringArray[0], propertyPrice, stringArray[2], stringArray[3], stringArray[4]);
                    //Populate table and combobox + clear fields
                    PopulateBookingUserNameComboBox();
                    PopulateDataGridViews();
                    ClearFields();
                    //Response to user
                    label_ErrorResponseProperty.Text = "Property: " + stringArray[0] + " has been updated!";
                }

                else
                {
                    //Response to User if all fields are not filled in
                    label_ErrorResponseProperty.Text = "Please fill in all fields in order to update!";
                }
                
            } catch (SqlException ex)
            {
                //Handling SqlException and giving response to user
                label_ErrorResponseHost.Text = SqlError(ex);
            } catch (FormatException ex)
            {
                //Response to user if txtBox for price is not filled in correctly
                label_ErrorResponseHost.Text = "Please only insert numbers to price column!";
            }
        }

        //Add Booking button
        private void Btn_AddBooking(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[3];
                stringArray[0] = SplitComboBoxValue(comboBox_BookingUsername.Text);
                stringArray[1] = SplitComboBoxValue(comboBox_BookingAddress.Text);
                DateTime startDateBook = datePickerBookingStartDate.Value;
                DateTime endDateBook = datePickerBookingEndDate.Value;
                stringArray[2] = label_TbarPropertyRatingResult.Text;

                //Check for empty fields
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //Convert rating string to an int
                    int rating = Convert.ToInt32(stringArray[2]);
                    //Dal method call
                    dataAccessLayer.AddBooking(stringArray[0], stringArray[1], startDateBook, endDateBook, rating);
                    //Response to user
                    label_ErrorResponseBooking.Text = "Booking for " + stringArray[0] + " has been completed! " +
                    "Booked dates " + startDateBook.ToString("yyyy-MM-dd") + " until: " + endDateBook.ToString("yyyy-MM-dd");
                    //Populate tables
                    PopulateDataGridViews();
                }
                else
                {
                    //Response to user if fields are not filled in
                    label_ErrorResponseBooking.Text = "Please fill in all required fields in order to add a booking!";

                }

            } catch(SqlException ex)
            {
                //Handling sqlException and giving response to user
                label_ErrorResponseBooking.Text = SqlError(ex); 
            }

        }

        //Delete Booking button
        private void Btn_DeleteBooking(object sender, EventArgs e)
        {
            try
            {
                string userName = SplitComboBoxValue(comboBox_BookingUsername.Text);
                string propertyAddress = SplitComboBoxValue(comboBox_BookingAddress.Text);

                //Check for empty fields
                if (userName == "" || propertyAddress == "")
                {
                    //Response to user if there are empty fields
                    label_ErrorResponseBooking.Text = "Please choose an User and Address from combobox in order to delete Booking!";

                }
                else
                {
                    //Dal method call
                    dataAccessLayer.DeleteBooking(userName, propertyAddress);
                    //Response to user
                    label_ErrorResponseBooking.Text = "Booking for " + userName + " on property " + propertyAddress + " has been deleted!";
                    //Populate table and comboboxes
                    PopulateDataGridViews();
                    PopulateBookingUserNameComboBox();
                    PopulateBookingPropertyAddressComboBox(); 
                }  

            }
            catch (SqlException ex)
            {
                //Handling sqlException and giving proper response to user
                label_ErrorResponseBooking.Text = SqlError(ex);
            }

        }

        //Update Booking button
        private void Btn_UpdateBooking(object sender, EventArgs e)
        {
            try
            {
                string[] stringArray = new string[3];
                stringArray[0] = SplitComboBoxValue(comboBox_BookingUsername.Text);
                stringArray[1] = SplitComboBoxValue(comboBox_BookingAddress.Text);
                DateTime startDateBook = datePickerBookingStartDate.Value;
                DateTime endDateBook = datePickerBookingEndDate.Value;
                stringArray[2] = label_TbarPropertyRatingResult.Text;

                //Check for empty fields
                if (CheckIfFieldsAreEmpty(stringArray))
                {
                    //Convert ratingString to an int
                    int rating = Convert.ToInt32(stringArray[2]);
                    //Dal method call
                    dataAccessLayer.UpdateBooking(stringArray[0], stringArray[1], startDateBook, endDateBook, rating);
                    //Populate table and comboboxes
                    PopulateBookingUserNameComboBox();
                    PopulateBookingPropertyAddressComboBox();
                    PopulateDataGridViews();
                    //Response to user
                    label_ErrorResponseBooking.Text = "Booking for " + stringArray[0] + " has been updated!";


                } else {
                    //Response to user if there are empty fields
                    label_ErrorResponseBooking.Text = "Please fill in all fields in order to update!";
                }
            }
            catch (SqlException ex)
            {
                //Handling sqlException and giving proper response to user
                label_ErrorResponseHost.Text = SqlError(ex);
            }
            catch (FormatException ex)
            {
                //Resposne to user if numbers are not inserted into price column
                label_ErrorResponseHost.Text = "Please only insert numbers to price column!";
            }


        }
        //Tbar scroll method
        private void Tbar_PropertyRatingScroll(object sender, EventArgs e)
        {
            //Set tbar label to tbar value
            label_TbarPropertyRatingResult.Text = tbar_PropertyRating.Value.ToString();
        }

        private void tabPageUser_Click(object sender, EventArgs e)
        {

        }

        private void label_HostPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void label_HostFullName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPageHost_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
