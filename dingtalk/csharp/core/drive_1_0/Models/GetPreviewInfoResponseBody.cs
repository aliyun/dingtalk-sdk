// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetPreviewInfoResponseBody : TeaModel {
        /// <summary>
        /// 预览信息
        /// </summary>
        [NameInMap("info")]
        [Validation(Required=false)]
        public GetPreviewInfoResponseBodyInfo Info { get; set; }
        public class GetPreviewInfoResponseBodyInfo : TeaModel {
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }
        };

    }

}
