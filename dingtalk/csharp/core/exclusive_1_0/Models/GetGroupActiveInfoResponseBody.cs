// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetGroupActiveInfoResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetGroupActiveInfoResponseBodyData> Data { get; set; }
        public class GetGroupActiveInfoResponseBodyData : TeaModel {
            [NameInMap("dingGroupId")]
            [Validation(Required=false)]
            public string DingGroupId { get; set; }

            [NameInMap("groupCreateTime")]
            [Validation(Required=false)]
            public string GroupCreateTime { get; set; }

            [NameInMap("groupCreateUserId")]
            [Validation(Required=false)]
            public string GroupCreateUserId { get; set; }

            [NameInMap("groupCreateUserName")]
            [Validation(Required=false)]
            public string GroupCreateUserName { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("groupType")]
            [Validation(Required=false)]
            public long? GroupType { get; set; }

            [NameInMap("groupUserCnt1d")]
            [Validation(Required=false)]
            public int? GroupUserCnt1d { get; set; }

            [NameInMap("openConvUv1d")]
            [Validation(Required=false)]
            public int? OpenConvUv1d { get; set; }

            [NameInMap("sendMessageCnt1d")]
            [Validation(Required=false)]
            public long? SendMessageCnt1d { get; set; }

            [NameInMap("sendMessageUserCnt1d")]
            [Validation(Required=false)]
            public long? SendMessageUserCnt1d { get; set; }

            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
