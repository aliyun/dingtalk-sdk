// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListTodoWorkRecordsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListTodoWorkRecordsResponseBodyResult Result { get; set; }
        public class ListTodoWorkRecordsResponseBodyResult : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListTodoWorkRecordsResponseBodyResultList> List { get; set; }
            public class ListTodoWorkRecordsResponseBodyResultList : TeaModel {
                [NameInMap("forms")]
                [Validation(Required=false)]
                public List<ListTodoWorkRecordsResponseBodyResultListForms> Forms { get; set; }
                public class ListTodoWorkRecordsResponseBodyResultListForms : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>钉三多</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>入职员工姓名</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Siw2WNVZS4KiUt3tTmaNKg04*****809950</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1234567</para>
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx提交的入职审批</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

    }

}
