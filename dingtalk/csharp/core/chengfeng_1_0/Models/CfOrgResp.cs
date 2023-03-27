// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfOrgResp : TeaModel {
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
        /// 级别
        /// </summary>
        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

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

    }

}
