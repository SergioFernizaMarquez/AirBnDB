using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnDBProject
{
    public class DataAccessLayer
    {
        private string connectionString;

        //Setting up database connection
        public DataAccessLayer()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = @"localhost";
            stringBuilder.InitialCatalog = "DevelopmentAirBnDB";
            stringBuilder.IntegratedSecurity = true;
            stringBuilder.ConnectTimeout = 30;
            stringBuilder.ConnectRetryCount = 5;
            stringBuilder.ConnectRetryInterval = 2;

            connectionString = stringBuilder.ConnectionString;

        }

        //Method for reading all Users 
        public DataSet ReadUsers()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.UsersAdapter(sqlConnection))
                {
                    DataSet dataSetUsers = new DataSet();

                    sqlDataAdapter.Fill(dataSetUsers);

                    return dataSetUsers;
                }
            }

        }

        //Add User
        public void AddUsers(string userName,
            string fullName,
            string userPhoneNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.UsersAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        DataSet dataSetUsers = new DataSet();

                        sqlDataAdapter.Fill(dataSetUsers);

                        DataTable dataTableUsers = new DataTable();
                        dataTableUsers = dataSetUsers.Tables["Table"];

                        DataRow newUsersRow = dataTableUsers.NewRow();





                        //dataTableUsers.Columns.Add(userName);
                        newUsersRow["UserName"] = userName;
                        newUsersRow["FullName"] = fullName;
                        newUsersRow["UserPhoneNumber"] = userPhoneNumber;

                        dataTableUsers.Rows.Add(newUsersRow);

                        sqlDataAdapter.Update(dataTableUsers);
                    }
            

                }

            }

        }

        public void UpdateUsers(string userName, string fullName, string userPhoneNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.UsersAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        sqlDataAdapter.UpdateCommand.Parameters[0].Value = userName;
                        sqlDataAdapter.UpdateCommand.Parameters[1].Value = fullName;
                        sqlDataAdapter.UpdateCommand.Parameters[2].Value = userPhoneNumber;

                        sqlConnection.Open();
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                    }


                }

            }

        }

        public void DeleteUsers(string userName)
        {
            
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.UsersAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))

                    {

                        sqlDataAdapter.DeleteCommand.Parameters[0].Value = userName;

                        sqlConnection.Open();
                        sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

                    }
                   
                }
            }
        }

        //Method for reading all Hosts 
        public DataSet ReadHosts()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.HostAdapter(sqlConnection))
                {
                    DataSet dataSetUsers = new DataSet();

                    sqlDataAdapter.Fill(dataSetUsers);

                    return dataSetUsers;
                }
            }

        }
        public void AddHost(string hostID,
            string hostName,
            string hostPhoneNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.HostAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        DataSet dataSetUsers = new DataSet();

                        sqlDataAdapter.Fill(dataSetUsers);

                        DataTable dataTableHost = new DataTable();
                        dataTableHost = dataSetUsers.Tables["Table"];

                        DataRow newHostRow = dataTableHost.NewRow();





                        //dataTableUsers.Columns.Add(userName);
                        newHostRow["HostID"] = hostID;
                        newHostRow["HostName"] = hostName;
                        newHostRow["HostPhoneNumber"] = hostPhoneNumber;

                        dataTableHost.Rows.Add(newHostRow);

                        sqlDataAdapter.Update(dataTableHost);
                    }


                }

            }

        }
        public void UpdateHost(string hostID, string hostName, string hostPhoneNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.HostAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        sqlDataAdapter.UpdateCommand.Parameters[0].Value = hostID;
                        sqlDataAdapter.UpdateCommand.Parameters[1].Value = hostName;
                        sqlDataAdapter.UpdateCommand.Parameters[2].Value = hostPhoneNumber;

                        sqlConnection.Open();
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                    }


                }

            }

        }
        public void DeleteHost(string hostID)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.HostAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))

                    {

                        sqlDataAdapter.DeleteCommand.Parameters[0].Value = hostID;

                        sqlConnection.Open();
                        sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

                    }

                }
            }
        }

        public string GetHostIds()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString)) 
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandText = "SELECT HostID FROM Host";
                    sqlCommand.Connection = sqlConnection;
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        sqlDataAdapter.SelectCommand = sqlCommand;
                        DataSet dataSetUserId = new DataSet();
                        sqlDataAdapter.Fill(dataSetUserId);
                        string hostIds = dataSetUserId.ToString();  

                        return hostIds;
                    }

                }
                    
               
            }
        }

        //Method for reading all Properties 
        public DataSet ReadProperties()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.PropertyAdapter(sqlConnection))
                {
                    DataSet dataSetProperty = new DataSet();

                    sqlDataAdapter.Fill(dataSetProperty);

                    return dataSetProperty;
                }
            }

        }
        public void AddProperty(string propertyAddress,
            int propertyPrice,
            string propertyType, 
            string propertyCountry,
            string hostID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.PropertyAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        DataSet dataSetProperty = new DataSet();

                        sqlDataAdapter.Fill(dataSetProperty);

                        DataTable dataTableProperty = new DataTable();
                        dataTableProperty = dataSetProperty.Tables["Table"];

                        DataRow newPropertyRow = dataTableProperty.NewRow();


                        //dataTableProperty.Columns.Add(propertyAddress);
                        newPropertyRow["propertyAddress"] = propertyAddress;
                        newPropertyRow["propertyPrice"] = propertyPrice;
                        newPropertyRow["propertyType"] = propertyType;
                        newPropertyRow["propertyCountry"] = propertyCountry;
                        newPropertyRow["hostID"] = hostID;

                        dataTableProperty.Rows.Add(newPropertyRow);

                        sqlDataAdapter.Update(dataTableProperty);
                    }


                }

            }

        }
        public void UpdateProperty(string propertyAddress,
            int propertyPrice,
            string propertyType,
            string propertyCountry,
            string hostID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.PropertyAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        sqlDataAdapter.UpdateCommand.Parameters[0].Value = propertyAddress;
                        sqlDataAdapter.UpdateCommand.Parameters[1].Value = propertyPrice;
                        sqlDataAdapter.UpdateCommand.Parameters[2].Value = propertyType;
                        sqlDataAdapter.UpdateCommand.Parameters[3].Value = propertyCountry;
                        sqlDataAdapter.UpdateCommand.Parameters[4].Value = hostID;


                        sqlConnection.Open();
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                    }


                }

            }

        }
        public void DeleteProperty(string propertyAddress)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.PropertyAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))

                    {

                        sqlDataAdapter.DeleteCommand.Parameters[0].Value = propertyAddress;

                        sqlConnection.Open();
                        sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

                    }

                }
            }
        }

        //Method for reading all Hosts 
        public DataSet ReadBookings()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.BookingAdapter(sqlConnection))
                {
                    DataSet dataSetUsers = new DataSet();

                    sqlDataAdapter.Fill(dataSetUsers);

                    return dataSetUsers;
                }
            }

        }



        //Add Booking
        public void AddBooking(string userName,
            string propertyAddress,
            DateTime startDateBook,
            DateTime endDateBook,
            int propertyRating)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.BookingAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                   
                        DataSet dataSetBooking = new DataSet();

                        sqlDataAdapter.Fill(dataSetBooking);

                        DataTable dataTableBooking = new DataTable();
                        dataTableBooking = dataSetBooking.Tables["Table"];

                        DataRow newBookingRow = dataTableBooking.NewRow();


                        //dataTableProperty.Columns.Add(propertyAddress);
                        newBookingRow["userName"] = userName;
                        newBookingRow["propertyAddress"] = propertyAddress;
                        newBookingRow["bookingStartDate"] = startDateBook;
                        newBookingRow["bookingEndDate"] = endDateBook;
                        newBookingRow["propertyRating"] = propertyRating;

                        dataTableBooking.Rows.Add(newBookingRow);

                        sqlDataAdapter.Update(dataTableBooking);

                    
                  

                    }
                }
            }

        }

        //Delete Booking
        public void DeleteBooking(string userName, string propertyAddress)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.BookingAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))

                    {

                        sqlDataAdapter.DeleteCommand.Parameters[0].Value = userName;
                        sqlDataAdapter.DeleteCommand.Parameters[1].Value = propertyAddress;


                        sqlConnection.Open();
                        sqlDataAdapter.DeleteCommand.ExecuteNonQuery();

                    }

                }
            }
        }

        public void UpdateBooking(string userName,
            string propertyAddress,
            DateTime startDateBook,
            DateTime endDateBook,
            int propertyRating)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter sqlDataAdapter = AdapterManager.BookingAdapter(sqlConnection))
                {
                    using (SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter))
                    {
                        sqlDataAdapter.UpdateCommand.Parameters[0].Value = userName;
                        sqlDataAdapter.UpdateCommand.Parameters[1].Value = propertyAddress;
                        sqlDataAdapter.UpdateCommand.Parameters[2].Value = startDateBook;
                        sqlDataAdapter.UpdateCommand.Parameters[3].Value = endDateBook;
                        sqlDataAdapter.UpdateCommand.Parameters[4].Value = propertyRating;


                        sqlConnection.Open();
                        sqlDataAdapter.UpdateCommand.ExecuteNonQuery();

                    }


                }

            }


        }

    }
}
