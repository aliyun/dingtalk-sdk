// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EndCourseRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>testCourseCode</para>
        /// </summary>
        [NameInMap("courseCode")]
        [Validation(Required=false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>extData</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DDIsv</para>
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("livePlayInfoList")]
        [Validation(Required=false)]
        public List<EndCourseRequestLivePlayInfoList> LivePlayInfoList { get; set; }
        public class EndCourseRequestLivePlayInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>testUrl</para>
            /// </summary>
            [NameInMap("liveInputUrl")]
            [Validation(Required=false)]
            public string LiveInputUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testUrl</para>
            /// </summary>
            [NameInMap("liveOutputFlvUrl")]
            [Validation(Required=false)]
            public string LiveOutputFlvUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testUrl</para>
            /// </summary>
            [NameInMap("liveOutputHlsUrl")]
            [Validation(Required=false)]
            public string LiveOutputHlsUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("liveType")]
            [Validation(Required=false)]
            public int? LiveType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testUrl</para>
            /// </summary>
            [NameInMap("replayUrl")]
            [Validation(Required=false)]
            public string ReplayUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
