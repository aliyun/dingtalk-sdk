// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkevent_1_0.Models
{
    public class GetCallBackFaileResultResponseBody : TeaModel {
        [NameInMap("failedList")]
        [Validation(Required=false)]
        public List<GetCallBackFaileResultResponseBodyFailedList> FailedList { get; set; }
        public class GetCallBackFaileResultResponseBodyFailedList : TeaModel {
            [NameInMap("callBackData")]
            [Validation(Required=false)]
            public string CallBackData { get; set; }

            [NameInMap("callBackTag")]
            [Validation(Required=false)]
            public string CallBackTag { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

    }

}
