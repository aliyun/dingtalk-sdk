// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryIntegratedTodoTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryIntegratedTodoTaskResponseBodyResult Result { get; set; }
        public class QueryIntegratedTodoTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否还有下一页
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryIntegratedTodoTaskResponseBodyResultList> List { get; set; }
            public class QueryIntegratedTodoTaskResponseBodyResultList : TeaModel {
                /// <summary>
                /// 待办组ID，需要在调用创建流程中心集成任务接口时，主动设置该值。
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// OA审批任务创建时间。
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// OA审批任务完成时间。
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// 流程实例ID
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// 任务处理结果：agree 或 refuse
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// 任务状态
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// OA审批任务ID
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// OA审批任务执行人的用户ID
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
