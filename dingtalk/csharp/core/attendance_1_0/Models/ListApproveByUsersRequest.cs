// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ListApproveByUsersRequest : TeaModel {
        [NameInMap("bizTypes")]
        [Validation(Required=false)]
        public List<int?> BizTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1678636800000</para>
        /// </summary>
        [NameInMap("fromDateTime")]
        [Validation(Required=false)]
        public long? FromDateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1678636800000</para>
        /// </summary>
        [NameInMap("toDateTime")]
        [Validation(Required=false)]
        public long? ToDateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user1,user2</para>
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

    }

}
