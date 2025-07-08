using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentProject.Global_Class
{
    public static class CurrentUser
    {
        public static int ID { get; set; }
        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static int Permmions { get; set; }
        public static bool remmberMe { get; set; }
    }
}
