﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailChimp.Api.Net.Services.Reports;


using MailChimp.Api.Net.Domain.Reports;

namespace MailChimp.Api.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            //MCReportsCampaignAdvice ca = new MCReportsCampaignAdvice();
            //var x = ca.GetAdvice("YourCampaignID").Result;

            //ReportsOverview rep = new ReportsOverview();
            //var x = rep.CampaignSpecificOverviewAsync("YourCampaignID").Result;

            //MCReportsCampaignAdvice ca = new MCReportsCampaignAdvice();
            //var x2 = ca.GetAdviceAsync("YourCampaignID").Result;

            MCReportsDomainPerformance dp = new MCReportsDomainPerformance();
            var x3 = dp.GetDomainPerformanceAsync("YourCampaignID").Result;

            Console.Read();
        }
    }
}
