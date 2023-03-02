// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class BatchQueryFamilySchoolMessageRequest : TeaModel {
        /// <summary>
        /// 接收卡片的群的openConversationId
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("openMessageIds")]
        [Validation(Required=false)]
        public List<string> OpenMessageIds { get; set; }

        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
