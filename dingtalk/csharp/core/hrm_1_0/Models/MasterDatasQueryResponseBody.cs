// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDatasQueryResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<MasterDatasQueryResponseBodyResult> Result { get; set; }
        public class MasterDatasQueryResponseBodyResult : TeaModel {
            [NameInMap("objId")]
            [Validation(Required=false)]
            public string ObjId { get; set; }

            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            [NameInMap("scopeCode")]
            [Validation(Required=false)]
            public string ScopeCode { get; set; }

            [NameInMap("viewEntityCode")]
            [Validation(Required=false)]
            public string ViewEntityCode { get; set; }

            [NameInMap("viewEntityFieldVOList")]
            [Validation(Required=false)]
            public List<MasterDatasQueryResponseBodyResultViewEntityFieldVOList> ViewEntityFieldVOList { get; set; }
            public class MasterDatasQueryResponseBodyResultViewEntityFieldVOList : TeaModel {
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("fieldDataVO")]
                [Validation(Required=false)]
                public MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO FieldDataVO { get; set; }
                public class MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO : TeaModel {
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
