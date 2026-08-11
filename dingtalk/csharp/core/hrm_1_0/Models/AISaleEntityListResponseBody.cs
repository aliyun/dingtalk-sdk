// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleEntityListResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public AISaleEntityListResponseBodyResult Result { get; set; }
        public class AISaleEntityListResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<AISaleEntityListResponseBodyResultData> Data { get; set; }
            public class AISaleEntityListResponseBodyResultData : TeaModel {
                [NameInMap("entityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("entityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("fieldInstances")]
                [Validation(Required=false)]
                public List<AISaleEntityListResponseBodyResultDataFieldInstances> FieldInstances { get; set; }
                public class AISaleEntityListResponseBodyResultDataFieldInstances : TeaModel {
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
                    public List<AISaleEntityListResponseBodyResultDataFieldInstancesOptions> Options { get; set; }
                    public class AISaleEntityListResponseBodyResultDataFieldInstancesOptions : TeaModel {
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
                    public List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFields> SubFields { get; set; }
                    public class AISaleEntityListResponseBodyResultDataFieldInstancesSubFields : TeaModel {
                        [NameInMap("fieldKey")]
                        [Validation(Required=false)]
                        public string FieldKey { get; set; }

                        [NameInMap("fieldLabel")]
                        [Validation(Required=false)]
                        public string FieldLabel { get; set; }

                        [NameInMap("fieldValue")]
                        [Validation(Required=false)]
                        public string FieldValue { get; set; }

                        [NameInMap("options")]
                        [Validation(Required=false)]
                        public List<AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions> Options { get; set; }
                        public class AISaleEntityListResponseBodyResultDataFieldInstancesSubFieldsOptions : TeaModel {
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

            }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public string NextCursor { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
