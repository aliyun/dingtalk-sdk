// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetTaskListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("taskList")]
        [Validation(Required=false)]
        public List<GetTaskListResponseBodyTaskList> TaskList { get; set; }
        public class GetTaskListResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023希望校区初中</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4240028</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023</para>
            /// </summary>
            [NameInMap("taskYear")]
            [Validation(Required=false)]
            public long? TaskYear { get; set; }

        }

    }

}
