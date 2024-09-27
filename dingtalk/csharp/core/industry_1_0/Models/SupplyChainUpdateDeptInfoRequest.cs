// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyChainUpdateDeptInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>名称</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("partnerNumber")]
        [Validation(Required=false)]
        public string PartnerNumber { get; set; }

        [NameInMap("partnerTypeList")]
        [Validation(Required=false)]
        public List<long?> PartnerTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1231</para>
        /// </summary>
        [NameInMap("superId")]
        [Validation(Required=false)]
        public long? SuperId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>576488112</para>
        /// </summary>
        [NameInMap("supplyDeptId")]
        [Validation(Required=false)]
        public long? SupplyDeptId { get; set; }

    }

}
