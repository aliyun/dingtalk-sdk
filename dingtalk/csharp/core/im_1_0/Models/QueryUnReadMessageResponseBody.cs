// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUnReadMessageResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("unReadCount")]
        [Validation(Required=false)]
        public long? UnReadCount { get; set; }

        [NameInMap("unReadItems")]
        [Validation(Required=false)]
        public List<QueryUnReadMessageResponseBodyUnReadItems> UnReadItems { get; set; }
        public class QueryUnReadMessageResponseBodyUnReadItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>14da****2760</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("unReadCount")]
            [Validation(Required=false)]
            public long? UnReadCount { get; set; }

        }

    }

}
