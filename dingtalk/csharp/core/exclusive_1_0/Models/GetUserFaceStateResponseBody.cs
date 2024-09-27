// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserFaceStateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUserFaceStateResponseBodyData> Data { get; set; }
        public class GetUserFaceStateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

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
