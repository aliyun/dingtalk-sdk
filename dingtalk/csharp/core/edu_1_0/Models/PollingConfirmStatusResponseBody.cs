// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PollingConfirmStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("universityPollingCourseStatusResponse")]
        [Validation(Required=false)]
        public PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse UniversityPollingCourseStatusResponse { get; set; }
        public class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponse : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("confirmStatus")]
            [Validation(Required=false)]
            public bool? ConfirmStatus { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCourseCode</para>
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("livePlayInfoList")]
            [Validation(Required=false)]
            public List<PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList> LivePlayInfoList { get; set; }
            public class PollingConfirmStatusResponseBodyUniversityPollingCourseStatusResponseLivePlayInfoList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUrl</para>
                /// </summary>
                [NameInMap("liveInputUrl")]
                [Validation(Required=false)]
                public string LiveInputUrl { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUrl</para>
                /// </summary>
                [NameInMap("liveOutputUrl")]
                [Validation(Required=false)]
                public string LiveOutputUrl { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("liveType")]
                [Validation(Required=false)]
                public long? LiveType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUrl</para>
                /// </summary>
                [NameInMap("replayUrl")]
                [Validation(Required=false)]
                public string ReplayUrl { get; set; }

            }

        }

    }

}
