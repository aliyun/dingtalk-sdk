// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateStoreGroupConversationRequest : TeaModel {
        /// <summary>
        /// 钉外账号在业务系统内的唯一标识。
        /// </summary>
        [NameInMap("appUserId")]
        [Validation(Required=false)]
        public string AppUserId { get; set; }

        /// <summary>
        /// 外部业务唯一标识（店铺唯一标识）。
        /// </summary>
        [NameInMap("businessUniqueKey")]
        [Validation(Required=false)]
        public string BusinessUniqueKey { get; set; }

        /// <summary>
        /// 群头像地址。
        /// </summary>
        [NameInMap("groupAvatar")]
        [Validation(Required=false)]
        public string GroupAvatar { get; set; }

        /// <summary>
        /// 群名称。
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 群模板Id。
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// 操作者在业务系统内的唯一标识。
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 钉内成员列表。
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
