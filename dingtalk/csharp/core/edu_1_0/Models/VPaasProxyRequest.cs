// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class VPaasProxyRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>init</para>
        /// </summary>
        [NameInMap("actionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;a&quot;:&quot;testA&quot;,&quot;b&quot;:&quot;testB&quot;}</para>
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCVGpgpjjbBS1Pg1tYx23KDJiXokVdKFLdJznKxQe+fZcIOtcQDIYrfrBfHmiC/gASeF5NUTSrwjkr/i/2gqhIIxRinNJQm8L4GJ6fRGjN8tND7AfhfkGYIfOJCLFSiaYSa4TCM7WsmztkpR7DSvb4P+K/ppqYFfUB46a9nCcvecQIDAQAB</para>
        /// </summary>
        [NameInMap("publicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

    }

}
