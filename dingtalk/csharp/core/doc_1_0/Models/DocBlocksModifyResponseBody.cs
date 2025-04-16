// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocBlocksModifyResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DocBlocksModifyResponseBodyResult Result { get; set; }
        public class DocBlocksModifyResponseBodyResult : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public List<object> Result { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
