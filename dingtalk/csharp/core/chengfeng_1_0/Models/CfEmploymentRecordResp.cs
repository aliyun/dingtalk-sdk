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
        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public string DeptCode { get; set; }

        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        [NameInMap("employeeStatus")]
        [Validation(Required=false)]
        public string EmployeeStatus { get; set; }

        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("isLatestRecord")]
        [Validation(Required=false)]
        public bool? IsLatestRecord { get; set; }

        [NameInMap("jobLevelName")]
        [Validation(Required=false)]
        public string JobLevelName { get; set; }

        [NameInMap("jobPositionCode")]
        [Validation(Required=false)]
        public string JobPositionCode { get; set; }

        [NameInMap("jobPositionName")]
        [Validation(Required=false)]
        public string JobPositionName { get; set; }

        [NameInMap("jobPostCode")]
        [Validation(Required=false)]
        public string JobPostCode { get; set; }

        [NameInMap("jobPostName")]
        [Validation(Required=false)]
        public string JobPostName { get; set; }

        [NameInMap("serviceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("workNumbers")]
        [Validation(Required=false)]
        public string WorkNumbers { get; set; }

    }

}
