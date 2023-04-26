// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetTaskCopiesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetTaskCopiesResponseBodyData> Data { get; set; }
        public class GetTaskCopiesResponseBodyData : TeaModel {
            [NameInMap("actionExecutorId")]
            [Validation(Required=false)]
            public List<string> ActionExecutorId { get; set; }

            [NameInMap("actionExecutorName")]
            [Validation(Required=false)]
            public List<string> ActionExecutorName { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("carbonActivityId")]
            [Validation(Required=false)]
            public string CarbonActivityId { get; set; }

            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("currentActivityInstances")]
            [Validation(Required=false)]
            public List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetTaskCopiesResponseBodyDataCurrentActivityInstances : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("activityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("activityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("dataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DataMap { get; set; }

            [NameInMap("dataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("finishTimeGMT")]
            [Validation(Required=false)]
            public string FinishTimeGMT { get; set; }

            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("originatorAvatar")]
            [Validation(Required=false)]
            public string OriginatorAvatar { get; set; }

            [NameInMap("originatorDisplayName")]
            [Validation(Required=false)]
            public string OriginatorDisplayName { get; set; }

            [NameInMap("originatorId")]
            [Validation(Required=false)]
            public string OriginatorId { get; set; }

            [NameInMap("processApprovedResult")]
            [Validation(Required=false)]
            public string ProcessApprovedResult { get; set; }

            [NameInMap("processApprovedResultText")]
            [Validation(Required=false)]
            public string ProcessApprovedResultText { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("processInstanceStatus")]
            [Validation(Required=false)]
            public string ProcessInstanceStatus { get; set; }

            [NameInMap("processInstanceStatusText")]
            [Validation(Required=false)]
            public string ProcessInstanceStatusText { get; set; }

            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
