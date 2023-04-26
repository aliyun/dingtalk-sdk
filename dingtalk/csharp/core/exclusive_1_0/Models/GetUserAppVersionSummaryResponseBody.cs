// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserAppVersionSummaryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUserAppVersionSummaryResponseBodyData> Data { get; set; }
        public class GetUserAppVersionSummaryResponseBodyData : TeaModel {
            [NameInMap("appVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("client")]
            [Validation(Required=false)]
            public string Client { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("statDate")]
            [Validation(Required=false)]
            public string StatDate { get; set; }

            [NameInMap("userCnt")]
            [Validation(Required=false)]
            public float? UserCnt { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
