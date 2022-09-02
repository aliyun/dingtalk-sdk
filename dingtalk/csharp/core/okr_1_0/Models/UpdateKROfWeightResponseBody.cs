// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfWeightResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateKROfWeightResponseBodyData Data { get; set; }
        public class UpdateKROfWeightResponseBodyData : TeaModel {
            [NameInMap("objectiveProgress")]
            [Validation(Required=false)]
            public UpdateKROfWeightResponseBodyDataObjectiveProgress ObjectiveProgress { get; set; }
            public class UpdateKROfWeightResponseBodyDataObjectiveProgress : TeaModel {
                /// <summary>
                /// 目标百分比。
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

            }

            /// <summary>
            /// 目标分数。
            /// </summary>
            [NameInMap("objectiveScore")]
            [Validation(Required=false)]
            public long? ObjectiveScore { get; set; }

        }

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
