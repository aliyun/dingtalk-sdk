// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ListOwnedOrgByStaffIdResponseBody : TeaModel {
        /// <summary>
        /// 组织列表
        /// </summary>
        [NameInMap("orgList")]
        [Validation(Required=false)]
        public List<ListOwnedOrgByStaffIdResponseBodyOrgList> OrgList { get; set; }
        public class ListOwnedOrgByStaffIdResponseBodyOrgList : TeaModel {
            /// <summary>
            /// corpId
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// corpName
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

        }

    }

}
