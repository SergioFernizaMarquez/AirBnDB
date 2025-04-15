using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnDBProject
{
    internal class AdapterManager
    {

        //Users Adapter

        public static SqlDataAdapter UsersAdapter(SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand command;
          
            //Query for selecting all Users
            command = new SqlCommand(
                "EXECUTE sp_ReadUser");
            command.Connection = connection;
            sqlDataAdapter.SelectCommand = command;

            //Add Users
            command = new SqlCommand(
               "EXECUTE sp_CreateUser @UserName, @FullName, @UserPhoneNumber", connection);
            command.Parameters.Add("Username", SqlDbType.VarChar, 100, "UserName");
            command.Parameters.Add("FullName", SqlDbType.VarChar, 100, "FullName");
            command.Parameters.Add("UserPhoneNumber", SqlDbType.VarChar, 100, "UserPhoneNumber");
            command.Connection = connection;
            sqlDataAdapter.InsertCommand = command;

            //Delete Users
            command = new SqlCommand(
              "EXECUTE sp_DeleteUser @UserName");
            command.Parameters.Add("Username", SqlDbType.VarChar, 100, "UserName");

            command.Connection = connection;
            sqlDataAdapter.DeleteCommand = command;

            //Update Users
            command = new SqlCommand(
              "EXECUTE sp_UpdateUser @UserName, @FullName, @UserPhoneNumber");
            command.Parameters.Add("Username", SqlDbType.VarChar, 100, "UserName");
            command.Parameters.Add("FullName", SqlDbType.VarChar, 100, "FullName");
            command.Parameters.Add("UserPhoneNumber", SqlDbType.VarChar, 100, "UserPhoneNumber");

            command.Connection = connection;
            sqlDataAdapter.UpdateCommand = command;


            return sqlDataAdapter;


        }

        //Host Adapter

        public static SqlDataAdapter HostAdapter (SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand command;

            //Query for selecting all Hosts
            command = new SqlCommand(
                "EXECUTE sp_ReadHost");
            command.Connection = connection;
            sqlDataAdapter.SelectCommand = command;

            //Add Host
            command = new SqlCommand(
               "EXECUTE sp_CreateHost @HostID, @HostName, @HostPhoneNumber", connection);
            command.Parameters.Add("HostID", SqlDbType.VarChar, 100, "HostID");
            command.Parameters.Add("HostName", SqlDbType.VarChar, 100, "HostName");
            command.Parameters.Add("HostPhoneNumber", SqlDbType.VarChar, 100, "HostPhoneNumber");
            command.Connection = connection;
            sqlDataAdapter.InsertCommand = command;

            //Delete Host
            command = new SqlCommand(
              "EXECUTE sp_DeleteHost @HostID");
            command.Parameters.Add("HostID", SqlDbType.VarChar, 100, "HostID");

            command.Connection = connection;
            sqlDataAdapter.DeleteCommand = command;

            //Update Host
            command = new SqlCommand(
              "EXECUTE sp_UpdateHost @HostID, @HostName, @HostPhoneNumber");
            command.Parameters.Add("HostID", SqlDbType.VarChar, 100, "HostID");
            command.Parameters.Add("HostName", SqlDbType.VarChar, 100, "HostName");
            command.Parameters.Add("HostPhoneNumber", SqlDbType.VarChar, 100, "HostPhoneNumber");

            command.Connection = connection;
            sqlDataAdapter.UpdateCommand = command;


            return sqlDataAdapter;
        }

        //Property Adapter
        public static SqlDataAdapter PropertyAdapter(SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand command;

            //Query for selecting all Users
            command = new SqlCommand(
                "EXECUTE sp_ReadProperty ");
            command.Connection = connection;
            sqlDataAdapter.SelectCommand = command;

            //Add Property
            command = new SqlCommand(
               "EXECUTE sp_CreateProperty @PropertyAddress, @PropertyPrice, @PropertyType, @PropertyCountry, @HostID", connection);
            command.Parameters.Add("PropertyAddress", SqlDbType.VarChar, 100, "PropertyAddress");
            command.Parameters.Add("PropertyPrice", SqlDbType.Int, 10, "PropertyPrice");
            command.Parameters.Add("PropertyType", SqlDbType.VarChar, 100, "PropertyType");
            command.Parameters.Add("PropertyCountry", SqlDbType.VarChar, 100, "PropertyCountry");
            command.Parameters.Add("HostID", SqlDbType.VarChar, 10, "HostID");

            command.Connection = connection;
            sqlDataAdapter.InsertCommand = command;

            //Delete Property
            command = new SqlCommand(
              "EXECUTE sp_DeleteProperty @PropertyAddress");
            command.Parameters.Add("PropertyAddress", SqlDbType.VarChar, 100, "PropertyAddress");

            command.Connection = connection;
            sqlDataAdapter.DeleteCommand = command;

            //Update Property
            command = new SqlCommand(
              "EXECUTE sp_UpdateProperty @PropertyAddress, @PropertyPrice, @PropertyType, @PropertyCountry, @HostID");
            command.Parameters.Add("PropertyAddress", SqlDbType.VarChar, 100, "PropertyAddress");
            command.Parameters.Add("PropertyPrice", SqlDbType.Int);
            command.Parameters.Add("PropertyType", SqlDbType.VarChar, 100, "PropertyType");
            command.Parameters.Add("PropertyCountry", SqlDbType.VarChar, 100, "PropertyCountry");
            command.Parameters.Add("HostID", SqlDbType.VarChar, 10, "HostID");

            command.Connection = connection;
            sqlDataAdapter.UpdateCommand = command;


            return sqlDataAdapter;
        }

        //Booking Adapter
        public static SqlDataAdapter BookingAdapter(SqlConnection connection)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlCommand command;

            //Query for selecting all Bookings
            command = new SqlCommand(
                "EXECUTE sp_ReadBooking");
            command.Connection = connection;
            sqlDataAdapter.SelectCommand = command;

            //Add Booking
            command = new SqlCommand(
              "EXECUTE sp_CreateBooking @UserName, @PropertyAddress, @BookingStartDate, @BookingEndDate, @PropertyRating", connection);
            command.Parameters.Add("Username", SqlDbType.VarChar, 100, "UserName");
            command.Parameters.Add("PropertyAddress", SqlDbType.VarChar, 100, "PropertyAddress");
            command.Parameters.Add("BookingStartDate", SqlDbType.Date, 10, "BookingStartDate");
            command.Parameters.Add("BookingEndDate", SqlDbType.Date, 10, "BookingEndDate");
            command.Parameters.Add("PropertyRating", SqlDbType.Int, 10, "PropertyRating");


            command.Connection = connection;
            sqlDataAdapter.InsertCommand = command;
            
            //Delete Booking
            command = new SqlCommand(
             "EXECUTE sp_DeleteBooking @UserName, @PropertyAddress");
            command.Parameters.Add("UserName", SqlDbType.VarChar, 100, "UserName");
            command.Parameters.Add("PropertyAddress", SqlDbType.VarChar, 100, "PropertyAddress");

            command.Connection = connection;
            sqlDataAdapter.DeleteCommand = command;

            //Update Booking
            command = new SqlCommand(
             "EXECUTE sp_UpdateBooking @UserName, @PropertyAddress, @BookingStartDate, @BookingEndDate, @PropertyRating", connection);
            command.Parameters.Add("Username", SqlDbType.VarChar, 100, "UserName");
            command.Parameters.Add("PropertyAddress", SqlDbType.VarChar, 100, "PropertyAddress");
            command.Parameters.Add("BookingStartDate", SqlDbType.Date, 10, "BookingStartDate");
            command.Parameters.Add("BookingEndDate", SqlDbType.Date, 10, "BookingEndDate");
            command.Parameters.Add("PropertyRating", SqlDbType.Int, 10, "PropertyRating");

            command.Connection = connection;
            sqlDataAdapter.UpdateCommand = command;


            return sqlDataAdapter;

        }

      
    }
}
