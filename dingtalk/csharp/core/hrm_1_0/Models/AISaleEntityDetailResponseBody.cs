// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleEntityDetailResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public AISaleEntityDetailResponseBodyResult Result { get; set; }
        public class AISaleEntityDetailResponseBodyResult : TeaModel {
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("fieldInstances")]
            [Validation(Required=false)]
            public List<AISaleEntityDetailResponseBodyResultFieldInstances> FieldInstances { get; set; }
            public class AISaleEntityDetailResponseBodyResultFieldInstances : TeaModel {
                [NameInMap("fieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                [NameInMap("fieldLabel")]
                [Validation(Required=false)]
                public string FieldLabel { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("fieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

                [NameInMap("itemType")]
                [Validation(Required=false)]
                public string ItemType { get; set; }

                [NameInMap("options")]
                [Validation(Required=false)]
                public List<AISaleEntityDetailResponseBodyResultFieldInstancesOptions> Options { get; set; }
                public class AISaleEntityDetailResponseBodyResultFieldInstancesOptions : TeaModel {
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

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("subFields")]
                [Validation(Required=false)]
                public List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFields> SubFields { get; set; }
                public class AISaleEntityDetailResponseBodyResultFieldInstancesSubFields : TeaModel {
                    [NameInMap("fieldKey")]
                    [Validation(Required=false)]
                    public string FieldKey { get; set; }

                    [NameInMap("fieldLabel")]
                    [Validation(Required=false)]
                    public string FieldLabel { get; set; }

                    [NameInMap("fieldValue")]
                    [Validation(Required=false)]
                    public string FieldValue { get; set; }

                    [NameInMap("itemType")]
                    [Validation(Required=false)]
                    public string ItemType { get; set; }

                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions> Options { get; set; }
                    public class AISaleEntityDetailResponseBodyResultFieldInstancesSubFieldsOptions : TeaModel {
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

                    [NameInMap("source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
