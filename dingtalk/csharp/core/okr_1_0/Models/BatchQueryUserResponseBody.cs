// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryUserResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<BatchQueryUserResponseBodyData> Data { get; set; }
        public class BatchQueryUserResponseBodyData : TeaModel {
            [NameInMap("avatarMediaId")]
            [Validation(Required=false)]
            public Stream AvatarMediaId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public Stream AvatarUrl { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public Stream CorpId { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

            [NameInMap("nickname")]
            [Validation(Required=false)]
            public Stream Nickname { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public Stream UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
