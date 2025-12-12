// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetServiceRecordTranscriptResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetServiceRecordTranscriptResponseBodyResult Result { get; set; }
        public class GetServiceRecordTranscriptResponseBodyResult : TeaModel {
            [NameInMap("audionText")]
            [Validation(Required=false)]
            public GetServiceRecordTranscriptResponseBodyResultAudionText AudionText { get; set; }
            public class GetServiceRecordTranscriptResponseBodyResultAudionText : TeaModel {
                [NameInMap("dataList")]
                [Validation(Required=false)]
                public List<GetServiceRecordTranscriptResponseBodyResultAudionTextDataList> DataList { get; set; }
                public class GetServiceRecordTranscriptResponseBodyResultAudionTextDataList : TeaModel {
                    [NameInMap("channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("speaker")]
            [Validation(Required=false)]
            public GetServiceRecordTranscriptResponseBodyResultSpeaker Speaker { get; set; }
            public class GetServiceRecordTranscriptResponseBodyResultSpeaker : TeaModel {
                [NameInMap("dataList")]
                [Validation(Required=false)]
                public List<GetServiceRecordTranscriptResponseBodyResultSpeakerDataList> DataList { get; set; }
                public class GetServiceRecordTranscriptResponseBodyResultSpeakerDataList : TeaModel {
                    [NameInMap("channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    [NameInMap("role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

    }

}
