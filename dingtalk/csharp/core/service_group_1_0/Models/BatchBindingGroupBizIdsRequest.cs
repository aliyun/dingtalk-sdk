// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchBindingGroupBizIdsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bindingGroupBizIds")]
        [Validation(Required=false)]
        public List<BatchBindingGroupBizIdsRequestBindingGroupBizIds> BindingGroupBizIds { get; set; }
        public class BatchBindingGroupBizIdsRequestBindingGroupBizIds : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
