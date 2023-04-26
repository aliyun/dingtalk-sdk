// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateWorkTimeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateWorkTimeResponseBodyResult Result { get; set; }
        public class CreateWorkTimeResponseBodyResult : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public List<CreateWorkTimeResponseBodyResultBody> Body { get; set; }
            public class CreateWorkTimeResponseBodyResultBody : TeaModel {
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("workTime")]
                [Validation(Required=false)]
                public long? WorkTime { get; set; }

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
