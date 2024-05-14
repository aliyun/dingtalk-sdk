// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetATManageScopeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetATManageScopeResponseBodyResult> Result { get; set; }
        public class GetATManageScopeResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("manageScope")]
            [Validation(Required=false)]
            public string ManageScope { get; set; }

            [NameInMap("userIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
