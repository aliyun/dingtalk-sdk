// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetFollowerInfoResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFollowerInfoResponseBodyResult Result { get; set; }
        public class GetFollowerInfoResponseBodyResult : TeaModel {
            [NameInMap("user")]
            [Validation(Required=false)]
            public GetFollowerInfoResponseBodyResultUser User { get; set; }
            public class GetFollowerInfoResponseBodyResultUser : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>小钉</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1661918406748</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>userId</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
