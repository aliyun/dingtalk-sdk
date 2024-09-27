// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AddCustomerTrackRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://******">华佗</a>创建了合同：<b>今日合同</b></para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fb037d68-c1bd-4be2-8c3b-6739261d1332</para>
        /// </summary>
        [NameInMap("customerId")]
        [Validation(Required=false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;bizId&quot;:&quot;1&quot;}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("extraBizInfo")]
        [Validation(Required=false)]
        public string ExtraBizInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fb037d68-c1bd-4be2-8c3b-6739261d1332-1</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("idempotentKey")]
        [Validation(Required=false)]
        public string IdempotentKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://******">华佗</a>创建了合同：<b>今日合同</b></para>
        /// </summary>
        [NameInMap("maskedContent")]
        [Validation(Required=false)]
        public string MaskedContent { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager1120</para>
        /// </summary>
        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crm_customer</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>创建合同</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>212</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
