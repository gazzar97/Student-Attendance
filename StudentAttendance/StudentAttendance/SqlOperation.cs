using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendance
{
    struct Elements
    {
        public string StudentNumber, ClassNumber;
    };
    class SqlOperation
    {
        private string ConnectionString = "Data Source=DESKTOP-1NA0O15\SQLEXPRESS;Initial Catalog=Student-Attendance;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        List<Elements> Student = new List<Elements>();

    }
}
