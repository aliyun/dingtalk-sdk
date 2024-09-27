// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class PrivateDataValue : TeaModel {
        [NameInMap("cardParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> CardParamMap { get; set; }

        [NameInMap("cardMediaIdParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, string> CardMediaIdParamMap { get; set; }

    }

}
