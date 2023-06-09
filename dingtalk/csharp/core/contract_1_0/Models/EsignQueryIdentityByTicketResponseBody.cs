// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignQueryIdentityByTicketResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EsignQueryIdentityByTicketResponseBodyResult Result { get; set; }
        public class EsignQueryIdentityByTicketResponseBodyResult : TeaModel {
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
