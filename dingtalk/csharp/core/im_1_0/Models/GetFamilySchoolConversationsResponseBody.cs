// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetFamilySchoolConversationsResponseBody : TeaModel {
        [NameInMap("groupInfoList")]
        [Validation(Required=false)]
        public List<GetFamilySchoolConversationsResponseBodyGroupInfoList> GroupInfoList { get; set; }
        public class GetFamilySchoolConversationsResponseBodyGroupInfoList : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deptNameChain")]
            [Validation(Required=false)]
            public List<string> DeptNameChain { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("joinGroupTime")]
            [Validation(Required=false)]
            public long? JoinGroupTime { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public string HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
