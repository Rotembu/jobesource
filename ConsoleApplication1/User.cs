using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSource
{
    class User
    {
        #region Properties 

        /// <summary>
        /// Job/Intership/Volunteer
        /// </summary>
        public string Typejobe { get; set; }
        
        /// <summary>
        /// location of job
        /// </summary>
        public string Location { get; set; }
        
        /// <summary>
        /// Area of focous of the job
        /// </summary>
        public string Areasoffocous { get; set; }
        
        /// <summary>
        /// Employment type of the job like Full time/Part time
        /// </summary>
        public string Employmenttype { get; set; }

        #endregion
    }
}
