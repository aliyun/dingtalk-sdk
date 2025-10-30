// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkblackboard_1_0.Models
{
    public class GetBlackboardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ca80xxxx0a04</para>
        /// </summary>
        [NameInMap("blackboardId")]
        [Validation(Required=false)]
        public string BlackboardId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager01</para>
        /// </summary>
        [NameInMap("operationUserId")]
        [Validation(Required=false)]
        public string OperationUserId { get; set; }

    }

}
