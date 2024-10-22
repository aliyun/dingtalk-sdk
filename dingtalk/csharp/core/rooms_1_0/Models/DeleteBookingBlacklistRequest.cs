// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class DeleteBookingBlacklistRequest : TeaModel {
        [NameInMap("blacklistUnionIds")]
        [Validation(Required=false)]
        public List<string> BlacklistUnionIds { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
