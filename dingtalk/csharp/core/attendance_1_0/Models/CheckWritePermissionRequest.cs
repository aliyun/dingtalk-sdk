// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CheckWritePermissionRequest : TeaModel {
        /// <summary>
        /// category
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// entityIds
        /// </summary>
        [NameInMap("entityIds")]
        [Validation(Required=false)]
        public List<long?> EntityIds { get; set; }

        /// <summary>
        /// opUserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// resourceKey
        /// </summary>
        [NameInMap("resourceKey")]
        [Validation(Required=false)]
        public string ResourceKey { get; set; }

    }

}
