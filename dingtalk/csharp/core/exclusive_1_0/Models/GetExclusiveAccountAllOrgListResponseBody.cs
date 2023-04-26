// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetExclusiveAccountAllOrgListResponseBody : TeaModel {
        [NameInMap("orgInfoList")]
        [Validation(Required=false)]
        public List<GetExclusiveAccountAllOrgListResponseBodyOrgInfoList> OrgInfoList { get; set; }
        public class GetExclusiveAccountAllOrgListResponseBodyOrgInfoList : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("isMainOrg")]
            [Validation(Required=false)]
            public bool? IsMainOrg { get; set; }

            [NameInMap("logoUrl")]
            [Validation(Required=false)]
            public string LogoUrl { get; set; }

            [NameInMap("orgFullName")]
            [Validation(Required=false)]
            public string OrgFullName { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

        }

    }

}
