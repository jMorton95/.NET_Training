using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace CsvFileImporter
{
    internal class App
    {
        private readonly ILogger<App> _logger;
        private readonly AppSettings _appSettings;
        public App(IOptions<AppSettings> appSettings, ILogger<App> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _appSettings = appSettings?.Value ?? throw new ArgumentNullException(nameof(appSettings));
        }

        public async Task Run(string[] args)
        {
            _logger.LogInformation("Csv Importer Starting");
        }
    }
}
