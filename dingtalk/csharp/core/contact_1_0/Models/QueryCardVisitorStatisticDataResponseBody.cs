// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryCardVisitorStatisticDataResponseBody : TeaModel {
        [NameInMap("cardSendCnt")]
        [Validation(Required=false)]
        public long? CardSendCnt { get; set; }

        [NameInMap("todayVisitAddCnt")]
        [Validation(Required=false)]
        public long? TodayVisitAddCnt { get; set; }

        [NameInMap("todayVisitCnt")]
        [Validation(Required=false)]
        public long? TodayVisitCnt { get; set; }

        [NameInMap("totalVisitAddCnt")]
        [Validation(Required=false)]
        public long? TotalVisitAddCnt { get; set; }

        [NameInMap("totalVisitCnt")]
        [Validation(Required=false)]
        public long? TotalVisitCnt { get; set; }

        [NameInMap("wechatTodayVisitAddCnt")]
        [Validation(Required=false)]
        public long? WechatTodayVisitAddCnt { get; set; }

        [NameInMap("wechatTodayVisitCnt")]
        [Validation(Required=false)]
        public long? WechatTodayVisitCnt { get; set; }

        [NameInMap("wechatTotalVisitAddCnt")]
        [Validation(Required=false)]
        public long? WechatTotalVisitAddCnt { get; set; }

        [NameInMap("wechatTotalVisitCnt")]
        [Validation(Required=false)]
        public long? WechatTotalVisitCnt { get; set; }

    }

}
