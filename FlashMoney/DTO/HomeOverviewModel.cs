using EducationAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashMoney.DTO
{
    public class HomeOverviewModel
    {
        public List<ActivityDTO> activities { get; set; }
        public string Balance { get; set; }
        public int TransactionCount { get; set; }
        public int FundWalletCount { get; set; }
        public string status { get; set; }
        public string LastFunded { get; set; }
        public int Approvedscholarship { get; set; }
        public List<ScholarshipApplication> ScholarApps { get; set; }
        public string FSLCC { get; set; }
        public string WAAC { get; set; }
        public string JAMMB { get; set; }
        public string GAAD { get; set; }

    }
}
