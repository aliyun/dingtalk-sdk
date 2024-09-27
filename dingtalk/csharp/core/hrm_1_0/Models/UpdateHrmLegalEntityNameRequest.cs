// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class UpdateHrmLegalEntityNameRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>57</para>
        /// </summary>
        [NameInMap("dingTenantId")]
        [Validation(Required=false)]
        public long? DingTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>公司2</para>
        /// </summary>
        [NameInMap("legalEntityName")]
        [Validation(Required=false)]
        public string LegalEntityName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>公司1</para>
        /// </summary>
        [NameInMap("originLegalEntityName")]
        [Validation(Required=false)]
        public string OriginLegalEntityName { get; set; }

    }

}
