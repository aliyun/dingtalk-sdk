// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatAIListDatasetResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ChatAIListDatasetResponseBodyResult> Result { get; set; }
        public class ChatAIListDatasetResponseBodyResult : TeaModel {
            [NameInMap("datasetDesc")]
            [Validation(Required=false)]
            public string DatasetDesc { get; set; }

            [NameInMap("datasetId")]
            [Validation(Required=false)]
            public long? DatasetId { get; set; }

            [NameInMap("datasetName")]
            [Validation(Required=false)]
            public string DatasetName { get; set; }

            [NameInMap("memoType")]
            [Validation(Required=false)]
            public string MemoType { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
