// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveCreateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ProcessApproveCreateResponseBodyResult Result { get; set; }
        public class ProcessApproveCreateResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dingtalkApproveId")]
            [Validation(Required=false)]
            public string DingtalkApproveId { get; set; }

        }

    }

}
