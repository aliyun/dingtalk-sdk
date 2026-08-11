// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleEntityUpdateResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public AISaleEntityUpdateResponseBodyResult Result { get; set; }
        public class AISaleEntityUpdateResponseBodyResult : TeaModel {
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("entityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("fieldInstances")]
            [Validation(Required=false)]
            public List<AISaleEntityUpdateResponseBodyResultFieldInstances> FieldInstances { get; set; }
            public class AISaleEntityUpdateResponseBodyResultFieldInstances : TeaModel {
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
                public List<AISaleEntityUpdateResponseBodyResultFieldInstancesOptions> Options { get; set; }
                public class AISaleEntityUpdateResponseBodyResultFieldInstancesOptions : TeaModel {
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

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
