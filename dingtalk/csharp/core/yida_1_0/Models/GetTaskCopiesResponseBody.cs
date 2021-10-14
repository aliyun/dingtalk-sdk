// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetTaskCopiesResponseBody : TeaModel {
        /// <summary>
        /// 数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetTaskCopiesResponseBodyData> Data { get; set; }
        public class GetTaskCopiesResponseBodyData : TeaModel {
            /// <summary>
            /// actionerId
            /// </summary>
            [NameInMap("actionExecutorId")]
            [Validation(Required=false)]
            public List<string> ActionExecutorId { get; set; }

            /// <summary>
            /// processInstanceId
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// formUuid
            /// </summary>
            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            /// <summary>
            /// 序列号
            /// </summary>
            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// processInstanceStatus
            /// </summary>
            [NameInMap("processInstanceStatus")]
            [Validation(Required=false)]
            public string ProcessInstanceStatus { get; set; }

            /// <summary>
            /// originatorDisplayName
            /// </summary>
            [NameInMap("originatorDisplayName")]
            [Validation(Required=false)]
            public string OriginatorDisplayName { get; set; }

            /// <summary>
            /// modifiedTime
            /// </summary>
            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            /// <summary>
            /// carbonActivityId
            /// </summary>
            [NameInMap("carbonActivityId")]
            [Validation(Required=false)]
            public string CarbonActivityId { get; set; }

            /// <summary>
            /// dataType
            /// </summary>
            [NameInMap("dataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// actionerName
            /// </summary>
            [NameInMap("actionExecutorName")]
            [Validation(Required=false)]
            public List<string> ActionExecutorName { get; set; }

            /// <summary>
            /// originatorAvatar
            /// </summary>
            [NameInMap("originatorAvatar")]
            [Validation(Required=false)]
            public string OriginatorAvatar { get; set; }

            /// <summary>
            /// processInstanceStatusText
            /// </summary>
            [NameInMap("processInstanceStatusText")]
            [Validation(Required=false)]
            public string ProcessInstanceStatusText { get; set; }

            /// <summary>
            /// processApprovedResultText
            /// </summary>
            [NameInMap("processApprovedResultText")]
            [Validation(Required=false)]
            public string ProcessApprovedResultText { get; set; }

            /// <summary>
            /// formInstanceId
            /// </summary>
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            /// <summary>
            /// 标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 版本
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

            /// <summary>
            /// 实例数据
            /// </summary>
            [NameInMap("instanceValue")]
            [Validation(Required=false)]
            public string InstanceValue { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            /// <summary>
            /// processApprovedResult
            /// </summary>
            [NameInMap("processApprovedResult")]
            [Validation(Required=false)]
            public string ProcessApprovedResult { get; set; }

            /// <summary>
            /// 流程id
            /// </summary>
            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// processName
            /// </summary>
            [NameInMap("processName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// processCode
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// appType
            /// </summary>
            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// dataMap
            /// </summary>
            [NameInMap("dataMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> DataMap { get; set; }

            /// <summary>
            /// currentActivityInstances
            /// </summary>
            [NameInMap("currentActivityInstances")]
            [Validation(Required=false)]
            public List<GetTaskCopiesResponseBodyDataCurrentActivityInstances> CurrentActivityInstances { get; set; }
            public class GetTaskCopiesResponseBodyDataCurrentActivityInstances : TeaModel {
                /// <summary>
                /// 节点名称
                /// </summary>
                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// 节点英文名称
                /// </summary>
                [NameInMap("activityNameInEnglish")]
                [Validation(Required=false)]
                public string ActivityNameInEnglish { get; set; }

                /// <summary>
                /// 节点id
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// 数据id
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// 节点实例状态
                /// </summary>
                [NameInMap("activityInstanceStatus")]
                [Validation(Required=false)]
                public string ActivityInstanceStatus { get; set; }

            }

            /// <summary>
            /// 结束时间
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

        }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
