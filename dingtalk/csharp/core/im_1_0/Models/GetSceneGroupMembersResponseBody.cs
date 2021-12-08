// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetSceneGroupMembersResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 群成员员工号
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public List<string> MemberUserIds { get; set; }

        /// <summary>
        /// 下一次请求的游标
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
