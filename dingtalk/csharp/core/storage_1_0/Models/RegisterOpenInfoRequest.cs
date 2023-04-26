// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RegisterOpenInfoRequest : TeaModel {
        [NameInMap("openInfos")]
        [Validation(Required=false)]
        public List<RegisterOpenInfoRequestOpenInfos> OpenInfos { get; set; }
        public class RegisterOpenInfoRequestOpenInfos : TeaModel {
            [NameInMap("openType")]
            [Validation(Required=false)]
            public string OpenType { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
