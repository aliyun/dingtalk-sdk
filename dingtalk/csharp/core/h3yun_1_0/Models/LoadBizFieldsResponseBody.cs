// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizFieldsResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public LoadBizFieldsResponseBodyData Data { get; set; }
        public class LoadBizFieldsResponseBodyData : TeaModel {
            [NameInMap("childForms")]
            [Validation(Required=false)]
            public List<LoadBizFieldsResponseBodyDataChildForms> ChildForms { get; set; }
            public class LoadBizFieldsResponseBodyDataChildForms : TeaModel {
                public List<LoadBizFieldsResponseBodyDataChildFormsFields> Fields { get; set; }
                public class LoadBizFieldsResponseBodyDataChildFormsFields : TeaModel {
                    public string BizDataType { get; set; }
                    public string FieldName { get; set; }
                    public string Label { get; set; }
                }
                public string FormName { get; set; }
                public string SchemaCode { get; set; }
            }
            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<LoadBizFieldsResponseBodyDataFields> Fields { get; set; }
            public class LoadBizFieldsResponseBodyDataFields : TeaModel {
                public string BizDataType { get; set; }
                public string FieldName { get; set; }
                public string Label { get; set; }
            }
            [NameInMap("formName")]
            [Validation(Required=false)]
            public string FormName { get; set; }
            [NameInMap("schemaCode")]
            [Validation(Required=false)]
            public string SchemaCode { get; set; }
        };

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
