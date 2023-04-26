// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class GetDingPortalDetailResponseBody : TeaModel {
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        [NameInMap("dingPortalName")]
        [Validation(Required=false)]
        public string DingPortalName { get; set; }

        [NameInMap("pages")]
        [Validation(Required=false)]
        public List<GetDingPortalDetailResponseBodyPages> Pages { get; set; }
        public class GetDingPortalDetailResponseBodyPages : TeaModel {
            [NameInMap("allVisible")]
            [Validation(Required=false)]
            public bool? AllVisible { get; set; }

            [NameInMap("deptIds")]
            [Validation(Required=false)]
            public List<long?> DeptIds { get; set; }

            [NameInMap("pageName")]
            [Validation(Required=false)]
            public string PageName { get; set; }

            [NameInMap("pageUuid")]
            [Validation(Required=false)]
            public string PageUuid { get; set; }

            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<long?> RoleIds { get; set; }

            [NameInMap("userids")]
            [Validation(Required=false)]
            public List<string> Userids { get; set; }

        }

    }

}
