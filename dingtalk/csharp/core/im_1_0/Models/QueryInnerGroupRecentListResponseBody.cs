// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryInnerGroupRecentListResponseBody : TeaModel {
        [NameInMap("groupInfos")]
        [Validation(Required=false)]
        public List<QueryInnerGroupRecentListResponseBodyGroupInfos> GroupInfos { get; set; }
        public class QueryInnerGroupRecentListResponseBodyGroupInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://static.xxxxxxx">https://static.xxxxxxx</a></para>
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("memberAmount")]
            [Validation(Required=false)]
            public string MemberAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cid1e*****==</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>测试群名称</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
