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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>开发部</para>
            /// </summary>
            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17********@qq.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("employType")]
            [Validation(Required=false)]
            public string EmployType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("employeeStatus")]
            [Validation(Required=false)]
            public string EmployeeStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("jobLevelName")]
            [Validation(Required=false)]
            public string JobLevelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("jobPositionCode")]
            [Validation(Required=false)]
            public string JobPositionCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Java开发</para>
            /// </summary>
            [NameInMap("jobPositionName")]
            [Validation(Required=false)]
            public string JobPositionName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("jobPostCode")]
            [Validation(Required=false)]
            public string JobPostCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>技术开发</para>
            /// </summary>
            [NameInMap("jobPostName")]
            [Validation(Required=false)]
            public string JobPostName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>151********</para>
            /// </summary>
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>花名</para>
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
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
