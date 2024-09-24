// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GroupQueryByAttrResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GroupQueryByAttrResponseBodyData Data { get; set; }
        public class GroupQueryByAttrResponseBodyData : TeaModel {
            [NameInMap("counts")]
            [Validation(Required=false)]
            public long? Counts { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GroupQueryByAttrResponseBodyDataList> List { get; set; }
            public class GroupQueryByAttrResponseBodyDataList : TeaModel {
                [NameInMap("groupMemberCount")]
                [Validation(Required=false)]
                public int? GroupMemberCount { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                [NameInMap("ownerJobNo")]
                [Validation(Required=false)]
                public string OwnerJobNo { get; set; }

                [NameInMap("ownerUserName")]
                [Validation(Required=false)]
                public string OwnerUserName { get; set; }

            }

            [NameInMap("pageIndex")]
            [Validation(Required=false)]
            public long? PageIndex { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
