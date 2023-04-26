// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class ModifyFeedWhiteListRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public long? Action { get; set; }

        [NameInMap("modifyUserList")]
        [Validation(Required=false)]
        public List<string> ModifyUserList { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
