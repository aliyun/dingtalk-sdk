// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetNewestInnerGroupsResponseBody : TeaModel {
        /// <summary>
        /// 群列表
        /// </summary>
        [NameInMap("groupInfos")]
        [Validation(Required=false)]
        public List<GetNewestInnerGroupsResponseBodyGroupInfos> GroupInfos { get; set; }
        public class GetNewestInnerGroupsResponseBodyGroupInfos : TeaModel {
            /// <summary>
            /// 群头像。
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 群成员人数。
            /// </summary>
            [NameInMap("memberAmount")]
            [Validation(Required=false)]
            public string MemberAmount { get; set; }

            /// <summary>
            /// 群聊会话id。
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 群名称。
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
