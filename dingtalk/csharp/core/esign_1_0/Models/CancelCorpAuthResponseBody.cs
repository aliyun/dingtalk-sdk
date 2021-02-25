// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class CancelCorpAuthResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CancelCorpAuthResponseBodyData Data { get; set; }
        public class CancelCorpAuthResponseBodyData : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }
        };

        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
