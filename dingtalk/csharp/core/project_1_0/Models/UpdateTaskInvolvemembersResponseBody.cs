// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskInvolvemembersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskInvolvemembersResponseBodyResult Result { get; set; }
        public class UpdateTaskInvolvemembersResponseBodyResult : TeaModel {
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
