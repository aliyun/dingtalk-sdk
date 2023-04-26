// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EndCourseRequest : TeaModel {
        [NameInMap("courseCode")]
        [Validation(Required=false)]
        public string CourseCode { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("livePlayInfoList")]
        [Validation(Required=false)]
        public List<EndCourseRequestLivePlayInfoList> LivePlayInfoList { get; set; }
        public class EndCourseRequestLivePlayInfoList : TeaModel {
            [NameInMap("liveInputUrl")]
            [Validation(Required=false)]
            public string LiveInputUrl { get; set; }

            [NameInMap("liveOutputFlvUrl")]
            [Validation(Required=false)]
            public string LiveOutputFlvUrl { get; set; }

            [NameInMap("liveOutputHlsUrl")]
            [Validation(Required=false)]
            public string LiveOutputHlsUrl { get; set; }

            [NameInMap("liveType")]
            [Validation(Required=false)]
            public int? LiveType { get; set; }

            [NameInMap("replayUrl")]
            [Validation(Required=false)]
            public string ReplayUrl { get; set; }

        }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
