// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class OpenProgressDTO : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("created")]
        [Validation(Required=false)]
        public long? Created { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public OpenUserDTO Creator { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("htmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public OpenUserDTO Modifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public long? Updated { get; set; }

    }

}
