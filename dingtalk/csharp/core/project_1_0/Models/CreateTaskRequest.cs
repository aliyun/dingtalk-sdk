// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// 任务标题
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 自定义字段列表
        /// </summary>
        [NameInMap("customfields")]
        [Validation(Required=false)]
        public List<CreateTaskRequestCustomfields> Customfields { get; set; }
        public class CreateTaskRequestCustomfields : TeaModel {
            /// <summary>
            /// 自定义字段id
            /// </summary>
            [NameInMap("customfieldId")]
            [Validation(Required=false)]
            public string CustomfieldId { get; set; }

            /// <summary>
            /// 自定义字段名称
            /// </summary>
            [NameInMap("customfieldName")]
            [Validation(Required=false)]
            public string CustomfieldName { get; set; }

            /// <summary>
            /// 自定义字段值
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public List<CreateTaskRequestCustomfieldsValue> Value { get; set; }
            public class CreateTaskRequestCustomfieldsValue : TeaModel {
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
        /// 执行者userId
        /// </summary>
        [NameInMap("executorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

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

    }

}
