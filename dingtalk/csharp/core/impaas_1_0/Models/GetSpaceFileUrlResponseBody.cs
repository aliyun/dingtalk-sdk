// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetSpaceFileUrlResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, object> Headers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("internalResourceUrl")]
        [Validation(Required=false)]
        public string InternalResourceUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("resourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

    }

}
