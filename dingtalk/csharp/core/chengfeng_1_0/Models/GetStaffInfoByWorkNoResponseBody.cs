// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetStaffInfoByWorkNoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetStaffInfoByWorkNoResponseBodyContent Content { get; set; }
        public class GetStaffInfoByWorkNoResponseBodyContent : TeaModel {
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
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("employType")]
            [Validation(Required=false)]
            public string EmployType { get; set; }

            [NameInMap("employeeStatus")]
            [Validation(Required=false)]
            public string EmployeeStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("jobLevelName")]
            [Validation(Required=false)]
            public string JobLevelName { get; set; }

            [NameInMap("jobPositionCode")]
            [Validation(Required=false)]
            public string JobPositionCode { get; set; }

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
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("workNumbers")]
            [Validation(Required=false)]
            public string WorkNumbers { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
