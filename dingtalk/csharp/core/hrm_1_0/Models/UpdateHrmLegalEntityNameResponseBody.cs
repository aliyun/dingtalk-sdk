// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class UpdateHrmLegalEntityNameResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateHrmLegalEntityNameResponseBodyResult Result { get; set; }
        public class UpdateHrmLegalEntityNameResponseBodyResult : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("legalEntityId")]
            [Validation(Required=false)]
            public string LegalEntityId { get; set; }

            [NameInMap("legalEntityName")]
            [Validation(Required=false)]
            public string LegalEntityName { get; set; }

            [NameInMap("legalEntityShortName")]
            [Validation(Required=false)]
            public string LegalEntityShortName { get; set; }

            [NameInMap("legalEntityStatus")]
            [Validation(Required=false)]
            public int? LegalEntityStatus { get; set; }

            [NameInMap("legalPersonName")]
            [Validation(Required=false)]
            public string LegalPersonName { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
