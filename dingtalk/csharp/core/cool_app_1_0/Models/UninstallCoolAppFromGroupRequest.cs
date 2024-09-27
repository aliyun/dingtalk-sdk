// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcool_app_1_0.Models
{
    public class UninstallCoolAppFromGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cidxxx</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CoolApp-xxx</para>
        /// </summary>
        [NameInMap("operateCoolAppCode")]
        [Validation(Required=false)]
        public string OperateCoolAppCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>staffid111</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-id-xxx</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
