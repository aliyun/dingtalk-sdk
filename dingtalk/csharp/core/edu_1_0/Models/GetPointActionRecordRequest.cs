// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetPointActionRecordRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public GetPointActionRecordRequestBody Body { get; set; }
        public class GetPointActionRecordRequestBody : TeaModel {
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("ownerId")]
            [Validation(Required=false)]
            public string OwnerId { get; set; }

            [NameInMap("pointType")]
            [Validation(Required=false)]
            public string PointType { get; set; }

        }

    }

}
