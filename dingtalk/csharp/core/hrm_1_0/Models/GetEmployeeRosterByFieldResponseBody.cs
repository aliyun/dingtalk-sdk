// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class GetEmployeeRosterByFieldResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetEmployeeRosterByFieldResponseBodyResult> Result { get; set; }
        public class GetEmployeeRosterByFieldResponseBodyResult : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("fieldDataList")]
            [Validation(Required=false)]
            public List<GetEmployeeRosterByFieldResponseBodyResultFieldDataList> FieldDataList { get; set; }
            public class GetEmployeeRosterByFieldResponseBodyResultFieldDataList : TeaModel {
                [NameInMap("fieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("fieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("fieldValueList")]
                [Validation(Required=false)]
                public List<GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList> FieldValueList { get; set; }
                public class GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList : TeaModel {
                    [NameInMap("itemIndex")]
                    [Validation(Required=false)]
                    public int? ItemIndex { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("groupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

            }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
