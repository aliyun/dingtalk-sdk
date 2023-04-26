// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QuerySingleGroupRequest : TeaModel {
        [NameInMap("groupMembers")]
        [Validation(Required=false)]
        public List<QuerySingleGroupRequestGroupMembers> GroupMembers { get; set; }
        public class QuerySingleGroupRequestGroupMembers : TeaModel {
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

    }

}
