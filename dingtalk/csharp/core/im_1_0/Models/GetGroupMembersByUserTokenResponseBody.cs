// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetGroupMembersByUserTokenResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("memberUnionIds")]
        [Validation(Required=false)]
        public List<string> MemberUnionIds { get; set; }

        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public List<string> MemberUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>92233720368</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("staffIdNickMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> StaffIdNickMap { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("unionIdNickMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> UnionIdNickMap { get; set; }

    }

}
