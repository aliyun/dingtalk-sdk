// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SearchOrgInnerGroupInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("itemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchOrgInnerGroupInfoResponseBodyItems> Items { get; set; }
        public class SearchOrgInnerGroupInfoResponseBodyItems : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupAdminsCount")]
            [Validation(Required=false)]
            public int? GroupAdminsCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupCreateTime")]
            [Validation(Required=false)]
            public long? GroupCreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupLastActiveTime")]
            [Validation(Required=false)]
            public long? GroupLastActiveTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupLastActiveTimeShow")]
            [Validation(Required=false)]
            public string GroupLastActiveTimeShow { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupMembersCount")]
            [Validation(Required=false)]
            public int? GroupMembersCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public string GroupOwner { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupOwnerUserId")]
            [Validation(Required=false)]
            public string GroupOwnerUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("syncToDingpan")]
            [Validation(Required=false)]
            public int? SyncToDingpan { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
