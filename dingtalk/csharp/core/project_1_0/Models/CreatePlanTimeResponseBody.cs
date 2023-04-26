// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreatePlanTimeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreatePlanTimeResponseBodyResult Result { get; set; }
        public class CreatePlanTimeResponseBodyResult : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public List<CreatePlanTimeResponseBodyResultBody> Body { get; set; }
            public class CreatePlanTimeResponseBodyResultBody : TeaModel {
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("objectId")]
                [Validation(Required=false)]
                public string ObjectId { get; set; }

                [NameInMap("planTime")]
                [Validation(Required=false)]
                public long? PlanTime { get; set; }

            }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("ok")]
            [Validation(Required=false)]
            public bool? Ok { get; set; }

        }

    }

}
