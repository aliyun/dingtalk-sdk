// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class GetRecycleBinRequest : TeaModel {
        [NameInMap("recycleBinScope")]
        [Validation(Required=false)]
        public string RecycleBinScope { get; set; }

        [NameInMap("scopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
