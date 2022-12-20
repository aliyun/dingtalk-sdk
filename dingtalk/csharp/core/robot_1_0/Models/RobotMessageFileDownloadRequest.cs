// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class RobotMessageFileDownloadRequest : TeaModel {
        /// <summary>
        /// 机器人收到消息中的下载码，换取临时下载文件的链接使用。
        /// </summary>
        [NameInMap("downloadCode")]
        [Validation(Required=false)]
        public string DownloadCode { get; set; }

        /// <summary>
        /// 机器人的robotCode。
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
