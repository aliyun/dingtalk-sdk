// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SubmitTaskResponseBody : TeaModel {
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<SubmitTaskResponseBodyTasks> Tasks { get; set; }
        public class SubmitTaskResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8ef16170b6e24d8fb77b832d7603b835</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
