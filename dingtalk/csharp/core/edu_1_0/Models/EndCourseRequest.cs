// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EndCourseRequest : TeaModel {
        /// <summary>
        /// 课程编码
        /// </summary>
        [NameInMap("courseCode")]
        [Validation(Required=false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// isv编码
        /// </summary>
        [NameInMap("isvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        /// <summary>
        /// 直播流信息
        /// </summary>
        [NameInMap("livePlayInfoList")]
        [Validation(Required=false)]
        public List<EndCourseRequestLivePlayInfoList> LivePlayInfoList { get; set; }
        public class EndCourseRequestLivePlayInfoList : TeaModel {
            /// <summary>
            /// 直播拉流地址
            /// </summary>
            [NameInMap("liveOutputUrl")]
            [Validation(Required=false)]
            public string LiveOutputUrl { get; set; }

            /// <summary>
            /// 直播流类型
            /// </summary>
            [NameInMap("liveType")]
            [Validation(Required=false)]
            public int? LiveType { get; set; }

            /// <summary>
            /// 直播推流地址
            /// </summary>
            [NameInMap("liveInputUrl")]
            [Validation(Required=false)]
            public string LiveInputUrl { get; set; }

            /// <summary>
            /// 回放视频地址
            /// </summary>
            [NameInMap("replayUrl")]
            [Validation(Required=false)]
            public string ReplayUrl { get; set; }

        }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
