// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetOssTempUrlRequest : TeaModel {
        /// <summary>
        /// 团队开放ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// oss文件key
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// 访问模式 AUTO(自动，例如在浏览器中如果是图片，PDF等可以在线直接查看，不能在线看时自动下载)、DOWNLOAD（直接下载）
        /// </summary>
        [NameInMap("fetchMode")]
        [Validation(Required=false)]
        public string FetchMode { get; set; }

    }

}
