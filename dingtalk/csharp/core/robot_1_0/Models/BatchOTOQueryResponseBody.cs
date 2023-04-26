// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchOTOQueryResponseBody : TeaModel {
        [NameInMap("messageReadInfoList")]
        [Validation(Required=false)]
        public List<BatchOTOQueryResponseBodyMessageReadInfoList> MessageReadInfoList { get; set; }
        public class BatchOTOQueryResponseBodyMessageReadInfoList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public string ReadStatus { get; set; }

            [NameInMap("readTimestamp")]
            [Validation(Required=false)]
            public long? ReadTimestamp { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("sendStatus")]
        [Validation(Required=false)]
        public string SendStatus { get; set; }

    }

}
