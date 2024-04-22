// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkamdp_1_0.Models
{
    public class AmdpJobPositionDataPushRequest : TeaModel {
        [NameInMap("param")]
        [Validation(Required=false)]
        public List<AmdpJobPositionDataPushRequestParam> Param { get; set; }
        public class AmdpJobPositionDataPushRequestParam : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("deptLeader")]
            [Validation(Required=false)]
            public string DeptLeader { get; set; }

            [NameInMap("isDelete")]
            [Validation(Required=false)]
            public string IsDelete { get; set; }

            [NameInMap("leaderDeptId")]
            [Validation(Required=false)]
            public string LeaderDeptId { get; set; }

            [NameInMap("orderNumber")]
            [Validation(Required=false)]
            public string OrderNumber { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
