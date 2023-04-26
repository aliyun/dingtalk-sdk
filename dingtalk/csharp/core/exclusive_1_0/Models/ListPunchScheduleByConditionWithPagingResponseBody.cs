// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListPunchScheduleByConditionWithPagingResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListPunchScheduleByConditionWithPagingResponseBodyList> List { get; set; }
        public class ListPunchScheduleByConditionWithPagingResponseBodyList : TeaModel {
            [NameInMap("bizOuterId")]
            [Validation(Required=false)]
            public string BizOuterId { get; set; }

            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            [NameInMap("punchSymbol")]
            [Validation(Required=false)]
            public string PunchSymbol { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userPunchTime")]
            [Validation(Required=false)]
            public long? UserPunchTime { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
