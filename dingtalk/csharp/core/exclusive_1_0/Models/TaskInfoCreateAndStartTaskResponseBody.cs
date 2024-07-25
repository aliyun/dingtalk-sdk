// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class TaskInfoCreateAndStartTaskResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public TaskInfoCreateAndStartTaskResponseBodyData Data { get; set; }
        public class TaskInfoCreateAndStartTaskResponseBodyData : TeaModel {
            [NameInMap("groupVoList")]
            [Validation(Required=false)]
            public List<TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList> GroupVoList { get; set; }
            public class TaskInfoCreateAndStartTaskResponseBodyDataGroupVoList : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

            }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
