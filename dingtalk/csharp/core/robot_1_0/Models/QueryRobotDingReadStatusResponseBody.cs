// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class QueryRobotDingReadStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryRobotDingReadStatusResponseBodyResult Result { get; set; }
        public class QueryRobotDingReadStatusResponseBodyResult : TeaModel {
            [NameInMap("robotDingReadInfoList")]
            [Validation(Required=false)]
            public List<QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList> RobotDingReadInfoList { get; set; }
            public class QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList : TeaModel {
                [NameInMap("readStatus")]
                [Validation(Required=false)]
                public string ReadStatus { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
