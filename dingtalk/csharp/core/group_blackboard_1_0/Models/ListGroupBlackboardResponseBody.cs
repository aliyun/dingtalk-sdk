// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkgroup_blackboard_1_0.Models
{
    public class ListGroupBlackboardResponseBody : TeaModel {
        [NameInMap("blackboardList")]
        [Validation(Required=false)]
        public List<ListGroupBlackboardResponseBodyBlackboardList> BlackboardList { get; set; }
        public class ListGroupBlackboardResponseBodyBlackboardList : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("dataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("readCount")]
            [Validation(Required=false)]
            public int? ReadCount { get; set; }

            [NameInMap("sticky")]
            [Validation(Required=false)]
            public bool? Sticky { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextPageCursor")]
        [Validation(Required=false)]
        public string NextPageCursor { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
