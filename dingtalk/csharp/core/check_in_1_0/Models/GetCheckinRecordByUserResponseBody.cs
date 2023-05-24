// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcheck_in_1_0.Models
{
    public class GetCheckinRecordByUserResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCheckinRecordByUserResponseBodyResult Result { get; set; }
        public class GetCheckinRecordByUserResponseBodyResult : TeaModel {
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public long? NextToken { get; set; }

            [NameInMap("pageList")]
            [Validation(Required=false)]
            public List<GetCheckinRecordByUserResponseBodyResultPageList> PageList { get; set; }
            public class GetCheckinRecordByUserResponseBodyResultPageList : TeaModel {
                [NameInMap("checkinTime")]
                [Validation(Required=false)]
                public long? CheckinTime { get; set; }

                [NameInMap("customDataList")]
                [Validation(Required=false)]
                public List<GetCheckinRecordByUserResponseBodyResultPageListCustomDataList> CustomDataList { get; set; }
                public class GetCheckinRecordByUserResponseBodyResultPageListCustomDataList : TeaModel {
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("detailPlace")]
                [Validation(Required=false)]
                public string DetailPlace { get; set; }

                [NameInMap("imageList")]
                [Validation(Required=false)]
                public List<string> ImageList { get; set; }

                [NameInMap("place")]
                [Validation(Required=false)]
                public string Place { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("visitUser")]
                [Validation(Required=false)]
                public string VisitUser { get; set; }

            }

        }

    }

}
