// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class ChangeGroupOwnerResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("newGroupOwnerId")]
        [Validation(Required=false)]
        public string NewGroupOwnerId { get; set; }

        [NameInMap("newGroupOwnerType")]
        [Validation(Required=false)]
        public int? NewGroupOwnerType { get; set; }

    }

}
