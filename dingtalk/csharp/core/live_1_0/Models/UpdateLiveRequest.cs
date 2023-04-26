// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class UpdateLiveRequest : TeaModel {
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("liveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        [NameInMap("preEndTime")]
        [Validation(Required=false)]
        public long? PreEndTime { get; set; }

        [NameInMap("preStartTime")]
        [Validation(Required=false)]
        public long? PreStartTime { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
