// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ApplyFollowerAuthInfoRequest : TeaModel {
        [NameInMap("appAuthKey")]
        [Validation(Required=false)]
        public string AppAuthKey { get; set; }

        [NameInMap("fieldScope")]
        [Validation(Required=false)]
        public string FieldScope { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
