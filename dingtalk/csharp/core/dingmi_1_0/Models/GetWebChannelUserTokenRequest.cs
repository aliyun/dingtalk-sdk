// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetWebChannelUserTokenRequest : TeaModel {
        [NameInMap("foreignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

    }

}
