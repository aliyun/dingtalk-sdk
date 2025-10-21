// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SearchOrgInnerGroupInfoByCursorPageResponseBody : TeaModel {
        [NameInMap("hasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchOrgInnerGroupInfoByCursorPageResponseBodyItems> Items { get; set; }
        public class SearchOrgInnerGroupInfoByCursorPageResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1756656000000</para>
            /// </summary>
            [NameInMap("groupCreateTime")]
            [Validation(Required=false)]
            public long? GroupCreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("groupMembersCnt")]
            [Validation(Required=false)]
            public int? GroupMembersCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>内部群</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public string GroupOwner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user123</para>
            /// </summary>
            [NameInMap("groupOwnerUserId")]
            [Validation(Required=false)]
            public string GroupOwnerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cid123</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("syncToDingpan")]
            [Validation(Required=false)]
            public int? SyncToDingpan { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

    }

}
