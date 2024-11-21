// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class CreateTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateTaskResponseBodyResult Result { get; set; }
        public class CreateTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>任务标题</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173xxxxx</para>
            /// </summary>
            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customfields")]
            [Validation(Required=false)]
            public List<CreateTaskResponseBodyResultCustomfields> Customfields { get; set; }
            public class CreateTaskResponseBodyResultCustomfields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>625bcxdxxxxxx</para>
                /// </summary>
                [NameInMap("customfieldId")]
                [Validation(Required=false)]
                public string CustomfieldId { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<CreateTaskResponseBodyResultCustomfieldsValue> Value { get; set; }
                public class CreateTaskResponseBodyResultCustomfieldsValue : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("thumbUrl")]
                    [Validation(Required=false)]
                    public string ThumbUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>我是自定义字段显示值</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>173xxxx</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            [NameInMap("involveMembers")]
            [Validation(Required=false)]
            public List<string> InvolveMembers { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>我是一条备注</para>
            /// </summary>
            [NameInMap("note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-10</para>
            /// </summary>
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62c25e3b376ecxxxxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>62a697c053c2ef5xxxxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-08-13T07:36:50.318Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
