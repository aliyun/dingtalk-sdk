// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PollingConfirmStatusResponseBody : TeaModel {
        [NameInMap("universityPollingCourseStatusResponse")]
        [Validation(Required=false)]
        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse UniversityPollingCourseStatusResponse { get; set; }
        public class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse : TeaModel {
            [NameInMap("confirmStatus")]
            [Validation(Required=false)]
            public bool? ConfirmStatus { get; set; }
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }
            [NameInMap("livePlayInfoList")]
            [Validation(Required=false)]
            public List<PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList> LivePlayInfoList { get; set; }
            public class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList : TeaModel {
                public string LiveInputUrl { get; set; }
                public string LiveOutputUrl { get; set; }
                public long? LiveType { get; set; }
                public string ReplayUrl { get; set; }
            }
        };

    }

}
