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
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cardBeReceivedTotalCnt")]
            [Validation(Required=false)]
            public long? CardBeReceivedTotalCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("cardReceiveTotalCnt")]
            [Validation(Required=false)]
            public long? CardReceiveTotalCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cardTotalBeVisitedCnt")]
            [Validation(Required=false)]
            public long? CardTotalBeVisitedCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20230101</para>
            /// </summary>
            [NameInMap("dataDate")]
            [Validation(Required=false)]
            public string DataDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("dingTotalShareCnt")]
            [Validation(Required=false)]
            public long? DingTotalShareCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalSendCnt")]
            [Validation(Required=false)]
            public long? TotalSendCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("wechatTotalShareCnt")]
            [Validation(Required=false)]
            public long? WechatTotalShareCnt { get; set; }

        }

    }

}
