// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListUserGroupsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListUserGroupsResponseBodyResult Result { get; set; }
        public class ListUserGroupsResponseBodyResult : TeaModel {
            [NameInMap("groups")]
            [Validation(Required=false)]
            public List<ListUserGroupsResponseBodyResultGroups> Groups { get; set; }
            public class ListUserGroupsResponseBodyResultGroups : TeaModel {
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("groupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                [NameInMap("groupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextOffset")]
            [Validation(Required=false)]
            public long? NextOffset { get; set; }

        }

    }

}
