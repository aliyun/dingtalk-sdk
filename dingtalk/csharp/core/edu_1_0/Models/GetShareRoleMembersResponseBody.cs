// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetShareRoleMembersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetShareRoleMembersResponseBodyResult> Result { get; set; }
        public class GetShareRoleMembersResponseBodyResult : TeaModel {
            /// <summary>
            /// 分支组织corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 角色成员在主干组织中的userId列表
            /// </summary>
            [NameInMap("memberUserIdListInTrunkOrg")]
            [Validation(Required=false)]
            public List<string> MemberUserIdListInTrunkOrg { get; set; }

        }

    }

}
