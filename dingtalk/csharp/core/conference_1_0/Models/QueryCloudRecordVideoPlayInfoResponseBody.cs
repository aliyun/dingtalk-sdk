// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryCloudRecordVideoPlayInfoResponseBody : TeaModel {
        /// <summary>
        /// 时长
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [NameInMap("fileSize")]
        [Validation(Required=false)]
        public long? FileSize { get; set; }

        /// <summary>
        /// MP4格式下载链接
        /// </summary>
        [NameInMap("mp4FileUrl")]
        [Validation(Required=false)]
        public string Mp4FileUrl { get; set; }

        /// <summary>
        /// 在线播放链接
        /// </summary>
        [NameInMap("playUrl")]
        [Validation(Required=false)]
        public string PlayUrl { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

    }

}
