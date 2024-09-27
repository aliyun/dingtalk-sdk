// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumQueryTodoTasksByManagerResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumQueryTodoTasksByManagerResponseBodyResult Result { get; set; }
        public class PremiumQueryTodoTasksByManagerResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<PremiumQueryTodoTasksByManagerResponseBodyResultList> List { get; set; }
            public class PremiumQueryTodoTasksByManagerResponseBodyResultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("businessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                [NameInMap("canRedirect")]
                [Validation(Required=false)]
                public bool? CanRedirect { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>act_0001</para>
                /// </summary>
                [NameInMap("processCode")]
                [Validation(Required=false)]
                public string ProcessCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Siw2WNVZS4KiUt3tTmaNKg04*****809950</para>
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

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
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-10-17T15:12Z</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
