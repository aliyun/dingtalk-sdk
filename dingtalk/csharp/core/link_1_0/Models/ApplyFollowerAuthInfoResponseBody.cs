// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ApplyFollowerAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ApplyFollowerAuthInfoResponseBodyResult Result { get; set; }
        public class ApplyFollowerAuthInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openApplyId")]
            [Validation(Required=false)]
            public string OpenApplyId { get; set; }

        }

    }

}
