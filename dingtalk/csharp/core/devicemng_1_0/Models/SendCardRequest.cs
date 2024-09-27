// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class SendCardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>biz-xxxxx</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;var1&quot;:&quot;xxx&quot;,&quot;var2&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxceshi_1</para>
        /// </summary>
        [NameInMap("deviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Device-3bb10262-31f9-494f-9fde-0a910b8exxxx</para>
        /// </summary>
        [NameInMap("deviceUuid")]
        [Validation(Required=false)]
        public string DeviceUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cide+m5TmAcxA3OU6Un59xxxx==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("partVisible")]
        [Validation(Required=false)]
        public bool? PartVisible { get; set; }

        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<string> Receivers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcxxxxxxxx</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("topbox")]
        [Validation(Required=false)]
        public bool? Topbox { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0123459456</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
