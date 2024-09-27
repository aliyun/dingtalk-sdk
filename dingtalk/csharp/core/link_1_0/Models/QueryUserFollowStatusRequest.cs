// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class QueryUserFollowStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding1234</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
