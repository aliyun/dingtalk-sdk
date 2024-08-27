// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetTodoTasksResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGetTodoTasksResponseBodyResult Result { get; set; }
        public class PremiumGetTodoTasksResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<PremiumGetTodoTasksResponseBodyResultList> List { get; set; }
            public class PremiumGetTodoTasksResponseBodyResultList : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("appType")]
                [Validation(Required=false)]
                public int? AppType { get; set; }

                [NameInMap("formMassage")]
                [Validation(Required=false)]
                public string FormMassage { get; set; }

                [NameInMap("originatorId")]
                [Validation(Required=false)]
                public string OriginatorId { get; set; }

                [NameInMap("originatorName")]
                [Validation(Required=false)]
                public string OriginatorName { get; set; }

                [NameInMap("originatorPhoto")]
                [Validation(Required=false)]
                public string OriginatorPhoto { get; set; }

                /// <summary>
                /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                /// </summary>
                [NameInMap("processCreateTime")]
                [Validation(Required=false)]
                public string ProcessCreateTime { get; set; }

                /// <summary>
                /// Use the UTC time format: yyyy-MM-ddTHH:mmZ
                /// </summary>
                [NameInMap("processEndTime")]
                [Validation(Required=false)]
                public string ProcessEndTime { get; set; }

                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("processType")]
                [Validation(Required=false)]
                public int? ProcessType { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
