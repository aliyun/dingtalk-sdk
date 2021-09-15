// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AbandonCustomerResponseBody : TeaModel {
        /// <summary>
        /// 成功退回公海的客户实例 id 数组
        /// </summary>
        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

    }

}
