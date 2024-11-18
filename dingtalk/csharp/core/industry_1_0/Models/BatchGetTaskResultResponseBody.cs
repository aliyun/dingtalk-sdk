// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class BatchGetTaskResultResponseBody : TeaModel {
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<BatchGetTaskResultResponseBodyTasks> Tasks { get; set; }
        public class BatchGetTaskResultResponseBodyTasks : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public BatchGetTaskResultResponseBodyTasksResult Result { get; set; }
            public class BatchGetTaskResultResponseBodyTasksResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://industry-ai-prod.oss-cn-zhangjiakou.aliyuncs.com/4beae5155406457291fcbdd76c4e8da8.txt">https://industry-ai-prod.oss-cn-zhangjiakou.aliyuncs.com/4beae5155406457291fcbdd76c4e8da8.txt</a></para>
                /// </summary>
                [NameInMap("audioText")]
                [Validation(Required=false)]
                public string AudioText { get; set; }

                [NameInMap("audioTextFormatted")]
                [Validation(Required=false)]
                public string AudioTextFormatted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-05-14</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx项目</para>
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("items")]
                [Validation(Required=false)]
                public List<BatchGetTaskResultResponseBodyTasksResultItems> Items { get; set; }
                public class BatchGetTaskResultResponseBodyTasksResultItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>主持人有问好，并得到积极回应</para>
                    /// </summary>
                    [NameInMap("info")]
                    [Validation(Required=false)]
                    public string Info { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>是否有问好</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("point")]
                    [Validation(Required=false)]
                    public long? Point { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx项目会议</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4beae5155406457291fcbdd76c4e8da8</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
