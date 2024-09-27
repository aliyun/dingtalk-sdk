// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizFieldsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public LoadBizFieldsResponseBodyData Data { get; set; }
        public class LoadBizFieldsResponseBodyData : TeaModel {
            [NameInMap("childForms")]
            [Validation(Required=false)]
            public List<LoadBizFieldsResponseBodyDataChildForms> ChildForms { get; set; }
            public class LoadBizFieldsResponseBodyDataChildForms : TeaModel {
                [NameInMap("fields")]
                [Validation(Required=false)]
                public List<LoadBizFieldsResponseBodyDataChildFormsFields> Fields { get; set; }
                public class LoadBizFieldsResponseBodyDataChildFormsFields : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ShortString</para>
                    /// </summary>
                    [NameInMap("bizDataType")]
                    [Validation(Required=false)]
                    public string BizDataType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Phone</para>
                    /// </summary>
                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>电话</para>
                    /// </summary>
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>子表</para>
                /// </summary>
                [NameInMap("formName")]
                [Validation(Required=false)]
                public string FormName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>D000183Fcd15f3a51e624bbc9945392d190b6aa8</para>
                /// </summary>
                [NameInMap("schemaCode")]
                [Validation(Required=false)]
                public string SchemaCode { get; set; }

            }

            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<LoadBizFieldsResponseBodyDataFields> Fields { get; set; }
            public class LoadBizFieldsResponseBodyDataFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ShortString</para>
                /// </summary>
                [NameInMap("bizDataType")]
                [Validation(Required=false)]
                public string BizDataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Name</para>
                /// </summary>
                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>姓名</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>客户管理</para>
            /// </summary>
            [NameInMap("formName")]
            [Validation(Required=false)]
            public string FormName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>D0001839bbbbe346bbf496498bb76c44c7eb972</para>
            /// </summary>
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
