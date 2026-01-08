// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class UpdatePermissionResponseBody : TeaModel {
        [NameInMap("failMemberInfoList")]
        [Validation(Required=false)]
        public List<UpdatePermissionResponseBodyFailMemberInfoList> FailMemberInfoList { get; set; }
        public class UpdatePermissionResponseBodyFailMemberInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("memberType")]
            [Validation(Required=false)]
            public int? MemberType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>lJcRnm39OsU4jlFVmRGXXXXX</para>
            /// </summary>
            [NameInMap("memberUnionId")]
            [Validation(Required=false)]
            public string MemberUnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("policyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

        }

    }

}
