// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryVerifyResultResponseBody : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("factorCode")]
        [Validation(Required=false)]
        public string FactorCode { get; set; }

        [NameInMap("factorDesc")]
        [Validation(Required=false)]
        public string FactorDesc { get; set; }

        [NameInMap("resultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("resultDesc")]
        [Validation(Required=false)]
        public string ResultDesc { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("verifyTimestamp")]
        [Validation(Required=false)]
        public long? VerifyTimestamp { get; set; }

    }

}
