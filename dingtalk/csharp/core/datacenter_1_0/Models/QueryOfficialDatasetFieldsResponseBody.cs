// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryOfficialDatasetFieldsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryOfficialDatasetFieldsResponseBodyResult Result { get; set; }
        public class QueryOfficialDatasetFieldsResponseBodyResult : TeaModel {
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("dsId")]
            [Validation(Required=false)]
            public string DsId { get; set; }

            [NameInMap("fields")]
            [Validation(Required=false)]
            public List<QueryOfficialDatasetFieldsResponseBodyResultFields> Fields { get; set; }
            public class QueryOfficialDatasetFieldsResponseBodyResultFields : TeaModel {
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("fieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

                [NameInMap("fieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
