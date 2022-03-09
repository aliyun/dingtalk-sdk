// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class CreateKeyResultRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public Stream Content { get; set; }

        [NameInMap("objectiveId")]
        [Validation(Required=false)]
        public Stream ObjectiveId { get; set; }

        [NameInMap("periodId")]
        [Validation(Required=false)]
        public Stream PeriodId { get; set; }

        [NameInMap("prevPosition")]
        [Validation(Required=false)]
        public long? PrevPosition { get; set; }

        [NameInMap("weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        [NameInMap("ownerId")]
        [Validation(Required=false)]
        public Stream OwnerId { get; set; }

    }

}
