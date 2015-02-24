using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using SimpleMVCdapper.Models;
using System.Data.SqlClient;

namespace SimpleMVCdapper.Services
{
    public class CustomerService
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLDbConnection"].ToString());

        public IEnumerable<Customerinfo> AllCustList()
        {
            //string query = "select * from tblDetails";
            string query = "spGetDapper";
            var List = con.Query<Customerinfo>(query);
            return List;
        }

        public string AddCust(Customerinfo Add)
        {
            string query = "insert into tblDetails(Name,Gender,City,Email,Mobile)"+"values(@Name,@Gender,@City,@Email,@MObile)";
            //string query = "spAddDapper";
            con.Execute(query, new {Add.ID, Add.Name, Add.Gender, Add.City, Add.Email, Add.Mobile });
            string result="Add";
            return result;
        }

        //public Customerinfo GetCust(long id)
        //{
        //    string query = "select ID,Name,Gender,City,Email,Mobile from tblDetails where ID=" + id;
        //    var result = con.Query<Customerinfo>(query).Single<Customerinfo>();
        //    return result;
        //}

        public string UpdateCust(Customerinfo Update)
        {
            string query = "update tblDetails set Name=@Name,Gender=@Gender,City=@City,Email=@Email,Mobile=@Mobile where ID=@ID";
            //string query = "spAddDapper";
            con.Execute(query, new {Update.ID, Update.Name, Update.Gender, Update.City, Update.Email, Update.Mobile });
            string result = "Update";
            return result;
        }

        public string Delete(Customerinfo Delete)
        {
            string query = "delete from tblDetails where ID=@ID";
            //string query = "spDeleteDapper";
            con.Execute(query, new { Delete.ID });
            string result = "Delate";
            return result;
        }
    }
}