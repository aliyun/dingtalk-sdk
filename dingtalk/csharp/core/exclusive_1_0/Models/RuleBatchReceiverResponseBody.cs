// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class RuleBatchReceiverResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<RuleBatchReceiverResponseBodyData> Data { get; set; }
        public class RuleBatchReceiverResponseBodyData : TeaModel {
            [NameInMap("msgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("msgId")]
        [Validation(Required=false)]
        public string MsgId { get; set; }

        [NameInMap("rows")]
        [Validation(Required=false)]
        public List<List<RuleBatchReceiverResponseBodyRows>> Rows { get; set; }
        public class RuleBatchReceiverResponseBodyRows : TeaModel {
            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("msgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

        }

    }

}
