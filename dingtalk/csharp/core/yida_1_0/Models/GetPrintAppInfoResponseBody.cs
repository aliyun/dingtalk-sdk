// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetPrintAppInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetPrintAppInfoResponseBodyResult> Result { get; set; }
        public class GetPrintAppInfoResponseBodyResult : TeaModel {
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("appType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("formInfoList")]
            [Validation(Required=false)]
            public List<GetPrintAppInfoResponseBodyResultFormInfoList> FormInfoList { get; set; }
            public class GetPrintAppInfoResponseBodyResultFormInfoList : TeaModel {
                [NameInMap("formName")]
                [Validation(Required=false)]
                public string FormName { get; set; }

                [NameInMap("formUuid")]
                [Validation(Required=false)]
                public string FormUuid { get; set; }

            }

            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

        }

    }

}
