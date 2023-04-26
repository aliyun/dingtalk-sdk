// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfOrgResp : TeaModel {
        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public string DeptCode { get; set; }

        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        [NameInMap("organizationCodePath")]
        [Validation(Required=false)]
        public string OrganizationCodePath { get; set; }

        [NameInMap("organizationPath")]
        [Validation(Required=false)]
        public string OrganizationPath { get; set; }

        [NameInMap("parentDeptCode")]
        [Validation(Required=false)]
        public string ParentDeptCode { get; set; }

    }

}
