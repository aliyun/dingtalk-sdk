// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetUserAllLiveListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetUserAllLiveListResponseBodyResult Result { get; set; }
        public class GetUserAllLiveListResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否拉取完成
            /// </summary>
            [NameInMap("hasFinish")]
            [Validation(Required=false)]
            public bool? HasFinish { get; set; }

            /// <summary>
            /// 直播详情
            /// </summary>
            [NameInMap("liveInfoPopModelList")]
            [Validation(Required=false)]
            public List<GetUserAllLiveListResponseBodyResultLiveInfoPopModelList> LiveInfoPopModelList { get; set; }
            public class GetUserAllLiveListResponseBodyResultLiveInfoPopModelList : TeaModel {
                /// <summary>
                /// 直播额外信息
                /// </summary>
                [NameInMap("extraInfo")]
                [Validation(Required=false)]
                public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo ExtraInfo { get; set; }
                public class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListExtraInfo : TeaModel {
                    /// <summary>
                    /// 是否关注
                    /// </summary>
                    [NameInMap("hasSubscribed")]
                    [Validation(Required=false)]
                    public bool? HasSubscribed { get; set; }

                    /// <summary>
                    /// 预告是否过期
                    /// </summary>
                    [NameInMap("isForecastExpired")]
                    [Validation(Required=false)]
                    public bool? IsForecastExpired { get; set; }

                    /// <summary>
                    /// 回放观看进度
                    /// </summary>
                    [NameInMap("watchProgressMs")]
                    [Validation(Required=false)]
                    public long? WatchProgressMs { get; set; }

                }

                /// <summary>
                /// 直播基础信息
                /// </summary>
                [NameInMap("liveBasicInfo")]
                [Validation(Required=false)]
                public GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo LiveBasicInfo { get; set; }
                public class GetUserAllLiveListResponseBodyResultLiveInfoPopModelListLiveBasicInfo : TeaModel {
                    /// <summary>
                    /// 直播封面
                    /// </summary>
                    [NameInMap("coverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    /// <summary>
                    /// 直播时长
                    /// </summary>
                    [NameInMap("duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// 直播真实结束时间
                    /// </summary>
                    [NameInMap("endTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// 直播简介
                    /// </summary>
                    [NameInMap("introduction")]
                    [Validation(Required=false)]
                    public string Introduction { get; set; }

                    /// <summary>
                    /// 直播id
                    /// </summary>
                    [NameInMap("liveId")]
                    [Validation(Required=false)]
                    public string LiveId { get; set; }

                    /// <summary>
                    /// 直播观看地址
                    /// </summary>
                    [NameInMap("livePlayUrl")]
                    [Validation(Required=false)]
                    public string LivePlayUrl { get; set; }

                    /// <summary>
                    /// 直播状态
                    /// </summary>
                    [NameInMap("liveStatus")]
                    [Validation(Required=false)]
                    public int? LiveStatus { get; set; }

                    /// <summary>
                    /// 直播真实开始时间
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                    /// <summary>
                    /// 预约人数
                    /// </summary>
                    [NameInMap("subscribeCount")]
                    [Validation(Required=false)]
                    public int? SubscribeCount { get; set; }

                    /// <summary>
                    /// 直播标题
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// 主播id
                    /// </summary>
                    [NameInMap("unionId")]
                    [Validation(Required=false)]
                    public string UnionId { get; set; }

                    /// <summary>
                    /// 观看人数
                    /// </summary>
                    [NameInMap("uv")]
                    [Validation(Required=false)]
                    public int? Uv { get; set; }

                }

            }

        }

    }

}
