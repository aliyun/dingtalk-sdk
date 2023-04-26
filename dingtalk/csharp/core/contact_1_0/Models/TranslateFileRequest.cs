// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TranslateFileRequest : TeaModel {
        [NameInMap("medias")]
        [Validation(Required=false)]
        public Dictionary<string, string> Medias { get; set; }

        [NameInMap("outputFileName")]
        [Validation(Required=false)]
        public string OutputFileName { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
