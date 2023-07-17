// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class StreamingUpdateRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("guid")]
        [Validation(Required=false)]
        public string Guid { get; set; }

        [NameInMap("isError")]
        [Validation(Required=false)]
        public bool? IsError { get; set; }

        [NameInMap("isFinalize")]
        [Validation(Required=false)]
        public bool? IsFinalize { get; set; }

        [NameInMap("isFull")]
        [Validation(Required=false)]
        public bool? IsFull { get; set; }

        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

    }

}
