// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartMinutesRequest : TeaModel {
        [NameInMap("ownerUnionId")]
        [Validation(Required=false)]
        public string OwnerUnionId { get; set; }

        [NameInMap("recordAudio")]
        [Validation(Required=false)]
        public bool? RecordAudio { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
