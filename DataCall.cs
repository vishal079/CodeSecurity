using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp1
{
    public class DataCall
    {
        EmployeeDA da = new EmployeeDA();
        
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            string str= "select * from employee where status=1";
            da.query = str;
            dt = da.ExecuteSql();
            return dt;
        }
    }
}
