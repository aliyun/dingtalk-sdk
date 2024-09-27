// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormInstancesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFormInstancesResponseBodyResult Result { get; set; }
        public class ListFormInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListFormInstancesResponseBodyResultList> List { get; set; }
            public class ListFormInstancesResponseBodyResultList : TeaModel {
                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-27T18:53Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PROC-E5BD2166-B6F4-xxxx</para>
                /// </summary>
                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11125769-fxxxx</para>
                /// </summary>
                [NameInMap("formInstanceId")]
                [Validation(Required=false)]
                public string FormInstanceId { get; set; }

                [NameInMap("forms")]
                [Validation(Required=false)]
                public List<ListFormInstancesResponseBodyResultListForms> Forms { get; set; }
                public class ListFormInstancesResponseBodyResultListForms : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TextareaField_KGAW58AQ</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>你希望的主题</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>操作演示</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-27T18:53Z</para>
                /// </summary>
                [NameInMap("modifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("studentClassId")]
                [Validation(Required=false)]
                public string StudentClassId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>三年二班</para>
                /// </summary>
                [NameInMap("studentClassName")]
                [Validation(Required=false)]
                public string StudentClassName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>钉三多</para>
                /// </summary>
                [NameInMap("studentName")]
                [Validation(Required=false)]
                public string StudentName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("studentUserId")]
                [Validation(Required=false)]
                public string StudentUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user123</para>
                /// </summary>
                [NameInMap("submitterUserId")]
                [Validation(Required=false)]
                public string SubmitterUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>钉三多</para>
                /// </summary>
                [NameInMap("submitterUserName")]
                [Validation(Required=false)]
                public string SubmitterUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>智能填表测试</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
