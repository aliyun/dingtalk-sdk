// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetAppResourceUseInfoResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<GetAppResourceUseInfoResponseBody> Body { get; set; }
        public class GetAppResourceUseInfoResponseBody : TeaModel {
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("usedNum")]
            [Validation(Required=false)]
            public long? UsedNum { get; set; }

            [NameInMap("quotaNum")]
            [Validation(Required=false)]
            public long? QuotaNum { get; set; }

        }

    }

}
