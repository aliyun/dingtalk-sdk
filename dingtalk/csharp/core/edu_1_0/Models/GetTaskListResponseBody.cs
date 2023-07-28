// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetTaskListResponseBody : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("taskList")]
        [Validation(Required=false)]
        public List<GetTaskListResponseBodyTaskList> TaskList { get; set; }
        public class GetTaskListResponseBodyTaskList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("taskYear")]
            [Validation(Required=false)]
            public long? TaskYear { get; set; }

        }

    }

}
