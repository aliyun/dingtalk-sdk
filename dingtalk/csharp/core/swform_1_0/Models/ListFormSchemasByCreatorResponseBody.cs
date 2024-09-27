// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class ListFormSchemasByCreatorResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFormSchemasByCreatorResponseBodyResult Result { get; set; }
        public class ListFormSchemasByCreatorResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<ListFormSchemasByCreatorResponseBodyResultList> List { get; set; }
            public class ListFormSchemasByCreatorResponseBodyResultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>user123</para>
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PROC-E5BD2166-B6F4-xxxx</para>
                /// </summary>
                [NameInMap("formCode")]
                [Validation(Required=false)]
                public string FormCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>请大家仔细填写，谢谢合作</para>
                /// </summary>
                [NameInMap("memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>智能填表测试</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("setting")]
                [Validation(Required=false)]
                public ListFormSchemasByCreatorResponseBodyResultListSetting Setting { get; set; }
                public class ListFormSchemasByCreatorResponseBodyResultListSetting : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("bizType")]
                    [Validation(Required=false)]
                    public int? BizType { get; set; }

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
                    /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-27T18:53Z</para>
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("formType")]
                    [Validation(Required=false)]
                    public int? FormType { get; set; }

                    [NameInMap("loopDays")]
                    [Validation(Required=false)]
                    public List<int?> LoopDays { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>18:00</para>
                    /// </summary>
                    [NameInMap("loopTime")]
                    [Validation(Required=false)]
                    public string LoopTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("stop")]
                    [Validation(Required=false)]
                    public bool? Stop { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
