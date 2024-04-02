// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetColumnvalsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetColumnvalsResponseBodyResult> Result { get; set; }
        public class GetColumnvalsResponseBodyResult : TeaModel {
            [NameInMap("columnData")]
            [Validation(Required=false)]
            public List<GetColumnvalsResponseBodyResultColumnData> ColumnData { get; set; }
            public class GetColumnvalsResponseBodyResultColumnData : TeaModel {
                [NameInMap("columnValues")]
                [Validation(Required=false)]
                public List<GetColumnvalsResponseBodyResultColumnDataColumnValues> ColumnValues { get; set; }
                public class GetColumnvalsResponseBodyResultColumnDataColumnValues : TeaModel {
                    [NameInMap("date")]
                    [Validation(Required=false)]
                    public long? Date { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("fixedValue")]
                [Validation(Required=false)]
                public string FixedValue { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
