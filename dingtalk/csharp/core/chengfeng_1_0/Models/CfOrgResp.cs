// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfOrgResp : TeaModel {
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
        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationCodePath")]
        [Validation(Required=false)]
        public string OrganizationCodePath { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("organizationPath")]
        [Validation(Required=false)]
        public string OrganizationPath { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("parentDeptCode")]
        [Validation(Required=false)]
        public string ParentDeptCode { get; set; }

    }

}
