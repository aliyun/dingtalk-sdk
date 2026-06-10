// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class ListWorkflowsRequest : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
