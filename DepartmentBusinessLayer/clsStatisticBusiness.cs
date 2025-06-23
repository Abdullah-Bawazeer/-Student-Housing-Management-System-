using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentBusinessLayer
{
    public class clsStatisticBusiness
    {
        public static DataTable GetStatisticData()
        {
            return clsStatistic.GetAllStatisticData();
        }
    }
}
