// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class VerifyEduUserCertificationResponseBody : TeaModel {
        [NameInMap("certificated")]
        [Validation(Required=false)]
        public bool? Certificated { get; set; }

        [NameInMap("certificatedCorpId")]
        [Validation(Required=false)]
        public string CertificatedCorpId { get; set; }

        [NameInMap("certificatedOrgName")]
        [Validation(Required=false)]
        public string CertificatedOrgName { get; set; }

        [NameInMap("certificatedUserId")]
        [Validation(Required=false)]
        public string CertificatedUserId { get; set; }

    }

}
