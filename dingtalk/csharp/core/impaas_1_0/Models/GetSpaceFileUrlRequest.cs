// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetSpaceFileUrlRequest : TeaModel {
        /// <summary>
        /// 钉盘文件id
        /// </summary>
        [NameInMap("fileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// 发送人互通账号
        /// </summary>
        [NameInMap("senderUid")]
        [Validation(Required=false)]
        public string SenderUid { get; set; }

        /// <summary>
        /// 钉盘spaceId
        /// </summary>
        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
