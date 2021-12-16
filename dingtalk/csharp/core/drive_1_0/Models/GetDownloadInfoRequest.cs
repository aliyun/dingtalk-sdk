// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetDownloadInfoRequest : TeaModel {
        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// 是否返回内网加签url
        /// </summary>
        [NameInMap("withInternalResourceUrl")]
        [Validation(Required=false)]
        public bool? WithInternalResourceUrl { get; set; }

        /// <summary>
        /// 是否返回区域信息
        /// </summary>
        [NameInMap("withRegion")]
        [Validation(Required=false)]
        public bool? WithRegion { get; set; }

    }

}
