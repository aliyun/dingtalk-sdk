// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkamdp_1_0.Models
{
    public class AmdpEmployeeDataPushRequest : TeaModel {
        [NameInMap("param")]
        [Validation(Required=false)]
        public List<AmdpEmployeeDataPushRequestParam> Param { get; set; }
        public class AmdpEmployeeDataPushRequestParam : TeaModel {
            [NameInMap("avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("isDelete")]
            [Validation(Required=false)]
            public string IsDelete { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

    }

}
