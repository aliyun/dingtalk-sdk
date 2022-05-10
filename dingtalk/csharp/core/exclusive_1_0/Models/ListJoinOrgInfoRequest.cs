// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListJoinOrgInfoRequest : TeaModel {
        /// <summary>
        /// 手机号码，企业内必须唯一，不可重复。如果是国际号码，请使用+xx-xxxxxx的格式。
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

    }

}
