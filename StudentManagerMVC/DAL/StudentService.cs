using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentService
    {
        public List<Student> GetStudents(string studentClass)
        {
            string sql = "SELECT StudentId, StudentName, Gender, Birthday, StudentIdNo, CardNo, PhoneNumber, StudentAddress, c.ClassName FROM SMDBWeb.dbo.Students s";
            sql += " INNER JOIN SMDBWeb.dbo.StudentClass c ON c.ClassId = s.ClassId";
            sql += " WHERE s.ClassId LIKE '%{0}%'";
            sql = string.Format(sql, studentClass);
            SqlDataReader objReader = SQLHelper.GetReader(sql);
            List<Student> list = new List<Student>();
            while (objReader.Read())
            {
                list.Add(new Student() {
                    StudentId = Convert.ToInt16(objReader["StudentId"]),
                    StudentName = objReader["StudentName"].ToString(),
                    Gender = objReader["Gender"].ToString(),
                    ClassName = objReader["ClassName"].ToString(),
                    PhoneNumber = objReader["PhoneNumber"].ToString(),
                    StudentAddress = objReader["StudentAddress"].ToString()
                });
            }
            objReader.Close();
            return list;
        }
    }
}
