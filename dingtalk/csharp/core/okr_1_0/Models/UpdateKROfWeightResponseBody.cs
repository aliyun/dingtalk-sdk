// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfWeightResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateKROfWeightResponseBodyData Data { get; set; }
        public class UpdateKROfWeightResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("objectiveProgress")]
            [Validation(Required=false)]
            public UpdateKROfWeightResponseBodyDataObjectiveProgress ObjectiveProgress { get; set; }
            public class UpdateKROfWeightResponseBodyDataObjectiveProgress : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

            }

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
