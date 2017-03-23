using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSource
{
    class JobAd
    {
        #region Properties

        /// <summary>
        /// The id of the ad
        /// </summary>
        public int AdNumber { get; set; }
        
        /// <summary>
        /// The name of the workplace
        /// </summary>
        public string Organization { get; set; }
        
        /// <summary>
        /// The title of the job 
        /// </summary>
        public string JobTitle { get; set; }
        
        /// <summary>
        /// The description of the job
        /// </summary>
        public string JobSummary { get; set; }
        
        /// <summary>
        /// The job's requiered qualificalions
        /// </summary>
        public string RequieredQualificalions { get; set; }

        /// <summary>
        /// The type of the job
        /// </summary>
        public JobTypes JobType { get; set; }
        
        /// <summary>
        /// The date the ad was published
        /// </summary>
        public DateTime DatePublished { get; set; }

        /// <summary>
        /// The job's location
        /// </summary>
        public Location JobLocation { get; set; }

        /// <summary>
        /// Tags that carecterize the job
        /// </summary>
        public string[] Tags { get; set; }

        #endregion
    }

    enum JobTypes
    {
        Job,
        Intership,
        Volunteer
    }
}
