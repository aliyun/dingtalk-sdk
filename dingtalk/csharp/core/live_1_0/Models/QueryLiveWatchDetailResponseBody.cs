// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QueryLiveWatchDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryLiveWatchDetailResponseBodyResult Result { get; set; }
        public class QueryLiveWatchDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// 平均观看时长
            /// </summary>
            [NameInMap("avgWatchTime")]
            [Validation(Required=false)]
            public long? AvgWatchTime { get; set; }

            /// <summary>
            /// 观看直播人数
            /// </summary>
            [NameInMap("liveUv")]
            [Validation(Required=false)]
            public int? LiveUv { get; set; }

            /// <summary>
            /// 消息数
            /// </summary>
            [NameInMap("msgCount")]
            [Validation(Required=false)]
            public int? MsgCount { get; set; }

            /// <summary>
            /// 观看回放人数
            /// </summary>
            [NameInMap("playbackUv")]
            [Validation(Required=false)]
            public int? PlaybackUv { get; set; }

            /// <summary>
            /// 点赞数
            /// </summary>
            [NameInMap("praiseCount")]
            [Validation(Required=false)]
            public int? PraiseCount { get; set; }

            /// <summary>
            /// 观看次数
            /// </summary>
            [NameInMap("pv")]
            [Validation(Required=false)]
            public int? Pv { get; set; }

            /// <summary>
            /// 观看总时长
            /// </summary>
            [NameInMap("totalWatchTime")]
            [Validation(Required=false)]
            public long? TotalWatchTime { get; set; }

            /// <summary>
            /// 观看人数
            /// </summary>
            [NameInMap("uv")]
            [Validation(Required=false)]
            public int? Uv { get; set; }

        }

    }

}
