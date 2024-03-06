using DAM2_M06_UF4_Activity_2_Code_First.MODEL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM2_M06_UF4_Activity_2_Code_First.DAO
{
    public class DAOManagerFactory
    {
        public static IDAOManager CreateDAOManager(ClassicModelDbContext context)
        {
            return new DAOManager(context);
        }
    }
}
