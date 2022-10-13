// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListTodoWorkRecordsResponseBody : TeaModel {
        /// <summary>
        /// 查询结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListTodoWorkRecordsResponseBodyResult Result { get; set; }
        public class ListTodoWorkRecordsResponseBodyResult : TeaModel {
            /// <summary>
            /// 待办事项列表。
            /// </summary>
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListTodoWorkRecordsResponseBodyResultList> List { get; set; }
            public class ListTodoWorkRecordsResponseBodyResultList : TeaModel {
                /// <summary>
                /// 表单列表。
                /// </summary>
                [NameInMap("forms")]
                [Validation(Required=false)]
                public List<ListTodoWorkRecordsResponseBodyResultListForms> Forms { get; set; }
                public class ListTodoWorkRecordsResponseBodyResultListForms : TeaModel {
                    /// <summary>
                    /// 表单内容。
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// 表单标题。
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// 实例ID。
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// 待办任务ID。
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// 待办标题。
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// 待办跳转链接。
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 分页游标。不为空表示有数据。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

    }

}
