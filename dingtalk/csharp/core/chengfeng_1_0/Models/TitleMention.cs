// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class TitleMention : TeaModel {
        [NameInMap("length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("user")]
        [Validation(Required=false)]
        public OpenUserDTO User { get; set; }

    }

}
