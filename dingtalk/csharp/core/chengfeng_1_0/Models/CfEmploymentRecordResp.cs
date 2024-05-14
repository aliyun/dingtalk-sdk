/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfEmploymentRecordResp : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public string DeptCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("employeeStatus")]
        [Validation(Required=false)]
        public string EmployeeStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isLatestRecord")]
        [Validation(Required=false)]
        public bool? IsLatestRecord { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("jobLevelName")]
        [Validation(Required=false)]
        public string JobLevelName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("jobPositionCode")]
        [Validation(Required=false)]
        public string JobPositionCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("jobPositionName")]
        [Validation(Required=false)]
        public string JobPositionName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("jobPostCode")]
        [Validation(Required=false)]
        public string JobPostCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("jobPostName")]
        [Validation(Required=false)]
        public string JobPostName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("serviceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("workNumbers")]
        [Validation(Required=false)]
        public string WorkNumbers { get; set; }

    }

}
