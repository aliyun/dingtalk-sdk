// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchOrgCreateHWResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchOrgCreateHWResponseBodyResult Result { get; set; }
        public class BatchOrgCreateHWResponseBodyResult : TeaModel {
            [NameInMap("publishList")]
            [Validation(Required=false)]
            public List<BatchOrgCreateHWResponseBodyResultPublishList> PublishList { get; set; }
            public class BatchOrgCreateHWResponseBodyResultPublishList : TeaModel {
                public string Corpid { get; set; }
                public long? Hwid { get; set; }
            }
        };

    }

}
