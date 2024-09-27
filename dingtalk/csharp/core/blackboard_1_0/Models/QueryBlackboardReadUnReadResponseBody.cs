// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkblackboard_1_0.Models
{
    public class QueryBlackboardReadUnReadResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("users")]
        [Validation(Required=false)]
        public List<QueryBlackboardReadUnReadResponseBodyUsers> Users { get; set; }
        public class QueryBlackboardReadUnReadResponseBodyUsers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("read")]
            [Validation(Required=false)]
            public string Read { get; set; }

            [NameInMap("readTimestamp")]
            [Validation(Required=false)]
            public long? ReadTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12039</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
