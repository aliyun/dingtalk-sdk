// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpackage_1_0.Models
{
    public class HUploadPackageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5000000002793153</para>
        /// </summary>
        [NameInMap("miniAppId")]
        [Validation(Required=false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ossObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

    }

}
