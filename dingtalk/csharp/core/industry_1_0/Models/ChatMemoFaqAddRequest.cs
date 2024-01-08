// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatMemoFaqAddRequest : TeaModel {
        [NameInMap("answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("datasetId")]
        [Validation(Required=false)]
        public long? DatasetId { get; set; }

        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        [NameInMap("redirection")]
        [Validation(Required=false)]
        public string Redirection { get; set; }

    }

}
