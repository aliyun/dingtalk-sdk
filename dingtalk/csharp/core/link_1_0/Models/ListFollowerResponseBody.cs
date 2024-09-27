// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ListFollowerResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFollowerResponseBodyResult Result { get; set; }
        public class ListFollowerResponseBodyResult : TeaModel {
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("userList")]
            [Validation(Required=false)]
            public List<ListFollowerResponseBodyResultUserList> UserList { get; set; }
            public class ListFollowerResponseBodyResultUserList : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
