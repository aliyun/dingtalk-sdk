// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateRobotInOrgRequest : TeaModel {
        [NameInMap("brief")]
        [Validation(Required=false)]
        public string Brief { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("icon")]
        [Validation(Required=false)]
        public string Icon { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("outgoingToken")]
        [Validation(Required=false)]
        public string OutgoingToken { get; set; }

        [NameInMap("outgoingUrl")]
        [Validation(Required=false)]
        public string OutgoingUrl { get; set; }

        [NameInMap("previewMediaId")]
        [Validation(Required=false)]
        public string PreviewMediaId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
