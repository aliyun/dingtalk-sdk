// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskStageResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskStageResponseBodyResult Result { get; set; }
        public class UpdateTaskStageResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("accomplishTime")]
            [Validation(Required=false)]
            public string AccomplishTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>64a5301e420637003f5dxxxx</para>
            /// </summary>
            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>63a5301e420637003f5dxxxx</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>66a5301e420637003f5dxxxx</para>
            /// </summary>
            [NameInMap("taskListId")]
            [Validation(Required=false)]
            public string TaskListId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>69a5301e420637003f5dxxxx</para>
            /// </summary>
            [NameInMap("taskStageId")]
            [Validation(Required=false)]
            public string TaskStageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T03:29:34.770Z</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
