// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class ListGroupStaffMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<ListGroupStaffMembersResponseBodyMembers> Members { get; set; }
        public class ListGroupStaffMembersResponseBodyMembers : TeaModel {
            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

    }

}
