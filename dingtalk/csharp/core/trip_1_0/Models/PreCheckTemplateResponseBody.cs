// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class PreCheckTemplateResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PreCheckTemplateResponseBodyResult Result { get; set; }
        public class PreCheckTemplateResponseBodyResult : TeaModel {
            [NameInMap("blockRecords")]
            [Validation(Required=false)]
            public List<PreCheckTemplateResponseBodyResultBlockRecords> BlockRecords { get; set; }
            public class PreCheckTemplateResponseBodyResultBlockRecords : TeaModel {
                [NameInMap("blockType")]
                [Validation(Required=false)]
                public string BlockType { get; set; }

                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            [NameInMap("pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
