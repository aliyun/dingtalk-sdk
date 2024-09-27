// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkblackboard_1_0.Models
{
    public class QueryBlackboardReadUnReadRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49dc87dc1b30cd099b13a</para>
        /// </summary>
        [NameInMap("blackboardId")]
        [Validation(Required=false)]
        public string BlackboardId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xb1dc</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager01</para>
        /// </summary>
        [NameInMap("operationUserId")]
        [Validation(Required=false)]
        public string OperationUserId { get; set; }

    }

}
