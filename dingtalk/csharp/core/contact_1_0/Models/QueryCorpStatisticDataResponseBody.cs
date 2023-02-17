// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryCorpStatisticDataResponseBody : TeaModel {
        /// <summary>
        /// 被收下总数
        /// </summary>
        [NameInMap("cardBeReceivedTotalCnt")]
        [Validation(Required=false)]
        public long? CardBeReceivedTotalCnt { get; set; }

        /// <summary>
        /// 收下总数
        /// </summary>
        [NameInMap("cardReceiveTotalCnt")]
        [Validation(Required=false)]
        public long? CardReceiveTotalCnt { get; set; }

        /// <summary>
        /// 被查看总数
        /// </summary>
        [NameInMap("cardTotalBeVisitedCnt")]
        [Validation(Required=false)]
        public long? CardTotalBeVisitedCnt { get; set; }

        /// <summary>
        /// 数据日期
        /// </summary>
        [NameInMap("dataDate")]
        [Validation(Required=false)]
        public string DataDate { get; set; }

        /// <summary>
        /// 钉钉发送数
        /// </summary>
        [NameInMap("dingTotalShareCnt")]
        [Validation(Required=false)]
        public long? DingTotalShareCnt { get; set; }

        /// <summary>
        /// 总发送数
        /// </summary>
        [NameInMap("totalSendCnt")]
        [Validation(Required=false)]
        public long? TotalSendCnt { get; set; }

        /// <summary>
        /// 微信发送数
        /// </summary>
        [NameInMap("wechatTotalShareCnt")]
        [Validation(Required=false)]
        public long? WechatTotalShareCnt { get; set; }

    }

}
