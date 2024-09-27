// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class QueryBatchSendResultResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<QueryBatchSendResultResponseBodyResults> Results { get; set; }
        public class QueryBatchSendResultResponseBodyResults : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123@channel</para>
            /// </summary>
            [NameInMap("appUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cid1234567890==</para>
            /// </summary>
            [NameInMap("conversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>msg1234567890==</para>
            /// </summary>
            [NameInMap("msgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
