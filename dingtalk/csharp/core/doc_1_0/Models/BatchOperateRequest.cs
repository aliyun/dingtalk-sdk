// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class BatchOperateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>requests</para>
        /// </summary>
        [NameInMap("requests")]
        [Validation(Required=false)]
        public List<BatchOperateRequestRequests> Requests { get; set; }
        public class BatchOperateRequestRequests : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public object Body { get; set; }

            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

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
