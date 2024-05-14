// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizFieldsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
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
                    [NameInMap("bizDataType")]
                    [Validation(Required=false)]
                    public string BizDataType { get; set; }

                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                }

                [NameInMap("formName")]
                [Validation(Required=false)]
                public string FormName { get; set; }

                [NameInMap("schemaCode")]
                [Validation(Required=false)]
                public string SchemaCode { get; set; }

            }

            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<LoadBizFieldsResponseBodyDataFields> Fields { get; set; }
            public class LoadBizFieldsResponseBodyDataFields : TeaModel {
                [NameInMap("bizDataType")]
                [Validation(Required=false)]
                public string BizDataType { get; set; }

                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

            }

            [NameInMap("formName")]
            [Validation(Required=false)]
            public string FormName { get; set; }

            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
