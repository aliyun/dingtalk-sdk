// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AddCrmPersonalCustomerRequest : TeaModel {
        /// <summary>
        /// 记录创建人的用户ID
        /// </summary>
        [NameInMap("creatorUserId")]
        [Validation(Required=false)]
        public string CreatorUserId { get; set; }

        /// <summary>
        /// 记录创建人的昵称
        /// </summary>
        [NameInMap("creatorNick")]
        [Validation(Required=false)]
        public string CreatorNick { get; set; }

        /// <summary>
        /// 数据内容
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// 扩展数据内容
        /// </summary>
        [NameInMap("extendData")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendData { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        [NameInMap("permission")]
        [Validation(Required=false)]
        public AddCrmPersonalCustomerRequestPermission Permission { get; set; }
        public class AddCrmPersonalCustomerRequestPermission : TeaModel {
            [NameInMap("ownerStaffIds")]
            [Validation(Required=false)]
            public List<string> OwnerStaffIds { get; set; }
            [NameInMap("participantStaffIds")]
            [Validation(Required=false)]
            public List<string> ParticipantStaffIds { get; set; }
        };

    }

}
