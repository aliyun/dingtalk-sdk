// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryCardVisitorStatisticDataResponseBody : TeaModel {
        /// <summary>
        /// 发送名片数
        /// </summary>
        [NameInMap("cardSendCnt")]
        [Validation(Required=false)]
        public long? CardSendCnt { get; set; }

        /// <summary>
        /// 今日访客增加数
        /// </summary>
        [NameInMap("todayVisitAddCnt")]
        [Validation(Required=false)]
        public long? TodayVisitAddCnt { get; set; }

        /// <summary>
        /// 今日访客数
        /// </summary>
        [NameInMap("todayVisitCnt")]
        [Validation(Required=false)]
        public long? TodayVisitCnt { get; set; }

        /// <summary>
        /// 总访客新增数
        /// </summary>
        [NameInMap("totalVisitAddCnt")]
        [Validation(Required=false)]
        public long? TotalVisitAddCnt { get; set; }

        /// <summary>
        /// 总访客数
        /// </summary>
        [NameInMap("totalVisitCnt")]
        [Validation(Required=false)]
        public long? TotalVisitCnt { get; set; }

        /// <summary>
        /// 微信今日访客新增数
        /// </summary>
        [NameInMap("wechatTodayVisitAddCnt")]
        [Validation(Required=false)]
        public long? WechatTodayVisitAddCnt { get; set; }

        /// <summary>
        /// 微信今日访客数
        /// </summary>
        [NameInMap("wechatTodayVisitCnt")]
        [Validation(Required=false)]
        public long? WechatTodayVisitCnt { get; set; }

        /// <summary>
        /// 微信今日访客增加数
        /// </summary>
        [NameInMap("wechatTotalVisitAddCnt")]
        [Validation(Required=false)]
        public long? WechatTotalVisitAddCnt { get; set; }

        /// <summary>
        /// 微信访客数
        /// </summary>
        [NameInMap("wechatTotalVisitCnt")]
        [Validation(Required=false)]
        public long? WechatTotalVisitCnt { get; set; }

    }

}
