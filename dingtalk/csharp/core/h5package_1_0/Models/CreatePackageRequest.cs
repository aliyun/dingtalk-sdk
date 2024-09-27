// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh5package_1_0.Models
{
    public class CreatePackageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/myapp/index.html">https://example.com/myapp/index.html</a></para>
        /// </summary>
        [NameInMap("homeUrl")]
        [Validation(Required=false)]
        public string HomeUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aaaaaa/bbbbbb</para>
        /// </summary>
        [NameInMap("ossObjectKey")]
        [Validation(Required=false)]
        public string OssObjectKey { get; set; }

    }

}
