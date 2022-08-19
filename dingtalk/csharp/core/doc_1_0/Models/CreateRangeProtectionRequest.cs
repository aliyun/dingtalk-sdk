// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class CreateRangeProtectionRequest : TeaModel {
        /// <summary>
        /// 其它用户的权限
        /// </summary>
        [NameInMap("otherUserPermission")]
        [Validation(Required=false)]
        public string OtherUserPermission { get; set; }

        /// <summary>
        /// 操作人unionId
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
