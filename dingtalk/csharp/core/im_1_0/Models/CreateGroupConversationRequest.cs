// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateGroupConversationRequest : TeaModel {
        /// <summary>
        /// 钉外成员列表。
        /// </summary>
        [NameInMap("appUserIds")]
        [Validation(Required=false)]
        public List<string> AppUserIds { get; set; }

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
        /// 群主在业务系统内的唯一标识
        /// </summary>
        [NameInMap("groupOwnerId")]
        [Validation(Required=false)]
        public string GroupOwnerId { get; set; }

        /// <summary>
        /// 群主类型<2.钉内用户类型 3.钉外用户类型>，如果不指定的话，默认是钉钉用户类型
        /// </summary>
        [NameInMap("groupOwnerType")]
        [Validation(Required=false)]
        public int? GroupOwnerType { get; set; }

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
