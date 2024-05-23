// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class TitleMention : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("user")]
        [Validation(Required=false)]
        public OpenAgoalUserDTO User { get; set; }

    }

}
