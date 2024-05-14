// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class DelOrgAccUserOwnnessRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ownenssType")]
        [Validation(Required=false)]
        public long? OwnenssType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ownnessId")]
        [Validation(Required=false)]
        public long? OwnnessId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
