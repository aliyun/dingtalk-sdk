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
            /// <summary>
            /// 业务ID
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// 群会话ID
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
