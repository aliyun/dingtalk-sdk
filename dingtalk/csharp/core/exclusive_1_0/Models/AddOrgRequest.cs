// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class AddOrgRequest : TeaModel {
        /// <summary>
        /// 手机号
        /// </summary>
        [NameInMap("mobileNum")]
        [Validation(Required=false)]
        public string MobileNum { get; set; }

        /// <summary>
        /// 组织名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
