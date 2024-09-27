// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdpaas_1_0.Models
{
    public class InstallCoolAppOrderToGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cidxxx</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("sortedPluginIdList")]
        [Validation(Required=false)]
        public List<long?> SortedPluginIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-id-xxx</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("unsortedPluginIdList")]
        [Validation(Required=false)]
        public List<long?> UnsortedPluginIdList { get; set; }

    }

}
