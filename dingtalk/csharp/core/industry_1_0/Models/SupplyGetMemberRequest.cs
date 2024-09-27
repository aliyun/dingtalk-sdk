// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyGetMemberRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>19912345678</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
