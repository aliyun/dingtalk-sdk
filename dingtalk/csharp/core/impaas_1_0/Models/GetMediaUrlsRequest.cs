// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetMediaUrlsRequest : TeaModel {
        /// <summary>
        /// 多媒体id列表
        /// </summary>
        [NameInMap("mediaIds")]
        [Validation(Required=false)]
        public List<string> MediaIds { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [NameInMap("urlExpireTime")]
        [Validation(Required=false)]
        public int? UrlExpireTime { get; set; }

    }

}
