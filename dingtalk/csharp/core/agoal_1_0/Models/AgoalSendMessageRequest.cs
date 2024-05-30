// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalSendMessageRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mobileUrl")]
        [Validation(Required=false)]
        public string MobileUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pcUrl")]
        [Validation(Required=false)]
        public string PcUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sourceDingUserId")]
        [Validation(Required=false)]
        public string SourceDingUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("targetDingUserIds")]
        [Validation(Required=false)]
        public List<string> TargetDingUserIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
