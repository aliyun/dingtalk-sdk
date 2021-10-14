// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class CorpInfoResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CorpInfoResponseBodyData Data { get; set; }
        public class CorpInfoResponseBodyData : TeaModel {
            [NameInMap("orgRealName")]
            [Validation(Required=false)]
            public string OrgRealName { get; set; }
            [NameInMap("realName")]
            [Validation(Required=false)]
            public bool? RealName { get; set; }
        };

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
