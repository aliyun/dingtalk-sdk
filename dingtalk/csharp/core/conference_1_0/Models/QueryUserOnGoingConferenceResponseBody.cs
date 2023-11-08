// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryUserOnGoingConferenceResponseBody : TeaModel {
        [NameInMap("memberModelMap")]
        [Validation(Required=false)]
        public Dictionary<string, MemberModelMapValue> MemberModelMap { get; set; }

        [NameInMap("onGoingConfIdList")]
        [Validation(Required=false)]
        public List<string> OnGoingConfIdList { get; set; }

    }

}
