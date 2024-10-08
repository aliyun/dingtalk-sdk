// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class IsFriendRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>15968883355</para>
        /// </summary>
        [NameInMap("mobileNo")]
        [Validation(Required=false)]
        public string MobileNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>098231</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
