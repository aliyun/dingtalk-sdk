// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class GetClosingAccountsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetClosingAccountsResponseBodyResult> Result { get; set; }
        public class GetClosingAccountsResponseBodyResult : TeaModel {
            [NameInMap("closingAccountModel")]
            [Validation(Required=false)]
            public GetClosingAccountsResponseBodyResultClosingAccountModel ClosingAccountModel { get; set; }
            public class GetClosingAccountsResponseBodyResultClosingAccountModel : TeaModel {
                [NameInMap("closingDay")]
                [Validation(Required=false)]
                public int? ClosingDay { get; set; }

                [NameInMap("closingHourMinutes")]
                [Validation(Required=false)]
                public long? ClosingHourMinutes { get; set; }

                [NameInMap("endDay")]
                [Validation(Required=false)]
                public int? EndDay { get; set; }

                [NameInMap("endMonth")]
                [Validation(Required=false)]
                public int? EndMonth { get; set; }

                [NameInMap("startDay")]
                [Validation(Required=false)]
                public int? StartDay { get; set; }

                [NameInMap("startMonth")]
                [Validation(Required=false)]
                public int? StartMonth { get; set; }

            }

            [NameInMap("switchOn")]
            [Validation(Required=false)]
            public bool? SwitchOn { get; set; }

            [NameInMap("unsealClosingAccountModel")]
            [Validation(Required=false)]
            public GetClosingAccountsResponseBodyResultUnsealClosingAccountModel UnsealClosingAccountModel { get; set; }
            public class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel : TeaModel {
                [NameInMap("invalidTimeStamp")]
                [Validation(Required=false)]
                public long? InvalidTimeStamp { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
