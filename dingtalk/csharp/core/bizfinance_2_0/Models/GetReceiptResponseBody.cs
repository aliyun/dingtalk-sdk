// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class GetReceiptResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;operatorUserId&quot;:&quot;015865244722391178&quot;,&quot;data&quot;:{&quot;amount&quot;:{&quot;amountStr&quot;:&quot;566&quot;},&quot;code&quot;:&quot;d0d54815-32c5-4b18-8391-e79713bba95e&quot;,&quot;payeeAt&quot;:1637251200000,&quot;departmentCode&quot;:&quot;-1&quot;,&quot;project&quot;:{&quot;projectCode&quot;:&quot;PROJ_101761F3FF6B21362ECA000N&quot;,&quot;projectName&quot;:&quot;客户合作项目&quot;},&quot;principalId&quot;:&quot;015865244722391178&quot;,&quot;enterpriseAccount&quot;:{},&quot;approvedAt&quot;:1637305373000,&quot;title&quot;:&quot;地狱猫提交的智能财务-收款&quot;,&quot;createAt&quot;:1637305353000,&quot;paymentAt&quot;:1637251200000,&quot;supplier&quot;:{},&quot;operateUserId&quot;:&quot;015865244722391178&quot;,&quot;applicantEmployeeId&quot;:&quot;015865244722391178&quot;,&quot;comment&quot;:&quot;ffff&quot;,&quot;category&quot;:{&quot;categoryCode&quot;:&quot;INC_1016D6CB3C181E28F0120009&quot;,&quot;categoryName&quot;:&quot;销售收入&quot;},&quot;customer&quot;:{&quot;customerCode&quot;:&quot;CUS_10178592ECEC2133C893000F&quot;,&quot;customerName&quot;:&quot;钉钉&quot;},&quot;status&quot;:&quot;agree&quot;}}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EM-1017F28E03350B1738B3000X</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>approval</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
