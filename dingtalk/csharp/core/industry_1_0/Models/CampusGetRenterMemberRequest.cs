// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusGetRenterMemberRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1987215</para>
        /// </summary>
        [NameInMap("renterId")]
        [Validation(Required=false)]
        public long? RenterId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1iasndkjas8</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
