// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ChatAITextSentimentAnalysisResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ChatAITextSentimentAnalysisResponseBodyResult Result { get; set; }
        public class ChatAITextSentimentAnalysisResponseBodyResult : TeaModel {
            [NameInMap("sentiment")]
            [Validation(Required=false)]
            public string Sentiment { get; set; }

        }

    }

}
