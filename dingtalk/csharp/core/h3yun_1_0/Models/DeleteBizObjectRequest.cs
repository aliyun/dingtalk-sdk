// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class DeleteBizObjectRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a1ce0ab-0181-4dc2-9968-793d20906b27</para>
        /// </summary>
        [NameInMap("bizObjectId")]
        [Validation(Required=false)]
        public string BizObjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0001839bbbbe346bbf496498bb76c44c7eb972</para>
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

    }

}
