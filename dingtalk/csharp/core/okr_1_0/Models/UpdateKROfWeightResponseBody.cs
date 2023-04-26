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
                [NameInMap("percent")]
                [Validation(Required=false)]
                public long? Percent { get; set; }

            }

            [NameInMap("objectiveScore")]
            [Validation(Required=false)]
            public long? ObjectiveScore { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
