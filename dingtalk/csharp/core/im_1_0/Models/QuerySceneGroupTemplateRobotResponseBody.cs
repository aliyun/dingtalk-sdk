// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QuerySceneGroupTemplateRobotResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySceneGroupTemplateRobotResponseBodyResult Result { get; set; }
        public class QuerySceneGroupTemplateRobotResponseBodyResult : TeaModel {
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
