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
            /// <summary>
            /// 确认状态
            /// </summary>
            [NameInMap("confirmStatus")]
            [Validation(Required=false)]
            public bool? ConfirmStatus { get; set; }

            /// <summary>
            /// 课程编码
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            [NameInMap("livePlayInfoList")]
            [Validation(Required=false)]
            public List<PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList> LivePlayInfoList { get; set; }
            public class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList : TeaModel {
                /// <summary>
                /// 推流地址
                /// </summary>
                [NameInMap("liveInputUrl")]
                [Validation(Required=false)]
                public string LiveInputUrl { get; set; }

                /// <summary>
                /// 直播拉流地址
                /// </summary>
                [NameInMap("liveOutputUrl")]
                [Validation(Required=false)]
                public string LiveOutputUrl { get; set; }

                /// <summary>
                /// 视频流类型
                /// </summary>
                [NameInMap("liveType")]
                [Validation(Required=false)]
                public long? LiveType { get; set; }

                /// <summary>
                /// 视频回放地址
                /// </summary>
                [NameInMap("replayUrl")]
                [Validation(Required=false)]
                public string ReplayUrl { get; set; }

            }

        }

    }

}
