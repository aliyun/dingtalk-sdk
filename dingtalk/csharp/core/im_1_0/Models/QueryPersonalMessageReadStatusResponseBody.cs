// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryPersonalMessageReadStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPersonalMessageReadStatusResponseBodyResult Result { get; set; }
        public class QueryPersonalMessageReadStatusResponseBodyResult : TeaModel {
            [NameInMap("messageReadInfoList")]
            [Validation(Required=false)]
            public List<QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList> MessageReadInfoList { get; set; }
            public class QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList : TeaModel {
                [NameInMap("readStatus")]
                [Validation(Required=false)]
                public string ReadStatus { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
