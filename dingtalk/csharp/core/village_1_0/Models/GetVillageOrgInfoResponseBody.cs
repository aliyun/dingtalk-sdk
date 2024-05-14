// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetVillageOrgInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("regionLocation")]
        [Validation(Required=false)]
        public string RegionLocation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("regionType")]
        [Validation(Required=false)]
        public string RegionType { get; set; }

    }

}
