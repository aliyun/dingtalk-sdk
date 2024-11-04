// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class CreateAssistantRequest : TeaModel {
        [NameInMap("customAgentMobileLink")]
        [Validation(Required=false)]
        public string CustomAgentMobileLink { get; set; }

        [NameInMap("customAgentPCLink")]
        [Validation(Required=false)]
        public string CustomAgentPCLink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("instructions")]
        [Validation(Required=false)]
        public string Instructions { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

        [NameInMap("recommendPrompts")]
        [Validation(Required=false)]
        public List<string> RecommendPrompts { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("welcomeContent")]
        [Validation(Required=false)]
        public string WelcomeContent { get; set; }

    }

}
