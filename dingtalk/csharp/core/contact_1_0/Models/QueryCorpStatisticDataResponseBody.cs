// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryCorpStatisticDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryCorpStatisticDataResponseBodyResult> Result { get; set; }
        public class QueryCorpStatisticDataResponseBodyResult : TeaModel {
            [NameInMap("cardBeReceivedTotalCnt")]
            [Validation(Required=false)]
            public long? CardBeReceivedTotalCnt { get; set; }

            [NameInMap("cardReceiveTotalCnt")]
            [Validation(Required=false)]
            public long? CardReceiveTotalCnt { get; set; }

            [NameInMap("cardTotalBeVisitedCnt")]
            [Validation(Required=false)]
            public long? CardTotalBeVisitedCnt { get; set; }

            [NameInMap("dataDate")]
            [Validation(Required=false)]
            public string DataDate { get; set; }

            [NameInMap("dingTotalShareCnt")]
            [Validation(Required=false)]
            public long? DingTotalShareCnt { get; set; }

            [NameInMap("totalSendCnt")]
            [Validation(Required=false)]
            public long? TotalSendCnt { get; set; }

            [NameInMap("wechatTotalShareCnt")]
            [Validation(Required=false)]
            public long? WechatTotalShareCnt { get; set; }

        }

    }

}
