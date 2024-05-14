// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfScoreResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateKROfScoreResponseBodyData Data { get; set; }
        public class UpdateKROfScoreResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("objectiveScore")]
            [Validation(Required=false)]
            public long? ObjectiveScore { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
