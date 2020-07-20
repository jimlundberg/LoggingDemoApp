using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LoggingDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogTrace("Log Trace");
            _logger.LogDebug("Log Debug");
            _logger.LogInformation("Log Information");
            _logger.LogError("Log Error");
            _logger.LogCritical("Log Critical");
        }

        public void OnPostStartButton(int sessionCount)
        {
            ViewData["msg"] = $"The Start Button {sessionCount} is processed";
        }
        public void OnPostStopButton(int sessionCount)
        {
            ViewData["msg"] = $"The Stop Button {sessionCount} is processed";
        }
        public void OnPostHistoryButton(int sessionCount)
        {
            ViewData["msg"] = $"The History Button {sessionCount} is processed";
        }
    }
}
