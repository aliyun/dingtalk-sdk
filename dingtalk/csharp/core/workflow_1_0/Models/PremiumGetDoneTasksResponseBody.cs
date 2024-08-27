// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetDoneTasksResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGetDoneTasksResponseBodyResult Result { get; set; }
        public class PremiumGetDoneTasksResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<PremiumGetDoneTasksResponseBodyResultList> List { get; set; }
            public class PremiumGetDoneTasksResponseBodyResultList : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

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

                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

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

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
