// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class AddShareCidListRequest : TeaModel {
        /// <summary>
        /// 传入的群id类型（1 chatId / 2 openConversationId ）
        /// </summary>
        [NameInMap("groupIdType")]
        [Validation(Required=false)]
        public long? GroupIdType { get; set; }

        /// <summary>
        /// 添加的联播群列表
        /// </summary>
        [NameInMap("groupIds")]
        [Validation(Required=false)]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 操作的的组织内id(staffId)
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
