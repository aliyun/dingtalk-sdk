// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class ListSlsLogResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public ListSlsLogResponseBodyContent Content { get; set; }
        public class ListSlsLogResponseBodyContent : TeaModel {
            [NameInMap("currentPageSize")]
            [Validation(Required=false)]
            public long? CurrentPageSize { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public List<SlsLogResp> Data { get; set; }

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("pages")]
            [Validation(Required=false)]
            public long? Pages { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
