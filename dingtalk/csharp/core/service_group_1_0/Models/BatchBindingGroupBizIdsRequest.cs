// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchBindingGroupBizIdsRequest : TeaModel {
        [NameInMap("bindingGroupBizIds")]
        [Validation(Required=false)]
        public List<BatchBindingGroupBizIdsRequestBindingGroupBizIds> BindingGroupBizIds { get; set; }
        public class BatchBindingGroupBizIdsRequestBindingGroupBizIds : TeaModel {
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
