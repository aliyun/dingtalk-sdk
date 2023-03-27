// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetOrgInfoResponseBody : TeaModel {
        /// <summary>
        /// 部门详情
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetOrgInfoResponseBodyContent Content { get; set; }
        public class GetOrgInfoResponseBodyContent : TeaModel {
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
            /// 部门人数
            /// </summary>
            [NameInMap("deptNum")]
            [Validation(Required=false)]
            public string DeptNum { get; set; }

            /// <summary>
            /// 部门层级
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// 部门编码路径
            /// </summary>
            [NameInMap("organizationCodePath")]
            [Validation(Required=false)]
            public string OrganizationCodePath { get; set; }

            /// <summary>
            /// 部门路径
            /// </summary>
            [NameInMap("organizationPath")]
            [Validation(Required=false)]
            public string OrganizationPath { get; set; }

            /// <summary>
            /// 父级部门编码
            /// </summary>
            [NameInMap("parentDeptCode")]
            [Validation(Required=false)]
            public string ParentDeptCode { get; set; }

            /// <summary>
            /// 部门简称
            /// </summary>
            [NameInMap("shortName")]
            [Validation(Required=false)]
            public string ShortName { get; set; }

            /// <summary>
            /// 生效日期
            /// </summary>
            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// 失效日期
            /// </summary>
            [NameInMap("stopDate")]
            [Validation(Required=false)]
            public string StopDate { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
