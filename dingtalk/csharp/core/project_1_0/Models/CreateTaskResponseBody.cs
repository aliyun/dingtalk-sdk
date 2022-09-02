// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskResponseBody : TeaModel {
        /// <summary>
        /// 返回结果对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateTaskResponseBodyResult Result { get; set; }
        public class CreateTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// 任务标题
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// 任务创建者userId
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// 自定义字段列表
            /// </summary>
            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<CreateTaskResponseBodyResultCustomfields> Customfields { get; set; }
            public class CreateTaskResponseBodyResultCustomfields : TeaModel {
                /// <summary>
                /// 自定义字段id
                /// </summary>
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                /// <summary>
                /// 自定义字段值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public List<CreateTaskResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class CreateTaskResponseBodyResultCustomfieldsValue : TeaModel {
                    /// <summary>
                    /// 自定义字段显示值
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// 任务截止时间
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// 任务执行者userId
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// 任务参与者列表
            /// </summary>
            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// 任务备注
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// 任务优先级
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// 项目id
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// 任务id
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
