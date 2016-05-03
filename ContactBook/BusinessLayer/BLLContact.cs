using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLayer
{

    public class BLLContact
    {

        public int AddContact(string name, string email, string address, float phone, string country)
        {

            string sql = "insert into tbl_Contact values(@a,@b,@c,@d,@e)";
            SqlParameter[] param = new SqlParameter[] {
           new SqlParameter("@a",name),
           new SqlParameter("@b",email),
           new SqlParameter("@c",address),
           new SqlParameter("@d",phone),
           new SqlParameter("@e",country)
           };

            return DAO.IDU(sql, param);


        }
        public DataTable GetAllUser()
        {
            string sql = "select* from tbl_Contact";
            return DAO.GetContacts(sql, null);



        }
        public DataTable GetUserByUserId(int userid)
        {
            string sql = "select from tbl_Contact where ContactId=@a";
            SqlParameter[] param = new SqlParameter[] {
           new SqlParameter("@a", userid)
           
           };

            return DAO.GetContacts(sql, param);


        }
        public int DeleteContact(int userid)
        {
            string sql = "delete from tbl_Contact where ContactId=@a";
            SqlParameter[] param = new SqlParameter[] {
            new SqlParameter("@a",userid)
            
            
            };


            return DAO.IDU(sql, param);

        }

        public int UpdateContact(string name, string email, string address, float phone, string country, int contact)
        {
            string sql = "update tbl_Contact set Name=@a,Email=@b,Address=@c,Phone=@d,Country=@e where ContactId=@f";

            SqlParameter[] param = new SqlParameter[] {
           new SqlParameter("@a",name),
           new SqlParameter("@b",email),
           new SqlParameter("@c",address),
           new SqlParameter("@d",phone),
           new SqlParameter("@e",country),
              new SqlParameter("@f",contact)
           };

            
            return DAO.IDU(sql, param);
        }
        public DataTable GetContactbyName(string character) {
            string sql = "select* from tbl_Contact where Name=@a";
            SqlParameter[] param = new SqlParameter[] {
            new SqlParameter("@a",character)

            };
            return DAO.GetContacts(sql, param);
        
        }
    }
}