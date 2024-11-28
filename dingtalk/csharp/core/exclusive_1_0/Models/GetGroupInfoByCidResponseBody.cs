// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGroupInfoByCidResponseBody : TeaModel {
        [NameInMap("groupInfo")]
        [Validation(Required=false)]
        public GetGroupInfoByCidResponseBodyGroupInfo GroupInfo { get; set; }
        public class GetGroupInfoByCidResponseBodyGroupInfo : TeaModel {
            [NameInMap("allOrgMember")]
            [Validation(Required=false)]
            public bool? AllOrgMember { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("groupNumber")]
            [Validation(Required=false)]
            public long? GroupNumber { get; set; }

            [NameInMap("groupOrganization")]
            [Validation(Required=false)]
            public long? GroupOrganization { get; set; }

            [NameInMap("joinGroupUrl")]
            [Validation(Required=false)]
            public string JoinGroupUrl { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

    }

}
