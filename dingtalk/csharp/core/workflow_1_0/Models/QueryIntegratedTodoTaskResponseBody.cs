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
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryIntegratedTodoTaskResponseBodyResultList> List { get; set; }
            public class QueryIntegratedTodoTaskResponseBodyResultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>act_0001</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-17T15:12Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-17T15:12Z</para>
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Siw2WNVZS4KiUt3tTmaNKg04*****809950</para>
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agree</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>manager001</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
