// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class ArchiveProjectResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ArchiveProjectResponseBodyResult Result { get; set; }
        public class ArchiveProjectResponseBodyResult : TeaModel {
            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
