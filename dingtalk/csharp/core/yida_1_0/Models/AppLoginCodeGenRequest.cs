// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class AppLoginCodeGenRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signTimestampStr")]
        [Validation(Required=false)]
        public string SignTimestampStr { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("fullUrl")]
        [Validation(Required=false)]
        public string FullUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
