using DataAccess.DBAccess;
using DataAccess.Models;
using System.Data;

namespace DataAccess.Data;
public class UserData
{
    private readonly ISqlDataAccess _dataAccess;

    public UserData(ISqlDataAccess dataAccess)
    {
        _dataAccess = dataAccess;
    }

    public Task InsertUser(IEnumerable<UserModel> users)
    {
        DataTable dataTable = new DataTable();

        dataTable.Columns.Add(new DataColumn("Id", typeof(long)));
        dataTable.Columns.Add(new DataColumn("UserName", typeof(string)));
        dataTable.Columns.Add(new DataColumn("FirstName", typeof(string)));
        dataTable.Columns.Add(new DataColumn("LastName", typeof(string)));
        dataTable.Columns.Add(new DataColumn("Email", typeof(string)));
        dataTable.Columns.Add(new DataColumn("Gender", typeof(char)));
        dataTable.Columns.Add(new DataColumn("PhoneNumber", typeof(long)));
        dataTable.Columns.Add(new DataColumn("Address", typeof(string)));
        dataTable.Columns.Add(new DataColumn("Role", typeof(string)));
        dataTable.Columns.Add(new DataColumn("EmergencyContactName", typeof(string)));
        dataTable.Columns.Add(new DataColumn("EmergencyContactNumber", typeof(long)));

        foreach (var user in users)
        {
            var row = dataTable.NewRow();
            row["Id"] = user.Id;
            row["UserName"] = user.UserName;
            row["FirstName"] = user.FirstName;
            row["LastName"] = user.LastName;
            row["Email"] = user.Email;
            row["Gender"] = user.Gender;
            row["PhoneNumber"] = user.PhoneNumber;
            row["Address"] = user.Address;
            row["Role"] = user.Role;
            row["EmergencyContactName"] = user.EmergencyContactName;
            row["EmergencyContactNumber"] = user.EmergencyContactNumber;
            dataTable.Rows.Add(row);
        }

        return _dataAccess.SaveData("dbo.InsertUsers", new { users = dataTable });
    }
}
