// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkswform_1_0.Models
{
    public class GetFormInstanceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFormInstanceResponseBodyResult Result { get; set; }
        public class GetFormInstanceResponseBodyResult : TeaModel {
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
            /// <para>manager4220</para>
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

            [NameInMap("forms")]
            [Validation(Required=false)]
            public List<GetFormInstanceResponseBodyResultForms> Forms { get; set; }
            public class GetFormInstanceResponseBodyResultForms : TeaModel {
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
            /// <para>智能填表测试</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

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
