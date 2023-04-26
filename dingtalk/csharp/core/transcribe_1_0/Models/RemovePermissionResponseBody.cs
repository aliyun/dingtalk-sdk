// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktranscribe_1_0.Models
{
    public class RemovePermissionResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public RemovePermissionResponseBodyData Data { get; set; }
        public class RemovePermissionResponseBodyData : TeaModel {
            [NameInMap("failNameList")]
            [Validation(Required=false)]
            public List<string> FailNameList { get; set; }

        }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
