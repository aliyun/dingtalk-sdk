// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AbandonCustomerRequest : TeaModel {
        /// <summary>
        /// 自定义动态描述
        /// </summary>
        [NameInMap("customTrackDesc")]
        [Validation(Required=false)]
        public string CustomTrackDesc { get; set; }

        /// <summary>
        /// 客户实例 id 数组
        /// </summary>
        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        /// <summary>
        /// 操作人staffId，一般为企业员工
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// 释放类型：returnPool-退回公海（默认），innerAbandon-仅清除负责人
        /// </summary>
        [NameInMap("optType")]
        [Validation(Required=false)]
        public string OptType { get; set; }

    }

}
