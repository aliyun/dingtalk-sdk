// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QueryLiveInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryLiveInfoResponseBodyResult Result { get; set; }
        public class QueryLiveInfoResponseBodyResult : TeaModel {
            [NameInMap("liveInfo")]
            [Validation(Required=false)]
            public QueryLiveInfoResponseBodyResultLiveInfo LiveInfo { get; set; }
            public class QueryLiveInfoResponseBodyResultLiveInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png">https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png</a></para>
                /// </summary>
                [NameInMap("coverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18450</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1659653648000</para>
                /// </summary>
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试直播简介</para>
                /// </summary>
                [NameInMap("introduction")]
                [Validation(Required=false)]
                public string Introduction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1a353547-040d-4095-bb93-404bc5d47920</para>
                /// </summary>
                [NameInMap("liveId")]
                [Validation(Required=false)]
                public string LiveId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://h5.dingtalk.com/group-live-share/index.htm?type=2&liveFromType=6&liveUuid=1a353547-040d-4095-bb93-404bc5d47920&dd_nav_bgcolor=FF2C2D2F#/union">https://h5.dingtalk.com/group-live-share/index.htm?type=2&amp;liveFromType=6&amp;liveUuid=1a353547-040d-4095-bb93-404bc5d47920&amp;dd_nav_bgcolor=FF2C2D2F#/union</a></para>
                /// </summary>
                [NameInMap("livePlayUrl")]
                [Validation(Required=false)]
                public string LivePlayUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("liveStatus")]
                [Validation(Required=false)]
                public int? LiveStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18430</para>
                /// </summary>
                [NameInMap("playbackDuration")]
                [Validation(Required=false)]
                public long? PlaybackDuration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1659613648000</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("subscribeCount")]
                [Validation(Required=false)]
                public int? SubscribeCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>测试直播</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DC7wZGOSueEEIGOf3WKwWgiEiE</para>
                /// </summary>
                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("uv")]
                [Validation(Required=false)]
                public int? Uv { get; set; }

            }

        }

    }

}
