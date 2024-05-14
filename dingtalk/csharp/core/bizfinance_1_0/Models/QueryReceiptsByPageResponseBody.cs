// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsByPageResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryReceiptsByPageResponseBodyList> List { get; set; }
        public class QueryReceiptsByPageResponseBodyList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

        }

    }

}
