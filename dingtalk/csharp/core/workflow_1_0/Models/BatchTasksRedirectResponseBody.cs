// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class BatchTasksRedirectResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchTasksRedirectResponseBodyResult Result { get; set; }
        public class BatchTasksRedirectResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("failCount")]
            [Validation(Required=false)]
            public long? FailCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("redirectResults")]
            [Validation(Required=false)]
            public List<BatchTasksRedirectResponseBodyResultRedirectResults> RedirectResults { get; set; }
            public class BatchTasksRedirectResponseBodyResultRedirectResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>外部流程不允许转交</para>
                /// </summary>
                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
