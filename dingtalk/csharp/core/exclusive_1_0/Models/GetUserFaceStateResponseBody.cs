// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserFaceStateResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUserFaceStateResponseBodyData> Data { get; set; }
        public class GetUserFaceStateResponseBodyData : TeaModel {
            /// <summary>
            /// 人脸录入状态 1-无人脸 2-有人脸
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
