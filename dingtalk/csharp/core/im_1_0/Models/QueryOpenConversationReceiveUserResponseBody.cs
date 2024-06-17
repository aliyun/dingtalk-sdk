// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryOpenConversationReceiveUserResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryOpenConversationReceiveUserResponseBodyResult Result { get; set; }
        public class QueryOpenConversationReceiveUserResponseBodyResult : TeaModel {
            [NameInMap("receiveUser")]
            [Validation(Required=false)]
            public QueryOpenConversationReceiveUserResponseBodyResultReceiveUser ReceiveUser { get; set; }
            public class QueryOpenConversationReceiveUserResponseBodyResultReceiveUser : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
