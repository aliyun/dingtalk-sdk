// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class AddShareCidListRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupIdType")]
        [Validation(Required=false)]
        public long? GroupIdType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("groupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
