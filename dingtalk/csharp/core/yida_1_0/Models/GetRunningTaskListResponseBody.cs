// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetRunningTaskListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetRunningTaskListResponseBodyResult> Result { get; set; }
        public class GetRunningTaskListResponseBodyResult : TeaModel {
            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            [NameInMap("actualActionExecutorId")]
            [Validation(Required=false)]
            public string ActualActionExecutorId { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("originatorEmail")]
            [Validation(Required=false)]
            public string OriginatorEmail { get; set; }

            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("originatorName")]
            [Validation(Required=false)]
            public string OriginatorName { get; set; }

            [NameInMap("originatorNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNameInEnglish { get; set; }

            [NameInMap("originatorNickName")]
            [Validation(Required=false)]
            public string OriginatorNickName { get; set; }

            [NameInMap("originatorNickNameInEnglish")]
            [Validation(Required=false)]
            public string OriginatorNickNameInEnglish { get; set; }

            [NameInMap("originatorPhoto")]
            [Validation(Required=false)]
            public string OriginatorPhoto { get; set; }

            [NameInMap("outResult")]
            [Validation(Required=false)]
            public string OutResult { get; set; }

            [NameInMap("outResultName")]
            [Validation(Required=false)]
            public string OutResultName { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("titleInEnglish")]
            [Validation(Required=false)]
            public string TitleInEnglish { get; set; }

        }

    }

}
