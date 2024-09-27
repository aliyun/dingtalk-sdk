// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class TerminateCloudAuthorizationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>hexaaaa</para>
        /// </summary>
        [NameInMap("accessKey")]
        [Validation(Required=false)]
        public string AccessKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>44234122</para>
        /// </summary>
        [NameInMap("callerUnionId")]
        [Validation(Required=false)]
        public string CallerUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
