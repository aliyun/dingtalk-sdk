// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusUpdateCampusGroupRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("campusProjectGroupId")]
        [Validation(Required=false)]
        public long? CampusProjectGroupId { get; set; }

        [NameInMap("extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
