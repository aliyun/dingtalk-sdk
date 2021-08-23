// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class GetVillageOrgInfoResponseBody : TeaModel {
        /// <summary>
        /// 区域类型
        /// </summary>
        [NameInMap("regionType")]
        [Validation(Required=false)]
        public string RegionType { get; set; }

        /// <summary>
        /// 行政区ID
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 具体的企业区域位置信息
        /// </summary>
        [NameInMap("regionLocation")]
        [Validation(Required=false)]
        public string RegionLocation { get; set; }

    }

}
