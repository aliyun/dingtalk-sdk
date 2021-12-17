// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ProcessForecastResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ProcessForecastResponseBodyResult Result { get; set; }
        public class ProcessForecastResponseBodyResult : TeaModel {
            [NameInMap("isForecastSuccess")]
            [Validation(Required=false)]
            public bool? IsForecastSuccess { get; set; }
            [NameInMap("isStaticWorkflow")]
            [Validation(Required=false)]
            public bool? IsStaticWorkflow { get; set; }
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }
            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("workflowActors")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowActors> WorkflowActors { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowActors : TeaModel {
                public string ActivityId { get; set; }
                public string ActivityName { get; set; }
                public string ActivityType { get; set; }
                public bool? IsTargetSelect { get; set; }
                public List<ProcessForecastResponseBodyResultWorkflowActorsActivityActors> ActivityActors { get; set; }
                public class ProcessForecastResponseBodyResultWorkflowActorsActivityActors : TeaModel {
                    public string UserId { get; set; }
                    public string Name { get; set; }
                    public string Avatar { get; set; }
                }
                public bool? IsTargetFormComponent { get; set; }
                public string Node { get; set; }
            }
            [NameInMap("workflowForecastNodes")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowForecastNodes> WorkflowForecastNodes { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowForecastNodes : TeaModel {
                public string ActivityId { get; set; }
                public string OutId { get; set; }
            }
        };

    }

}
