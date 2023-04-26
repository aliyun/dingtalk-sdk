// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenProgressDTO : TeaModel {
        [NameInMap("created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public OpenUserDTO Creator { get; set; }

        [NameInMap("htmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public OpenUserDTO Modifier { get; set; }

        [NameInMap("updated")]
        [Validation(Required=false)]
        public long? Updated { get; set; }

    }

}
