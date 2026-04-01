// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class ListDeviceResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDeviceResponseBodyResult> Result { get; set; }
        public class ListDeviceResponseBodyResult : TeaModel {
            [NameInMap("bindTimestamp")]
            [Validation(Required=false)]
            public long? BindTimestamp { get; set; }

            [NameInMap("sn")]
            [Validation(Required=false)]
            public string Sn { get; set; }

            [NameInMap("teamCode")]
            [Validation(Required=false)]
            public string TeamCode { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
