// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class GetPictureDownloadUrlRequest : TeaModel {
        /// <summary>
        /// 服务窗机器人图片消息图片下载码。
        /// 开发者需要接入服务窗自建机器人后根据图片回调消息内容获取到对应的downloadCode。
        /// </summary>
        [NameInMap("downloadCode")]
        [Validation(Required=false)]
        public string DownloadCode { get; set; }

        /// <summary>
        /// 服务窗机器人消息sessionId。
        /// 开发者需要接入服务窗自建机器人后通过回调消息获取到的sessionId。
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
