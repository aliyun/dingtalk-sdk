// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_2_0.Models
{
    public class GetFormDataByIDRequest : TeaModel {
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        [NameInMap("useAlias")]
        [Validation(Required=false)]
        public bool? UseAlias { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
