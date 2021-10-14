// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class CreateGroupRequest : TeaModel {
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        [NameInMap("creatorUid")]
        [Validation(Required=false)]
        public string CreatorUid { get; set; }

        [NameInMap("iconMediaId")]
        [Validation(Required=false)]
        public string IconMediaId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, string> Properties { get; set; }

        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
