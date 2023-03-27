// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetStaffInfoByWorkNoResponseBody : TeaModel {
        /// <summary>
        /// 员工详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetStaffInfoByWorkNoResponseBodyContent Content { get; set; }
        public class GetStaffInfoByWorkNoResponseBodyContent : TeaModel {
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
            /// 邮箱
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// 员工类型
            /// </summary>
            [NameInMap("employType")]
            [Validation(Required=false)]
            public string EmployType { get; set; }

            /// <summary>
            /// 员工状态
            /// </summary>
            [NameInMap("employeeStatus")]
            [Validation(Required=false)]
            public string EmployeeStatus { get; set; }

            /// <summary>
            /// 职级
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
            /// 手机号
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 花名
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// 工号
            /// </summary>
            [NameInMap("workNumbers")]
            [Validation(Required=false)]
            public string WorkNumbers { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
