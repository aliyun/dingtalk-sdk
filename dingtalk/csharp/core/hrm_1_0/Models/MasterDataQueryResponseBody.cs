// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataQueryResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<MasterDataQueryResponseBodyResult> Result { get; set; }
        public class MasterDataQueryResponseBodyResult : TeaModel {
            [NameInMap("outerId")]
            [Validation(Required=false)]
            public string OuterId { get; set; }

            [NameInMap("scopeCode")]
            [Validation(Required=false)]
            public string ScopeCode { get; set; }

            [NameInMap("viewEntityCode")]
            [Validation(Required=false)]
            public string ViewEntityCode { get; set; }

            [NameInMap("viewEntityFieldVOList")]
            [Validation(Required=false)]
            public List<MasterDataQueryResponseBodyResultViewEntityFieldVOList> ViewEntityFieldVOList { get; set; }
            public class MasterDataQueryResponseBodyResultViewEntityFieldVOList : TeaModel {
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("fieldDataVO")]
                [Validation(Required=false)]
                public MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO FieldDataVO { get; set; }
                public class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO : TeaModel {
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }
                };

                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("attrs")]
                [Validation(Required=false)]
                public Dictionary<string, Dictionary<string, object>> Attrs { get; set; }

            }

            [NameInMap("viewEntityMultiFieldVOList")]
            [Validation(Required=false)]
            public List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList> ViewEntityMultiFieldVOList { get; set; }
            public class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOList : TeaModel {
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                [NameInMap("rowFields")]
                [Validation(Required=false)]
                public List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields> RowFields { get; set; }
                public class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFields : TeaModel {
                    [NameInMap("fieldCode")]
                    [Validation(Required=false)]
                    public string FieldCode { get; set; }

                    [NameInMap("fieldName")]
                    [Validation(Required=false)]
                    public string FieldName { get; set; }

                    [NameInMap("viewEntityFieldList")]
                    [Validation(Required=false)]
                    public List<MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList> ViewEntityFieldList { get; set; }
                    public class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldList : TeaModel {
                        [NameInMap("fieldCode")]
                        [Validation(Required=false)]
                        public string FieldCode { get; set; }

                        [NameInMap("fieldName")]
                        [Validation(Required=false)]
                        public string FieldName { get; set; }

                        [NameInMap("fieldDataVO")]
                        [Validation(Required=false)]
                        public MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO FieldDataVO { get; set; }
                        public class MasterDataQueryResponseBodyResultViewEntityMultiFieldVOListRowFieldsViewEntityFieldListFieldDataVO : TeaModel {
                            [NameInMap("key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }
                            [NameInMap("value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }
                        };

                        [NameInMap("fieldType")]
                        [Validation(Required=false)]
                        public string FieldType { get; set; }

                        [NameInMap("attrs")]
                        [Validation(Required=false)]
                        public Dictionary<string, Dictionary<string, object>> Attrs { get; set; }

                    }

                }

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
