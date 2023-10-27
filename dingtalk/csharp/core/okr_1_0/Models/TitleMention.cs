// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class TitleMention : TeaModel {
        [NameInMap("length")]
        [Validation(Required=false)]
        public long? Length { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("user")]
        [Validation(Required=false)]
        public OpenUserDTO User { get; set; }

    }

}
