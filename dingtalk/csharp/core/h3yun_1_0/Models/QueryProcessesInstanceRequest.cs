// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class QueryProcessesInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>006f870b-4d1c-4cd0-85b3-2e866798e947</para>
        /// </summary>
        [NameInMap("bizObjectId")]
        [Validation(Required=false)]
        public string BizObjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0001833abb0fb61524487eb01848207bc89b47</para>
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

    }

}
