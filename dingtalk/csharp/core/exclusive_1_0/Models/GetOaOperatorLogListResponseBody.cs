// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetOaOperatorLogListResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetOaOperatorLogListResponseBodyData> Data { get; set; }
        public class GetOaOperatorLogListResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("category1Name")]
            [Validation(Required=false)]
            public string Category1Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("category2Name")]
            [Validation(Required=false)]
            public string Category2Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("opName")]
            [Validation(Required=false)]
            public string OpName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("opTime")]
            [Validation(Required=false)]
            public long? OpTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("opUserId")]
            [Validation(Required=false)]
            public string OpUserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("itemCount")]
        [Validation(Required=false)]
        public long? ItemCount { get; set; }

    }

}
