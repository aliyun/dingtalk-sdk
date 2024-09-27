// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListFeedsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListFeedsResponseBodyItems> Items { get; set; }
        public class ListFeedsResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;{}&quot;</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12340000</para>
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
