// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetSceneGroupMembersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidXXXXXXXXX==</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public List<string> MemberUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>92233720368</para>
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
