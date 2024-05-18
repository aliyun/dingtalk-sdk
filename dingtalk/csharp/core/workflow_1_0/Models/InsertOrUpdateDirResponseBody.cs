// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class InsertOrUpdateDirResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public InsertOrUpdateDirResponseBodyResult Result { get; set; }
        public class InsertOrUpdateDirResponseBodyResult : TeaModel {
            [NameInMap("bizGroup")]
            [Validation(Required=false)]
            public string BizGroup { get; set; }

            [NameInMap("dirId")]
            [Validation(Required=false)]
            public string DirId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
