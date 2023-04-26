// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class ArchiveTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ArchiveTaskResponseBodyResult Result { get; set; }
        public class ArchiveTaskResponseBodyResult : TeaModel {
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
