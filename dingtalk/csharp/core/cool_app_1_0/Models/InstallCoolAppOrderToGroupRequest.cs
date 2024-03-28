// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcool_app_1_0.Models
{
    public class InstallCoolAppOrderToGroupRequest : TeaModel {
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        [NameInMap("sortedPluginIdList")]
        [Validation(Required=false)]
        public List<long?> SortedPluginIdList { get; set; }

        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("unsortedPluginIdList")]
        [Validation(Required=false)]
        public List<long?> UnsortedPluginIdList { get; set; }

    }

}
