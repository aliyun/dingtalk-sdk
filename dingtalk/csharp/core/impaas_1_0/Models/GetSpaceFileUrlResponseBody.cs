// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetSpaceFileUrlResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, object> Headers { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("internalResourceUrl")]
        [Validation(Required=false)]
        public string InternalResourceUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

    }

}
