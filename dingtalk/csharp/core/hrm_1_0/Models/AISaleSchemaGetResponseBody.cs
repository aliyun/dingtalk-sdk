// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleSchemaGetResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public AISaleSchemaGetResponseBodyResult Result { get; set; }
        public class AISaleSchemaGetResponseBodyResult : TeaModel {
            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<AISaleSchemaGetResponseBodyResultFields> Fields { get; set; }
            public class AISaleSchemaGetResponseBodyResultFields : TeaModel {
                [NameInMap("defaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("entityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("fieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                [NameInMap("fieldLabel")]
                [Validation(Required=false)]
                public string FieldLabel { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                [NameInMap("options")]
                [Validation(Required=false)]
                public List<AISaleSchemaGetResponseBodyResultFieldsOptions> Options { get; set; }
                public class AISaleSchemaGetResponseBodyResultFieldsOptions : TeaModel {
                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("placeholder")]
                [Validation(Required=false)]
                public string Placeholder { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("sortOrder")]
                [Validation(Required=false)]
                public int? SortOrder { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("subFields")]
                [Validation(Required=false)]
                public List<AISaleSchemaGetResponseBodyResultFieldsSubFields> SubFields { get; set; }
                public class AISaleSchemaGetResponseBodyResultFieldsSubFields : TeaModel {
                    [NameInMap("fieldKey")]
                    [Validation(Required=false)]
                    public string FieldKey { get; set; }

                    [NameInMap("fieldLabel")]
                    [Validation(Required=false)]
                    public string FieldLabel { get; set; }

                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions> Options { get; set; }
                    public class AISaleSchemaGetResponseBodyResultFieldsSubFieldsOptions : TeaModel {
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("placeholder")]
                    [Validation(Required=false)]
                    public string Placeholder { get; set; }

                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
