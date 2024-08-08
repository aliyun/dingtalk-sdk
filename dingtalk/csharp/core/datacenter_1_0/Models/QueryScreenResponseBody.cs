// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryScreenResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryScreenResponseBodyResult> Result { get; set; }
        public class QueryScreenResponseBodyResult : TeaModel {
            [NameInMap("operatePermission")]
            [Validation(Required=false)]
            public string OperatePermission { get; set; }

            [NameInMap("screenId")]
            [Validation(Required=false)]
            public long? ScreenId { get; set; }

            [NameInMap("screenName")]
            [Validation(Required=false)]
            public string ScreenName { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("thumbUrl")]
            [Validation(Required=false)]
            public string ThumbUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
