using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SQLite;

namespace RazorPagesPizza.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        using Microsoft.AspNetCore.Mvc;
        using Microsoft.AspNetCore.Mvc.RazorPages;
        using Microsoft.Extensions.Logging;
        using System;
        using System.Data.SQLite;

        namespace RazorPagesPizza.Pages
        {
            public class PrivacyModel : PageModel
            {
                private readonly ILogger<PrivacyModel> _logger;

                public PrivacyModel(ILogger<PrivacyModel> logger)
                {
                    _logger = logger;
                }

                public void OnPost()
                {
                    SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder();
                    builder.DataSource = "mydb.db";
                    builder.Version = 3;
                    string connectionString = builder.ConnectionString;
                    // use the connection string to connect to the database
                }
            }
        }
        public void OnPost()
        {}
    }
}