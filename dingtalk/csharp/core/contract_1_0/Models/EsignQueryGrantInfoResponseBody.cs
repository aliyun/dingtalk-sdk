// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignQueryGrantInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EsignQueryGrantInfoResponseBodyResult Result { get; set; }
        public class EsignQueryGrantInfoResponseBodyResult : TeaModel {
            [NameInMap("legalPerson")]
            [Validation(Required=false)]
            public string LegalPerson { get; set; }

            [NameInMap("mobilePhoneNumber")]
            [Validation(Required=false)]
            public string MobilePhoneNumber { get; set; }

            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

            [NameInMap("unifiedSocialCredit")]
            [Validation(Required=false)]
            public string UnifiedSocialCredit { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
