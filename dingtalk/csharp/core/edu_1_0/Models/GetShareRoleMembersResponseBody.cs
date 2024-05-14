// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetShareRoleMembersResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetShareRoleMembersResponseBodyResult> Result { get; set; }
        public class GetShareRoleMembersResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("memberUserIdListInTrunkOrg")]
            [Validation(Required=false)]
            public List<string> MemberUserIdListInTrunkOrg { get; set; }

        }

    }

}
