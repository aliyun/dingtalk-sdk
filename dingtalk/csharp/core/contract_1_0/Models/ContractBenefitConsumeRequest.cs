// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ContractBenefitConsumeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esign</para>
        /// </summary>
        [NameInMap("benefitPoint")]
        [Validation(Required=false)]
        public string BenefitPoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sjdaujii129w9qej2nqas</para>
        /// </summary>
        [NameInMap("bizRequestId")]
        [Validation(Required=false)]
        public string BizRequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("consumeQuota")]
        [Validation(Required=false)]
        public long? ConsumeQuota { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding1231ndu29923312</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding12939912nduaejjwe</para>
        /// </summary>
        [NameInMap("isvCorpId")]
        [Validation(Required=false)]
        public string IsvCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>djauihjauiwnkndjknkjanaae</para>
        /// </summary>
        [NameInMap("optUnionId")]
        [Validation(Required=false)]
        public string OptUnionId { get; set; }

    }

}
