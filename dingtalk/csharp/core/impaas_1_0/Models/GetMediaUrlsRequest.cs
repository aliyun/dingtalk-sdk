// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetMediaUrlsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("mediaIds")]
        [Validation(Required=false)]
        public List<string> MediaIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86399</para>
        /// </summary>
        [NameInMap("urlExpireTime")]
        [Validation(Required=false)]
        public int? UrlExpireTime { get; set; }

    }

}
