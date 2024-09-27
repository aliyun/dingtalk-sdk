// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetMediaUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@wesfsdfsfwe</para>
        /// </summary>
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86399</para>
        /// </summary>
        [NameInMap("urlExpireTime")]
        [Validation(Required=false)]
        public int? UrlExpireTime { get; set; }

    }

}
