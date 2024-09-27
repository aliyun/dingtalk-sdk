// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SearchInnerGroupsResponseBody : TeaModel {
        [NameInMap("groupInfos")]
        [Validation(Required=false)]
        public List<SearchInnerGroupsResponseBodyGroupInfos> GroupInfos { get; set; }
        public class SearchInnerGroupsResponseBodyGroupInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>@lAD*****</para>
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
            /// <para>cid13*****==</para>
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

    }

}
