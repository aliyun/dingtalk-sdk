// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryUserResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<BatchQueryUserResponseBodyData> Data { get; set; }
        public class BatchQueryUserResponseBodyData : TeaModel {
            /// <summary>
            /// 所属者头像。 ID
            /// </summary>
            [NameInMap("avatarMediaId")]
            [Validation(Required=false)]
            public Stream AvatarMediaId { get; set; }

            /// <summary>
            /// 所属者头像。 URL
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public Stream AvatarUrl { get; set; }

            /// <summary>
            /// 所属者组织 I。D
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public Stream CorpId { get; set; }

            /// <summary>
            /// 所属者在 OKR 系统中的 ID。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

            /// <summary>
            /// 所属者昵称。
            /// </summary>
            [NameInMap("nickname")]
            [Validation(Required=false)]
            public Stream Nickname { get; set; }

            /// <summary>
            /// 所属者 userId。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public Stream UserId { get; set; }

        }

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
