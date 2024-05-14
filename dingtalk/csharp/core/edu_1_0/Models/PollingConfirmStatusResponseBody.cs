// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PollingConfirmStatusResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("universityPollingCourseStatusResponse")]
        [Validation(Required=false)]
        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse UniversityPollingCourseStatusResponse { get; set; }
        public class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("confirmStatus")]
            [Validation(Required=false)]
            public bool? ConfirmStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("livePlayInfoList")]
            [Validation(Required=false)]
            public List<PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList> LivePlayInfoList { get; set; }
            public class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("liveInputUrl")]
                [Validation(Required=false)]
                public string LiveInputUrl { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("liveOutputUrl")]
                [Validation(Required=false)]
                public string LiveOutputUrl { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("liveType")]
                [Validation(Required=false)]
                public long? LiveType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("replayUrl")]
                [Validation(Required=false)]
                public string ReplayUrl { get; set; }

            }

        }

    }

}
