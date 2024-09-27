// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SearchOrgInnerGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("itemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchOrgInnerGroupInfoResponseBodyItems> Items { get; set; }
        public class SearchOrgInnerGroupInfoResponseBodyItems : TeaModel {
            [NameInMap("extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupAdminsCount")]
            [Validation(Required=false)]
            public int? GroupAdminsCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupCreateTime")]
            [Validation(Required=false)]
            public long? GroupCreateTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupLastActiveTime")]
            [Validation(Required=false)]
            public long? GroupLastActiveTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupLastActiveTimeShow")]
            [Validation(Required=false)]
            public string GroupLastActiveTimeShow { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupMembersCount")]
            [Validation(Required=false)]
            public int? GroupMembersCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public string GroupOwner { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("groupOwnerUserId")]
            [Validation(Required=false)]
            public string GroupOwnerUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("syncToDingpan")]
            [Validation(Required=false)]
            public int? SyncToDingpan { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
