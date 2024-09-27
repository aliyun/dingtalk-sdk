// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class WearOrgHonorRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>accs233sxx</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("wear")]
        [Validation(Required=false)]
        public bool? Wear { get; set; }

    }

}
