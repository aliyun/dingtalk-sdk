// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class PreviewPublishedProcessResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<PreviewPublishedProcessResponseBodyResult> Result { get; set; }
        public class PreviewPublishedProcessResponseBodyResult : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("actionExit")]
            [Validation(Required=false)]
            public string ActionExit { get; set; }

            [NameInMap("activeTimeGMT")]
            [Validation(Required=false)]
            public string ActiveTimeGMT { get; set; }

            [NameInMap("activityId")]
            [Validation(Required=false)]
            public string ActivityId { get; set; }

            [NameInMap("dataId")]
            [Validation(Required=false)]
            public long? DataId { get; set; }

            [NameInMap("digitalSign")]
            [Validation(Required=false)]
            public string DigitalSign { get; set; }

            [NameInMap("domains")]
            [Validation(Required=false)]
            public List<object> Domains { get; set; }

            [NameInMap("files")]
            [Validation(Required=false)]
            public string Files { get; set; }

            [NameInMap("operateTimeGMT")]
            [Validation(Required=false)]
            public string OperateTimeGMT { get; set; }

            [NameInMap("operateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            [NameInMap("operatorDisplayName")]
            [Validation(Required=false)]
            public string OperatorDisplayName { get; set; }

            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            [NameInMap("operatorNickName")]
            [Validation(Required=false)]
            public string OperatorNickName { get; set; }

            [NameInMap("operatorPhotoUrl")]
            [Validation(Required=false)]
            public string OperatorPhotoUrl { get; set; }

            [NameInMap("operatorStatus")]
            [Validation(Required=false)]
            public string OperatorStatus { get; set; }

            [NameInMap("operatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("showName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

            [NameInMap("size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            [NameInMap("taskExecuteType")]
            [Validation(Required=false)]
            public string TaskExecuteType { get; set; }

            [NameInMap("taskHoldTimeGMT")]
            [Validation(Required=false)]
            public long? TaskHoldTimeGMT { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
