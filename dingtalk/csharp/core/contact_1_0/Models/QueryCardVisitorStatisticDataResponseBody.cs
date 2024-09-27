// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryCardVisitorStatisticDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cardSendCnt")]
        [Validation(Required=false)]
        public long? CardSendCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("todayVisitAddCnt")]
        [Validation(Required=false)]
        public long? TodayVisitAddCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("todayVisitCnt")]
        [Validation(Required=false)]
        public long? TodayVisitCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalVisitAddCnt")]
        [Validation(Required=false)]
        public long? TotalVisitAddCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalVisitCnt")]
        [Validation(Required=false)]
        public long? TotalVisitCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("wechatTodayVisitAddCnt")]
        [Validation(Required=false)]
        public long? WechatTodayVisitAddCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("wechatTodayVisitCnt")]
        [Validation(Required=false)]
        public long? WechatTodayVisitCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("wechatTotalVisitAddCnt")]
        [Validation(Required=false)]
        public long? WechatTotalVisitAddCnt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("wechatTotalVisitCnt")]
        [Validation(Required=false)]
        public long? WechatTotalVisitCnt { get; set; }

    }

}
