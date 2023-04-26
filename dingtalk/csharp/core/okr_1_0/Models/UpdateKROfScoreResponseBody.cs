// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfScoreResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateKROfScoreResponseBodyData Data { get; set; }
        public class UpdateKROfScoreResponseBodyData : TeaModel {
            [NameInMap("objectiveScore")]
            [Validation(Required=false)]
            public long? ObjectiveScore { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
