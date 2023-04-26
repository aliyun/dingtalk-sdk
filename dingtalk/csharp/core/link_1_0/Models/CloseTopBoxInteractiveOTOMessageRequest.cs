// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class CloseTopBoxInteractiveOTOMessageRequest : TeaModel {
        [NameInMap("detail")]
        [Validation(Required=false)]
        public CloseTopBoxInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class CloseTopBoxInteractiveOTOMessageRequestDetail : TeaModel {
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
