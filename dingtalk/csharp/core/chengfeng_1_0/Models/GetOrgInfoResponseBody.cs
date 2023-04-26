// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetOrgInfoResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public GetOrgInfoResponseBodyContent Content { get; set; }
        public class GetOrgInfoResponseBodyContent : TeaModel {
            [NameInMap("deptCode")]
            [Validation(Required=false)]
            public string DeptCode { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("deptNum")]
            [Validation(Required=false)]
            public string DeptNum { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("organizationCodePath")]
            [Validation(Required=false)]
            public string OrganizationCodePath { get; set; }

            [NameInMap("organizationPath")]
            [Validation(Required=false)]
            public string OrganizationPath { get; set; }

            [NameInMap("parentDeptCode")]
            [Validation(Required=false)]
            public string ParentDeptCode { get; set; }

            [NameInMap("shortName")]
            [Validation(Required=false)]
            public string ShortName { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("stopDate")]
            [Validation(Required=false)]
            public string StopDate { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
