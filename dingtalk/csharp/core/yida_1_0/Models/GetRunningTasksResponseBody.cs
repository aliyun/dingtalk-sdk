// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetRunningTasksResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetRunningTasksResponseBodyResult> Result { get; set; }
        public class GetRunningTasksResponseBodyResult : TeaModel {
            /// <summary>
            /// activeTime
            /// </summary>
            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            /// <summary>
            /// activityId
            /// </summary>
            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            /// <summary>
            /// actualActionerId
            /// </summary>
            [NameInMap("actualActionerId")]
            [Validation(Required=false)]
            public string ActualActionerId { get; set; }

            /// <summary>
            /// createTime
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// finishTime
            /// </summary>
            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            /// <summary>
            /// originatorId
            /// </summary>
            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            /// <summary>
            /// processInstanceId
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// status
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// taskId
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// taskType
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// title
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// titleEn
            /// </summary>
            [NameInMap("titleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

        }

    }

}
