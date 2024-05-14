// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryPointAutoIssueSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPointAutoIssueSettingResponseBodyResult Result { get; set; }
        public class QueryPointAutoIssueSettingResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("pointAutoNum")]
            [Validation(Required=false)]
            public long? PointAutoNum { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("pointAutoState")]
            [Validation(Required=false)]
            public bool? PointAutoState { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("pointAutoTime")]
            [Validation(Required=false)]
            public long? PointAutoTime { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
