// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class OpenAgoalLatestProgressDTO : TeaModel {
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
        [NameInMap("htmldescription")]
        [Validation(Required=false)]
        public string Htmldescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("progressId")]
        [Validation(Required=false)]
        public string ProgressId { get; set; }

    }

}
