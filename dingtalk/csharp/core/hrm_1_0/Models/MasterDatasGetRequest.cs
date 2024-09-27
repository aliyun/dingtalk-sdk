// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDatasGetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uk1231</para>
        /// </summary>
        [NameInMap("objId")]
        [Validation(Required=false)]
        public string ObjId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PERFORMANCE</para>
        /// </summary>
        [NameInMap("scopeCode")]
        [Validation(Required=false)]
        public string ScopeCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>base</para>
        /// </summary>
        [NameInMap("viewEntityCode")]
        [Validation(Required=false)]
        public string ViewEntityCode { get; set; }

    }

}
