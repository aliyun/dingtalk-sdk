// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkamdp_1_0.Models
{
    public class AmdpOrganizationDataPushRequest : TeaModel {
        [NameInMap("param")]
        [Validation(Required=false)]
        public List<AmdpOrganizationDataPushRequestParam> Param { get; set; }
        public class AmdpOrganizationDataPushRequestParam : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("deptManagerIdList")]
            [Validation(Required=false)]
            public List<string> DeptManagerIdList { get; set; }

            [NameInMap("dingTalkDeptId")]
            [Validation(Required=false)]
            public string DingTalkDeptId { get; set; }

            [NameInMap("dingTalkParentId")]
            [Validation(Required=false)]
            public string DingTalkParentId { get; set; }

            [NameInMap("isDelete")]
            [Validation(Required=false)]
            public string IsDelete { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("parentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

        }

    }

}
