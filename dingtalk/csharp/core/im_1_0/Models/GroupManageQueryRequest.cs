// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupManageQueryRequest : TeaModel {
        [NameInMap("createdAfter")]
        [Validation(Required=false)]
        public long? CreatedAfter { get; set; }

        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("groupMemberSamples")]
        [Validation(Required=false)]
        public List<string> GroupMemberSamples { get; set; }

        [NameInMap("groupOwner")]
        [Validation(Required=false)]
        public string GroupOwner { get; set; }

        [NameInMap("groupTitleKeywords")]
        [Validation(Required=false)]
        public List<string> GroupTitleKeywords { get; set; }

        [NameInMap("groupUrl")]
        [Validation(Required=false)]
        public string GroupUrl { get; set; }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("membersOver")]
        [Validation(Required=false)]
        public int? MembersOver { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
