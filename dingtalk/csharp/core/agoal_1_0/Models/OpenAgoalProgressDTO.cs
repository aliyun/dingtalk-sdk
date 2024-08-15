// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalProgressDTO : TeaModel {
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
        public OpenAgoalUserDTO Creator { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("htmlContent")]
        [Validation(Required=false)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public OpenAgoalUserDTO Modifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progressId")]
        [Validation(Required=false)]
        public string ProgressId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("updated")]
        [Validation(Required=false)]
        public long? Updated { get; set; }

    }

}
