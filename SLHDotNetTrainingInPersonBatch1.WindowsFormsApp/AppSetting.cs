using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLHDotNetTrainingInPersonBatch1.WindowsFormsApp
{
    public static class AppSetting
    {
        public static readonly SqlConnectionStringBuilder ConnectionStringBuilder = new SqlConnectionStringBuilder
        {
            DataSource = ".",
            InitialCatalog = "InPersonBatch1MiniPOS",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true
        };
    }
}
