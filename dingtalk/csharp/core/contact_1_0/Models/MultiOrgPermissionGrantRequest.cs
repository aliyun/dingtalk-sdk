// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class MultiOrgPermissionGrantRequest : TeaModel {
        /// <summary>
        /// 被授权的部门，如果不填则默认全组织
        /// </summary>
        [NameInMap("grantDeptIdList")]
        [Validation(Required=false)]
        public List<long?> GrantDeptIdList { get; set; }

        /// <summary>
        /// 授权加入的组织corpId
        /// </summary>
        [NameInMap("joinCorpId")]
        [Validation(Required=false)]
        public string JoinCorpId { get; set; }

    }

}
