// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class QueryBatchSendResultResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<QueryBatchSendResultResponseBodyResults> Results { get; set; }
        public class QueryBatchSendResultResponseBodyResults : TeaModel {
            [NameInMap("appUid")]
            [Validation(Required=false)]
            public string AppUid { get; set; }

            [NameInMap("conversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("msgId")]
            [Validation(Required=false)]
            public string MsgId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
