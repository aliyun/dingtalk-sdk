// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusDelRenterMemberRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>124353123</para>
        /// </summary>
        [NameInMap("renterId")]
        [Validation(Required=false)]
        public long? RenterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kindg****</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
