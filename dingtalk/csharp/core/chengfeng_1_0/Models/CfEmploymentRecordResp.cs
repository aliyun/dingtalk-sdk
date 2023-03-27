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
        /// 部门编码
        /// </summary>
        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// 人员状态(2:试用,3:正式)
        /// </summary>
        [NameInMap("employeeStatus")]
        [Validation(Required=false)]
        public string EmployeeStatus { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 是否是最新任职
        /// </summary>
        [NameInMap("isLatestRecord")]
        [Validation(Required=false)]
        public bool? IsLatestRecord { get; set; }

        /// <summary>
        /// 职级名称
        /// </summary>
        [NameInMap("jobLevelName")]
        [Validation(Required=false)]
        public string JobLevelName { get; set; }

        /// <summary>
        /// 职位编码
        /// </summary>
        [NameInMap("jobPositionCode")]
        [Validation(Required=false)]
        public string JobPositionCode { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        [NameInMap("jobPositionName")]
        [Validation(Required=false)]
        public string JobPositionName { get; set; }

        /// <summary>
        /// 职务编码
        /// </summary>
        [NameInMap("jobPostCode")]
        [Validation(Required=false)]
        public string JobPostCode { get; set; }

        /// <summary>
        /// 职务名称
        /// </summary>
        [NameInMap("jobPostName")]
        [Validation(Required=false)]
        public string JobPostName { get; set; }

        /// <summary>
        /// 任职状态(1:任职中,2:任职结束)
        /// </summary>
        [NameInMap("serviceStatus")]
        [Validation(Required=false)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 任职类型(5:主职, 6:兼职)
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [NameInMap("workNumbers")]
        [Validation(Required=false)]
        public string WorkNumbers { get; set; }

    }

}
