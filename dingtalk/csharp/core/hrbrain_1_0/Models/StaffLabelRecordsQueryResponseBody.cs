// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class StaffLabelRecordsQueryResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public StaffLabelRecordsQueryResponseBodyContent Content { get; set; }
        public class StaffLabelRecordsQueryResponseBodyContent : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<StaffLabelRecordsQueryResponseBodyContentData> Data { get; set; }
            public class StaffLabelRecordsQueryResponseBodyContentData : TeaModel {
                [NameInMap("labels")]
                [Validation(Required=false)]
                public List<StaffLabelRecordsQueryResponseBodyContentDataLabels> Labels { get; set; }
                public class StaffLabelRecordsQueryResponseBodyContentDataLabels : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("options")]
                    [Validation(Required=false)]
                    public List<StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions> Options { get; set; }
                    public class StaffLabelRecordsQueryResponseBodyContentDataLabelsOptions : TeaModel {
                        [NameInMap("label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("tip")]
                        [Validation(Required=false)]
                        public string Tip { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("typeCode")]
                    [Validation(Required=false)]
                    public string TypeCode { get; set; }

                    [NameInMap("typeName")]
                    [Validation(Required=false)]
                    public string TypeName { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("totalCountt")]
            [Validation(Required=false)]
            public long? TotalCountt { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
