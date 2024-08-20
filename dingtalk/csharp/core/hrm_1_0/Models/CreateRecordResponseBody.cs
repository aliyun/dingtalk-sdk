// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class CreateRecordResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateRecordResponseBodyResult Result { get; set; }
        public class CreateRecordResponseBodyResult : TeaModel {
            [NameInMap("details")]
            [Validation(Required=false)]
            public string Details { get; set; }

            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
