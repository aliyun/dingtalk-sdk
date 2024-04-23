// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class CreateFieldResponseBody : TeaModel {
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("property")]
        [Validation(Required=false)]
        public Dictionary<string, object> Property { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
