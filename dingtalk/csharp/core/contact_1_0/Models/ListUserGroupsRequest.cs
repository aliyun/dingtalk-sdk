// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListUserGroupsRequest : TeaModel {
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
