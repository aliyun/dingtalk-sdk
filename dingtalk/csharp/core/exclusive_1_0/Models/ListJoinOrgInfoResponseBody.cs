// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListJoinOrgInfoResponseBody : TeaModel {
        [NameInMap("orgInfoList")]
        [Validation(Required=false)]
        public List<ListJoinOrgInfoResponseBodyOrgInfoList> OrgInfoList { get; set; }
        public class ListJoinOrgInfoResponseBodyOrgInfoList : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("orgFullName")]
            [Validation(Required=false)]
            public string OrgFullName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public long? OrgName { get; set; }

        }

    }

}
