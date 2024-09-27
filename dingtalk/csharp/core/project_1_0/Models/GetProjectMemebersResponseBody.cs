// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetProjectMemebersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetProjectMemebersResponseBodyResult> Result { get; set; }
        public class GetProjectMemebersResponseBodyResult : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para>62c25e3b376ec29c45xxxxx</para>
            /// </summary>
            [NameInMap("memberId")]
            [Validation(Required=false)]
            [Obsolete]
            public string MemberId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

            [NameInMap("roleIds")]
            [Validation(Required=false)]
            public List<string> RoleIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0715153011125xxxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
