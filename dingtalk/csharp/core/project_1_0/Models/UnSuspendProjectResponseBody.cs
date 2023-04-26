// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UnSuspendProjectResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UnSuspendProjectResponseBodyResult Result { get; set; }
        public class UnSuspendProjectResponseBodyResult : TeaModel {
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
