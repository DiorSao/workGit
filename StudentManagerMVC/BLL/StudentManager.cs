using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Models;

namespace BLL
{
    public class StudentManager
    {
        private StudentService studentService = new StudentService();

        public List<Student> GetStudents(string className)
        {
            //获取DAL层的数据
            List<Student> students = studentService.GetStudents(className);
            //进行逻辑交互
            if (students.Count > 0) return students;
            else return null;
        }
    }
}
