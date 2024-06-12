// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryMinutesAudioResponseBody : TeaModel {
        [NameInMap("audioList")]
        [Validation(Required=false)]
        public List<QueryMinutesAudioResponseBodyAudioList> AudioList { get; set; }
        public class QueryMinutesAudioResponseBodyAudioList : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("playUrl")]
            [Validation(Required=false)]
            public string PlayUrl { get; set; }

            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
