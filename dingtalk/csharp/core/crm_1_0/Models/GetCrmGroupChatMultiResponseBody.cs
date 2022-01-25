// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCrmGroupChatMultiResponseBody : TeaModel {
        /// <summary>
        /// 客户群列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetCrmGroupChatMultiResponseBodyResult> Result { get; set; }
        public class GetCrmGroupChatMultiResponseBodyResult : TeaModel {
            /// <summary>
            /// 客户群openConversationId。
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 群组openGroupSetId。
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// 群主userId。
            /// </summary>
            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// 群主userName。
            /// </summary>
            [NameInMap("ownerUserName")]
            [Validation(Required=false)]
            public string OwnerUserName { get; set; }

            /// <summary>
            /// 客户群名
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 客户群成员数。
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            /// <summary>
            /// 创建时间(时间戳)。
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 群头像地址。
            /// </summary>
            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

        }

    }

}