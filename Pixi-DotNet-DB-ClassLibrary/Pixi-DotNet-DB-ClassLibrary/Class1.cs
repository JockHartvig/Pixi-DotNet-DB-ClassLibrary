using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Transactions;

namespace Pixi.DB.ClassLibrary
{
    public class Class1
    {

        //
        void LocalProc()
        {
            using (var scope = new TransactionScope())
            {
                using (var conn1 = new SqlConnection("  "))
                {
                    conn1.Open();

                    SqlCommand cmd1 = conn1.CreateCommand();
                    cmd1.CommandText = String.Format("Insert into tbale values(1)");
                    cmd1.ExecuteNonQuery();



                }
                scope.Complete();
            }

        }
    }
}