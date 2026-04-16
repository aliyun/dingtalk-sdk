// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class GetFilterResponseBody : TeaModel {
        [NameInMap("criteria")]
        [Validation(Required=false)]
        public Dictionary<string, CriteriaValue> Criteria { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("range")]
        [Validation(Required=false)]
        public string Range { get; set; }

    }

}
