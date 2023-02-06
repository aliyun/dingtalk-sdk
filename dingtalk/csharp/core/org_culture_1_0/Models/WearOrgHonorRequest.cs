// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class WearOrgHonorRequest : TeaModel {
        /// <summary>
        /// 员工userid
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 佩戴true，卸下false
        /// </summary>
        [NameInMap("wear")]
        [Validation(Required=false)]
        public bool? Wear { get; set; }

    }

}
