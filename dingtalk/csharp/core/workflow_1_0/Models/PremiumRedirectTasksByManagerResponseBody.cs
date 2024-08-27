// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumRedirectTasksByManagerResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumRedirectTasksByManagerResponseBodyResult Result { get; set; }
        public class PremiumRedirectTasksByManagerResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("redirectResults")]
            [Validation(Required=false)]
            public List<PremiumRedirectTasksByManagerResponseBodyResultRedirectResults> RedirectResults { get; set; }
            public class PremiumRedirectTasksByManagerResponseBodyResultRedirectResults : TeaModel {
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
