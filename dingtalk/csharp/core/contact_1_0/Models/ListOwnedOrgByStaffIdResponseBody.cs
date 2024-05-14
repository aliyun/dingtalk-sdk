// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListOwnedOrgByStaffIdResponseBody : TeaModel {
        [NameInMap("orgList")]
        [Validation(Required=false)]
        public List<ListOwnedOrgByStaffIdResponseBodyOrgList> OrgList { get; set; }
        public class ListOwnedOrgByStaffIdResponseBodyOrgList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

        }

    }

}
