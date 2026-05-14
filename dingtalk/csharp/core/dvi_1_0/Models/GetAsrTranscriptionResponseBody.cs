// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetAsrTranscriptionResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAsrTranscriptionResponseBodyResult Result { get; set; }
        public class GetAsrTranscriptionResponseBodyResult : TeaModel {
            [NameInMap("bizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("resultInfo")]
            [Validation(Required=false)]
            public GetAsrTranscriptionResponseBodyResultResultInfo ResultInfo { get; set; }
            public class GetAsrTranscriptionResponseBodyResultResultInfo : TeaModel {
                [NameInMap("paragraphList")]
                [Validation(Required=false)]
                public List<GetAsrTranscriptionResponseBodyResultResultInfoParagraphList> ParagraphList { get; set; }
                public class GetAsrTranscriptionResponseBodyResultResultInfoParagraphList : TeaModel {
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("paragraph")]
                    [Validation(Required=false)]
                    public string Paragraph { get; set; }

                    [NameInMap("speakerId")]
                    [Validation(Required=false)]
                    public string SpeakerId { get; set; }

                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

            }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

    }

}
