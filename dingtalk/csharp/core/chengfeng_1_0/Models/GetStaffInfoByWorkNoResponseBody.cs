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
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("employType")]
            [Validation(Required=false)]
            public string EmployType { get; set; }

            [NameInMap("employeeStatus")]
            [Validation(Required=false)]
            public string EmployeeStatus { get; set; }

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

            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("workNumbers")]
            [Validation(Required=false)]
            public string WorkNumbers { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
