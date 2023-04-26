// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryActiveUsersResponseBody : TeaModel {
        [NameInMap("activeUserInfos")]
        [Validation(Required=false)]
        public List<QueryActiveUsersResponseBodyActiveUserInfos> ActiveUserInfos { get; set; }
        public class QueryActiveUsersResponseBodyActiveUserInfos : TeaModel {
            [NameInMap("actionIndexL14d")]
            [Validation(Required=false)]
            public double? ActionIndexL14d { get; set; }

            [NameInMap("actionIndexL30d")]
            [Validation(Required=false)]
            public double? ActionIndexL30d { get; set; }

            [NameInMap("actionIndexL7d")]
            [Validation(Required=false)]
            public double? ActionIndexL7d { get; set; }

            [NameInMap("activeScore")]
            [Validation(Required=false)]
            public double? ActiveScore { get; set; }

            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("ranking")]
            [Validation(Required=false)]
            public long? Ranking { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
