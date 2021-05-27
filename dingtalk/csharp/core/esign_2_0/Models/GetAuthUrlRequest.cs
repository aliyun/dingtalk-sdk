// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetAuthUrlRequest : TeaModel {
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("redirectUrl")]
        [Validation(Required=false)]
        public string RedirectUrl { get; set; }

    }

}
