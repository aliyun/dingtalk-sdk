// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SearchOrgInnerGroupInfoResponseBody : TeaModel {
        [NameInMap("itemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<SearchOrgInnerGroupInfoResponseBodyItems> Items { get; set; }
        public class SearchOrgInnerGroupInfoResponseBodyItems : TeaModel {
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public string GroupOwner { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("groupAdminsCount")]
            [Validation(Required=false)]
            public int? GroupAdminsCount { get; set; }

            [NameInMap("groupMembersCount")]
            [Validation(Required=false)]
            public int? GroupMembersCount { get; set; }

            [NameInMap("groupCreateTime")]
            [Validation(Required=false)]
            public long? GroupCreateTime { get; set; }

            [NameInMap("groupLastActiveTime")]
            [Validation(Required=false)]
            public long? GroupLastActiveTime { get; set; }

            [NameInMap("groupLastActiveTimeShow")]
            [Validation(Required=false)]
            public string GroupLastActiveTimeShow { get; set; }

            [NameInMap("syncToDingpan")]
            [Validation(Required=false)]
            public int? SyncToDingpan { get; set; }

            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

            [NameInMap("groupOwnerUserId")]
            [Validation(Required=false)]
            public string GroupOwnerUserId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("templateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
